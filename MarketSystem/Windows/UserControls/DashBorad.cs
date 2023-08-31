using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using DL.DB_Classes;
using BL.Enitiies;
using DL;

namespace MarketSystem.Windows.UserControls
{
    public partial class DashBorad : UserControl
    {
        List<Bill> billsSell;
        List<Bill> billsBuy;
        public DashBorad()
        {
            InitializeComponent();
            dtpTodayInfo.Value = DateTime.Now;
            //UC_OutGoings.WaletRefreshed += UC_OutGoings_WaletRefreshed;
            //UC_BILLDebts.PaymentHandeled += UC_OutGoings_WaletRefreshed;
            //UC_Machines.OperationHandeled += UC_OutGoings_WaletRefreshed;
            //WindowHandleDepts.DataRefreshed += UC_OutGoings_WaletRefreshed;
            //UC_SupplierActs.waletRefreshed += UC_OutGoings_WaletRefreshed;
            //UC_Bill.WaletRefreshed += UC_OutGoings_WaletRefreshed;
            //UC_BillBuy.WaletRefreshed += UC_OutGoings_WaletRefreshed;
            //UC_BillCard.BillDeleted += UC_BillCard_BillDeleted;
            //UC_PersonInfoCard.DebtsPaied += UC_OutGoings_WaletRefreshed;


        }

        private void FillCbxYears()
        {
            for (int i = 2020; i <= 2040; i++)
            {
                cbxYears.Items.Add(i);
            }
            cbxYears.Text = DateTime.Now.Year.ToString();
        }

        private void UC_BillCard_BillDeleted(Bill bill)
        {
            GetTodayInfo();
        }

        private void UC_OutGoings_WaletRefreshed()
        {
            GetTodayInfo();
        }

        private void DashBorad_Load(object sender, EventArgs e)
        {
            GetTodayInfo();
            
            //GetImportantNotes();
            //DayCahrt();
            FillCbxYears();
            //YearlyChart();
        }
        private void GetImportantNotes()
        {
            for (int i = 0; i < 4; i++)
            {
                panelImportantNotes.Controls.Add(new UC_NoteCard());
            }
        }
        private void YearlyChart()
        {
            var allBills =  BillTbl.GetBill(BillType.Sell).FindAll(x => x.date.Year == int.Parse(cbxYears.Text));
            var ValuesIN = new ChartValues<double>();
            for (int i = 1; i <= 12; i++)
            {
                double perMonth = allBills.FindAll(x => x.date.Month == i).Sum(x => x.Paid);
                ValuesIN.Add(perMonth);
            }
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "الدخل",
                    Values =ValuesIN
                }
            };

            //adding series will update and animate the chart automatically
            var Profits = new ChartValues<double>();
            for (int i = 1; i <= 12; i++)
            {
                double perMonth = allBills.FindAll(x => x.date.Month == i).Sum(x => x.profit);
                Profits.Add(perMonth);
            }
            cartesianChart1.Series.Add(new ColumnSeries
            {
                Title = "الربح",
                Values = Profits
            });

            //also adding values updates and animates the chart automatically
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "الشهر",
                Labels = new[] { "يناير", "فبراير", "مارس", "ابريل", "مايو", "يونيو", "يوليو", "اغسطس", "سبتبمر", "اوكتوبر", "نوفمبر", "ديسمبر" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "المبلغ",
                LabelFormatter = value => value.ToString("N")
            });
        }

        //private void DayCahrt()
        //{
        //    Func<ChartPoint, string> labelPoint = chartPoint =>
        //                    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        //    pieChart1.Series = new SeriesCollection
        //    {
        //        new PieSeries
        //        {
        //            Title = "بيبسى",
        //            Values = new ChartValues<double> {18},
        //            PushOut = 10,
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        },
        //        new PieSeries
        //        {
        //            Title = "نوتيلا",
        //            Values = new ChartValues<double> {20},
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        },
        //        new PieSeries
        //        {
        //            Title = "قهوة",
        //            Values = new ChartValues<double> {27},
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        },
        //        new PieSeries
        //        {
        //            Title = "اولكر",
        //            Values = new ChartValues<double> {26},
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        }
        //    };

        //    pieChart1.LegendLocation = LegendLocation.Bottom;
        //}

        private void dtpTodayInfo_ValueChanged(object sender, EventArgs e)
        {
            GetTodayInfo();
        }

        private void GetTodayInfo()
        {
            
            GetBillsSellInfo();
            lblWalet.Text = WaletTbl.GeteWaletAMount().ToString();
            GetBillsBuyInfo();
            GetTodayIncomeAndProfits();
            GetTotalOutGoings();
            GetTotalItemsExpired();
            GetTotalItemsNotAvailable();
            GetTotalClientsDebts();
            GetTotalSupplierDebts();
            GetTotalEmpDebts();
            GetAllAccountsInfo();
            GetTodayPaids();
        }

        private void GetTodayPaids()
        {
            lblTodayClientsPaids.Text = BillPaymentTbl.GetTotalBillPaids(dtpTodayInfo.Value.ToString("d"), BillType.Sell).ToString();
            lblTodaySuppPaids.Text = BillPaymentTbl.GetTotalBillPaids(dtpTodayInfo.Value.ToString("d"), BillType.Buy).ToString();
        }

        private void GetAllAccountsInfo()
        {
            var operations = MachineArchiveTbl.GetMachineOperations(dt: dtpTodayInfo.Value.ToString("d"));
            double total = 0;
            double total2 = 0;
            for (int i = 0; i < operations.Rows.Count; i++)
            {
                if(operations.Rows[i]["type"].ToString() == "سحب")
                    total += double.Parse(operations.Rows[i]["price"].ToString());
                else if (operations.Rows[i]["type"].ToString() == "ايداع")
                    total2 += double.Parse(operations.Rows[i]["price"].ToString());
            }
            lblMachineTotal.Text = total.ToString();
            lblMachineCount.Text = total2.ToString();
        }

        private void GetTotalEmpDebts()
        {
            lblEmpsDebts.Text = EmployeeTbl.GetEmployeesWithDept().Sum(x => x.Debt).ToString();
            lblTodayEmpsDebts.Text = EmpOutgoingsTbl.GetAllEmpOutgoingsInDate(dtpTodayInfo.Value.ToString("d"), "اضافة سلفة").ToString();
            lblTodayEmpsPaids.Text = EmpOutgoingsTbl.GetAllEmpOutgoingsInDate(dtpTodayInfo.Value.ToString("d"), "تسديد سلفة").ToString();
        }

        private void GetTotalSupplierDebts()
        {
            var bills = BillTbl.GetBill(BillType.Buy, rest: true);
            lblSupplierDebts.Text = bills.Sum(x => x.Rest).ToString();
            lblTodaySuppDebts.Text = bills.FindAll(g => g.date.Date == dtpTodayInfo.Value.Date).Sum(x => x.Rest).ToString();
        }

        private void GetTotalClientsDebts()
        {
            var bills = BillTbl.GetBill(BillType.Sell, rest: true);
            lblClientsDebts.Text = bills.Sum(x => x.Rest).ToString();
            lblTodayClientsDebts.Text = bills.FindAll(g => g.date.Date == dtpTodayInfo.Value.Date).Sum(x => x.Rest).ToString();
        }

        private void GetTotalItemsNotAvailable()
        {
            List<Item> ItemsInStore = ItemTbl.GetItems();
            int counter = 0;
            foreach (var item in ItemsInStore)
            {
                var items = StoreInfoTbl.GetItemsFromShop(it: item);
                if(items.Count == 0)
                {
                    counter += 1;
                    continue;
                }
                if (items.Find(x => x.Quantity > 0) == null)
                    counter += 1;
            }
            lblItemNotAvailable.Text = counter.ToString();
        }

        private void GetTotalItemsExpired()
        {
            try
            {
                lblItemsExpired.Text = (StoreInfoTbl.GetItemsInStore()
                .FindAll(x => DateTime.Parse(x.ExpirationDate) < DateTime.Today)
                .Count() + StoreInfoTbl.GetItemsFromShop()
                .FindAll(x => DateTime.Parse(x.ExpirationDate) < DateTime.Today)
                .Count()).ToString();
            }
            catch (Exception)
            {
            }
           
        }

        private void GetTotalOutGoings()
        {
            var tbl = OutGoingsTbl.GetOutGoings(dt: dtpTodayInfo.Value.ToString("d"));
            if (tbl.Rows.Count == 0)
            {
                lblOutGoings.Text = "0";
                return;
            }
                
            double total = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                total += double.Parse(tbl.Rows[i]["price"].ToString());
            }
            lblOutGoings.Text = total.ToString();
        }

        private void GetTodayIncomeAndProfits()
        {
            if (Program.EmpLogedin.Permission != EmpPermission.Owner)
                return;
            lblTotalIncome.Text = billsSell.Sum(x => x.Paid).ToString();
            lblTotalProfit.Text = billsSell.FindAll(x => x.Paid > 0).Sum(x => x.profit).ToString();
        }

        private void GetBillsSellInfo()
        {
            billsSell = BillTbl.GetBill(BillType.Sell,
                dtFrm: dtpTodayInfo.Value.ToString("d"),
                dt2:dtpTodayInfo.Value.AddDays(1).ToString("d")
                );
            lblBillSellCount.Text = billsSell.Count.ToString();
            lblBillSellTotal.Text = billsSell.Sum(x => x.Paid).ToString();
        }
        private void GetBillsBuyInfo()
        {
            billsBuy = BillTbl.GetBill(BillType.Buy, dtFrm: dtpTodayInfo.Value.ToString("d"), dt2: dtpTodayInfo.Value.AddDays(1).ToString("d"));
            lblBillBuyCount.Text = billsBuy.Count.ToString();
            lblBillBuyTotal.Text = billsBuy.Sum(x => x.Paid).ToString();
        }

        private void cbxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearlyChart();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            GetTodayInfo();
        }

        private void tglChart_Click(object sender, EventArgs e)
        {
            if (elementHost2.Visible)
            {
                elementHost2.Hide();
            }
            else
            {
                elementHost2.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
