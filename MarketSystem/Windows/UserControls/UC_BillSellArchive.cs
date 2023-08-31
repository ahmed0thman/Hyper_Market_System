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
    public partial class UC_BillSellArchive : UserControl
    {
        PanelBillSatate panelHandleSearchSatate = PanelBillSatate.Hide;
        List<Bill> BillsList = new List<Bill>();
        bool loadForm = true;
        public UC_BillSellArchive(bool billRequested = false, string BillId = "")
        {
            InitializeComponent();
            dtpBillDate.Value = DateTime.Now;
            UC_BillCard.BillDeleted += UC_BillCard_BillDeleted;
            UC_BILLDebts.PaymentHandeled += UC_BILLDebts_PaymentHandeled;
            //UC_Bill.WaletRefreshed += UC_Bill_WaletRefreshed;
            GetAllBills(dtFrm: DateTime.Now.ToString("d"), dt2: DateTime.Now.AddDays(1).ToString("d"));
            if (billRequested)
            {
                panelBillsCards.Controls.Clear();
                GetAllBills(BillId);
                ShowBills();
                loadForm = false;
            }
            this.Disposed += UC_BillSellArchive_Disposed;

            
        }
        private void UC_BILLDebts_PaymentHandeled()
        {
            panelBillsCards.Controls.Clear();
            GetAllBills(dtFrm: DateTime.Now.ToString("d"), dt2: DateTime.Now.AddDays(1).ToString("d"));
            ShowBills();

        }
        private void UC_BillSellArchive_Disposed(object sender, EventArgs e)
        {
            UC_BillCard.BillDeleted -= UC_BillCard_BillDeleted;
            UC_BILLDebts.PaymentHandeled -= UC_BILLDebts_PaymentHandeled;
            //UC_Bill.WaletRefreshed -= UC_Bill_WaletRefreshed;
        }


        private void UC_Bill_WaletRefreshed()
        {
            try
            {
                GetAllBills(dtFrm: DateTime.Now.ToString("d"), dt2: DateTime.Now.AddDays(1).ToString("d"));
                ShowBills();
            }
            catch (Exception)
            {
            }
        }

        private void UC_BillCard_BillDeleted(Bill bill)
        {
            try
            {
                GetAllBills(dtFrm: DateTime.Now.ToString("d"), dt2: DateTime.Now.AddDays(1).ToString("d"));
                ShowBills();
            }
            catch (Exception)
            {
            }
            
        }

        private void GetAllBills(string id = "", string dtFrm = "", string dt2 = "")
        {
            try
            {
                BillsList.Clear();
                var listTbl = BillTbl.GetBill(BillType.Sell, id, dtFrm, dt2);
                if (listTbl.Count == 0)
                    return;
                
                foreach (var bill in listTbl)
                {

                    BillsList.Add(bill);
                }
            }
            catch (Exception)
            {
            }
            
        }


        private void UC_BillSellArchive_Load(object sender, EventArgs e)
        {
            if (!loadForm)
                return;
            panelBillsCards.Controls.Clear();
            ShowBills();

        }

        private void ShowBills()
        {
            try
            {
                panelBillsCards.Controls.Clear();
                foreach (var bill in BillsList)
                {
                    panelBillsCards.Controls.Add(new UC_BillCard(bill));
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void dtpBillDate_ValueChanged(object sender, EventArgs e)
        {
            GetAllBills(dtFrm: dtpBillDate.Value.ToString("d"), dt2: dtpBillDate.Value.AddDays(1).ToString("d"));
            ShowBills();
        }
    }
}
