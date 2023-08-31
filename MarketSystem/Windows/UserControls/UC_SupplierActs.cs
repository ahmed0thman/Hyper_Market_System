using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL.DB_Classes;
using BL.Enitiies;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_SupplierActs : UserControl
    {
        Person currentPerson;
        public delegate void RefreshWalet();
        public static event RefreshWalet waletRefreshed;
        public delegate void GetBill(string billNum);
        public static event GetBill BillClicked;
        public static event GetBill BillBuyClicked;
        public UC_SupplierActs()
        {
            InitializeComponent();
            colDate.Width = 180;
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;

                base.Dispose();
            };
        }

        private void UC_PersonInfoCard_PersonCardClicked(BL.Enitiies.Person person)
        {
            currentPerson = person;
            GeTallBills(person);

        }

        private void GeTallBills(Person person)
        {
            if(person.Type != PersonType.Supplier)
                dgvClientBills.DataSource = BillTbl.GetTblBill(BL.Enitiies.BillType.Sell, person: person.Id.ToString());
            else
                dgvClientBills.DataSource = BillTbl.GetTblBill(BL.Enitiies.BillType.Buy, person: person.Id.ToString());
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            GetBillsInDate();
        }

        private void GetBillsInDate()
        {
            if (currentPerson is null)
                return;
            if (currentPerson.Type == PersonType.Client)
                dgvClientBills.DataSource = BillTbl.GetTblBill(BL.Enitiies.BillType.Sell,
                dtFrm: dtFrom.Value.ToString("d"),
                dt2: dtTo.Value.ToString("d"),
                person: currentPerson.Id.ToString());
            else
                dgvClientBills.DataSource = BillTbl.GetTblBill(BL.Enitiies.BillType.Buy,
                dtFrm: dtFrom.Value.ToString("d"),
                dt2: dtTo.Value.ToString("d"),
                person: currentPerson.Id.ToString());
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            GetBillsInDate();
        }

        private void dgvClientBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            double rest = double.Parse(dgvClientBills.Rows[i].Cells["colDept"].Value.ToString());
            
            string billId = dgvClientBills.Rows[i].Cells["colBillNum"].Value.ToString();
            using (var msg = new WindowCilentBillsOptions())
            {
                var res = msg.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    if (rest == 0) return;
                    BillTbl.PayDebts(billId);
                    if(currentPerson.Type == PersonType.Client)
                        WaletTbl.Plus(double.Parse(dgvClientBills.Rows[i].Cells["colTotalPrice"].Value.ToString()));
                    else
                        WaletTbl.Minus(double.Parse(dgvClientBills.Rows[i].Cells["colTotalPrice"].Value.ToString()));
                    BillPayment billPayment = new BillPayment()
                    {
                        DateTime = DateTime.Now,
                        Price = double.Parse(dgvClientBills.Rows[i].Cells["colTotalPrice"].Value.ToString()),
                        BillId = int.Parse(billId)
                    };
                    BillPaymentTbl.AddPayment(billPayment);
                    GeTallBills(currentPerson);
                    waletRefreshed?.Invoke();
                }
                else if(res == DialogResult.No)
                {
                    if (currentPerson.Type != PersonType.Supplier)
                        BillClicked?.Invoke(billId);
                    else
                        BillBuyClicked?.Invoke(billId);
                }
            }
        }

        private void dgvClientBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
