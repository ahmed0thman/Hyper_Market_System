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
    public partial class UC_BillCard : UserControl
    {
        public Bill CurrentBill;
        public delegate void ClickBill(Bill bill);
        public static event ClickBill BillClicked;
        public delegate void DeleteBill(Bill bill);
        public static event DeleteBill BillDeleted;
        private List<BalanceMachine> AllAcounts = new List<BalanceMachine>();
        double oldBalance = 0;
        public UC_BillCard(Bill bill)
        {
            InitializeComponent();
            CurrentBill = bill;
            btnShowBill.Text = string.Format("{0:c}",bill.Paid.ToString());
            txtBillId.Text = bill.Id.ToString();
            txtBillNum.Text = bill.IdInDay.ToString();
            txtBillTime.Text = bill.date.ToString("t");
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
            oldBalance = bill.Paid;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            var msg = new CustomeMessageDialogue("تأكيد حذف جميع البيانات الخاصة بالفاتورة", MessageType.Warning);
            var result = msg.ShowDialog();
            if (result == DialogResult.Yes)
            {
                var itemsInBill = BillInfoTable.GetBillInfo(CurrentBill);
                foreach (var item in itemsInBill)
                {
                    item.Quantity = item.Count;
                    ShopTbl.EditQuantity(item);
                }
                BillInfoTable.DeleteBillInfo(CurrentBill);
                BillTbl.DeleteBill(CurrentBill);
                if (CurrentBill.Type == BillType.Buy)
                {
                    StoreInfoTbl.DeleteItemInStoreByBill(CurrentBill.Id.ToString());
                    if (CurrentBill.Account == "الدرج")
                    {
                        WaletTbl.Plus(oldBalance);
                    }
                    else
                    {
                        int machineId = AllAcounts.Find(x => x.Name == CurrentBill.Account).Id;
                        MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                        {
                            Date = DateTime.Now,
                            Machine = new BalanceMachine(machineId),
                            Price = oldBalance,
                            Type = OperationType.Deposit,
                            Details = $"حذف فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                        }
                        );
                        MachineTbl.Plus(oldBalance, machineId);
                    }
                }
                else if (CurrentBill.Type == BillType.Sell)
                {
                    WaletTbl.Minus(oldBalance);
                }
                
                BillDeleted?.Invoke(CurrentBill);
            }

        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            BillClicked?.Invoke(CurrentBill);
        }

        private void btnDebtArchieve_Click(object sender, EventArgs e)
        {
            new FormWindowContainer(new UC_BILLDebts(CurrentBill), $"أرشيف معاملات فاتورة رقم {CurrentBill.Id}");
        }
    }
}
