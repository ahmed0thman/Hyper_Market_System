using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Enitiies;
using DL.DB_Classes;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_BILLDebts : UserControl
    {
        private List<BalanceMachine> AllAcounts = new List<BalanceMachine>();
        Bill currentBill;
        public delegate void HandleBillPayment();
        public static event HandleBillPayment PaymentHandeled;
        BillPayment currentPayment;
        public UC_BILLDebts(Bill bill)
        {
            InitializeComponent();
            currentBill = bill;
            dtPayment.Value = DateTime.Now;
            GetAllAcounts();
            GetAllPaymentsInfo();
        }
        private void GetAllAcounts()
        {
            AllAcounts.Clear();
            var accounts = MachineTbl.GetMachines();
            for (int i = 0; i < accounts.Rows.Count; i++)
            {
                BalanceMachine account = new BalanceMachine()
                {
                    Id = int.Parse(accounts.Rows[i][BalanceMachine.IDC].ToString()),
                    Name = accounts.Rows[i][BalanceMachine.NAMEC].ToString(),
                    Balance = double.Parse(accounts.Rows[i][BalanceMachine.BALANCEC].ToString())
                };
                AllAcounts.Add(account);
            }
        }

        private void GetAllPaymentsInfo()
        {
            lblBillDateTime.Text = currentBill.date.ToString();
            lblBillID.Text = currentBill.Id.ToString();
            lblTotal.Text = currentBill.TotalPrice.ToString();
            lblPaid.Text = currentBill.Paid.ToString();
            lblRest.Text = currentBill.Rest.ToString();
            dgvBillPayments.DataSource = BillPaymentTbl.GetPayment(currentBill.Id);
        }

        private void dgvBillPayments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using(var msg = new CustomeMessageDialogue("تأكيد حذف العلمية؟", MessageType.Warning))
            {
                var res = msg.ShowDialog();
                if(res == DialogResult.Yes)
                {
                    GetCurrentPaymentInfo();
                    BillPaymentTbl.DeletePayment(currentPayment);
                    BillTbl.BillPaidMinus(currentBill.Id, currentPayment.Price);
                    currentBill.Paid -= currentPayment.Price;
                    currentBill.Rest += currentPayment.Price;
                    if (currentBill.Account == "الدرج")
                    {
                        if (currentBill.Type == BillType.Buy)
                            WaletTbl.Plus(currentPayment.Price);
                        else
                            WaletTbl.Minus(currentPayment.Price);
                    }
                    else
                    {
                        int machineId = AllAcounts.Find(x => x.Name == currentBill.Account).Id;
                        MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                        {
                            Date = DateTime.Now,
                            Machine = new BalanceMachine(machineId),
                            Price = Math.Abs(currentPayment.Price),
                            Type = currentBill.Type == BillType.Buy ? OperationType.Deposit : OperationType.Transaction,
                            Details = $"حذف ااقساط فاتورة بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + currentBill.IdInDay.ToString()
                            + "\n" + $"المبلغ {currentPayment.Price}"
                        }
                        );
                        if(currentBill.Type == BillType.Buy)
                            MachineTbl.Plus(currentPayment.Price, machineId);
                        else
                            MachineTbl.Minus(currentPayment.Price, machineId);
                    }
                    MyTools.ClearUCWidget(this);
                    GetAllPaymentsInfo();
                    PaymentHandeled?.Invoke();
                }
            }
        }

        private void btnSavePayment_Click(object sender, EventArgs e)
        {
            bool vaildprice = double.TryParse(txtPayment.Text.Trim(), out double price);
            if (!vaildprice)
            {
                new CustomeMessageDialogue("تأكد من ادخال قيمة صحيحة");
                txtPayment.SelectAll();
                txtPayment.Focus();
                return;
            }
            if (price > currentBill.Rest)
            {
                new CustomeMessageDialogue("المدفوع لا يزيد عن باقى الفاتورة");
                txtPayment.SelectAll();
                txtPayment.Focus();
                return;
            }
            BillPayment billPayment = new BillPayment()
            {
                DateTime = dtPayment.Value,
                Price = price,
                Details = txtDetails.Text.Trim(),
                BillId = currentBill.Id
            };
            BillPaymentTbl.AddPayment(billPayment);
            BillTbl.BillPaidPlus(currentBill.Id, price);
            currentBill.Paid += price;
            currentBill.Rest -= price;
            if(currentBill.Account == "الدرج")
            {
                if (currentBill.Type == BillType.Buy)
                    WaletTbl.Minus(price);
                else
                    WaletTbl.Plus(price);
            }
            else
            {
                int machineId = AllAcounts.Find(x => x.Name == currentBill.Account).Id;
                MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                {
                    Date = DateTime.Now,
                    Machine = new BalanceMachine(machineId),
                    Price = Math.Abs(price),
                    Type = currentBill.Type == BillType.Buy ? OperationType.Transaction : OperationType.Deposit,
                    Details = $"تسديد ااقساط فاتورة بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + currentBill.IdInDay.ToString()
                    + "\n" + $"المبلغ {price}"
                }
                );
                if (currentBill.Type == BillType.Buy)
                    MachineTbl.Minus(price, machineId);
                else
                    MachineTbl.Plus(price, machineId);
            }
            MyTools.ClearUCWidget(this);
            GetAllPaymentsInfo();
            PaymentHandeled?.Invoke();
        }

        private void dgvBillPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetCurrentPaymentInfo();

        }

        private void GetCurrentPaymentInfo()
        {
            dtPayment.Text = dgvBillPayments.CurrentRow.Cells["colDate"].Value.ToString();
            txtPayment.Text = dgvBillPayments.CurrentRow.Cells["colPrice"].Value.ToString();
            txtDetails.Text = dgvBillPayments.CurrentRow.Cells["colDetails"].Value.ToString();
            currentPayment = new BillPayment()
            {
                Id = int.Parse(dgvBillPayments.CurrentRow.Cells["colId"].Value.ToString()),
                Price = double.Parse(dgvBillPayments.CurrentRow.Cells["colPrice"].Value.ToString())
            };
        }
    }
}
