using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Enitiies;
using DL.DB_Classes;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MarketSystem.Windows;
using MarketSystem.Windows.UserControls;

namespace MarketSystem
{
    public partial class Form1 : Form
    {
        public  delegate void LogOut();
        public static event LogOut LogoedOut;
        public Form1()
        {
            InitializeComponent();
            UC_SupplierActs.BillClicked += UC_SupplierActs_BillClicked;
            UC_SupplierActs.BillBuyClicked += UC_SupplierActs_BillBuyClicked;
        }

        private void UC_SupplierActs_BillBuyClicked(string billNum)
        {
            FormWindowContainer WindowBuyBill = new FormWindowContainer(new UC_BillBuy(true, billNum), btnSellBillWindow.Text, true);
        }

        private void UC_SupplierActs_BillClicked(string billNum)
        {
            FormWindowContainer WindowsSellBill = new FormWindowContainer(new UC_Bill(true, billNum), btnSellBillWindow.Text, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // HandleSize();
            lblWelcom.Text = $"Welcome Mr: {Program.EmpLogedin.Name}";
            if (Program.EmpLogedin.Permission == EmpPermission.Cashier)
                return;
            GetDashBoard();

        }

        private void GetDashBoard()
        {
          
            //if (Program.EmpLogedin.Permission != EmpPermission.Owner)
            //    return;
            panelDashBoard.Controls.Add(new DashBorad());
        }

        //private void HandleSize()
        //{
         //   if (Screen.PrimaryScreen.WorkingArea.Width <= 1400)
         //   {
        //        this.Size = Screen.PrimaryScreen.WorkingArea.Size;
              //  this.Location = new Point(0, 0);
         //   }

       // }

        

        private void btnSellBillWindow_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowsSellBill = new FormWindowContainer(new UC_Bill(), btnSellBillWindow.Text, true);
            //WindowsSellBill.Width = (int)(0.7 * Screen.PrimaryScreen.WorkingArea.Width);
        }

        private void btnItemsWindow_Click(object sender, EventArgs e)
        {
            FormWindowContainer ItemsWindow = new FormWindowContainer(new UC_Items(), btnItemsWindow.Text);
        }

        private void btnStoreWindow_Click(object sender, EventArgs e)
        {
            FormWindowContainer StoreWindow = new FormWindowContainer(new UC_Store(), btnStoreWindow.Text);
        }

        private void btnWindowBillBuy_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowBuyBill = new FormWindowContainer(new UC_BillBuy(), btnWindowBillBuy.Text, true);
        }

        private void btnEmpsWindow_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowEmps = new FormWindowContainer(new UC_Employee(), btnEmpsWindow.Text);
        }

        private void btnMachines_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowMachines = new FormWindowContainer(new UC_Machines(), btnMachines.Text);
        }

        private void btnOutgoings_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowOutgoings = new FormWindowContainer(new UC_OutGoings(), btnOutgoings.Text);
        }

        private void btnClinents_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowClients = new FormWindowContainer(new UC_Suppliers(PersonType.Client), btnClinents.Text);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowSuppliers = new FormWindowContainer(new UC_Suppliers(PersonType.Supplier), btnSuppliers.Text);
        }

        private void bntNotes_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowNotes = new FormWindowContainer(new UC_Notes() { Dock = DockStyle.Fill }, bntNotes.Text);
            WindowNotes.Width = (int)(0.75 * Screen.PrimaryScreen.WorkingArea.Width);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using(var msg = new CustomeMessageDialogue("تأكيد تسجيل الخروج", MessageType.Warning))
            {
                var res = msg.ShowDialog();
                if(res == DialogResult.Yes)
                {
                    Program.EmpLogedin = null;
                    LogoedOut?.Invoke();
                    new FormLgn().Show();
                    this.Close();
                }
            }
            
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            using (var msg = new CustomeMessageDialogue("تأكيد تسجيل الخروج", MessageType.Warning))
            {
                var res = msg.ShowDialog();
                if (res != DialogResult.Yes)
                {
                    return;
                }
            }
            if (Program.EmpLogedin.Permission == EmpPermission.Owner)
            {
                using(var msg = new CustomeMessageDialogue("هل تريد انهاء شيفت اليوم؟", MessageType.Warning))
                {
                    var res = msg.ShowDialog();
                    if (res == DialogResult.Yes)
                        WaletTbl.UpdateWaletAMount(0);
                }
            }
            Application.Exit();
        }
    }
}
