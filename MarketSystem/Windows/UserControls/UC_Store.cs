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
using DL;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_Store : UserControl
    {
        Store currentStore;
        bool EditFlag = false;
        List<UC_ItemInStoreCard> CardsList = new List<UC_ItemInStoreCard>();
        Dictionary<string, string> dictEmps;
        int itemsNumPerTime = 10;
        int iter = 0;
        public UC_Store()
        {
            InitializeComponent();
            UC_StoreCard.StoreCardClicked += UC_StoreCard_StoreCardClicked;
            UC_StoreCard.StoreEditClicked += UC_StoreCard_StoreEditClicked;
            UC_StoreCard.DataRefreshed += UC_StoreCard_DataRefreshed;
            UC_ItemInStoreCard.DataRefreshed += UC_ItemInStoreCard_DataRefreshed;
            //WindowEditStoreItemInfo.BtnSaveClicked += WindowEditStoreItemInfo_BtnSaveClicked;
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                UC_StoreCard.StoreCardClicked -= UC_StoreCard_StoreCardClicked;
                UC_StoreCard.StoreEditClicked -= UC_StoreCard_StoreEditClicked;
                UC_StoreCard.DataRefreshed -= UC_StoreCard_DataRefreshed;
                UC_ItemInStoreCard.DataRefreshed -= UC_ItemInStoreCard_DataRefreshed;

                base.Dispose();
            };

        }

        private void WindowEditStoreItemInfo_BtnSaveClicked()
        {
            UC_StoreCard_StoreCardClicked(currentStore);
        }

        private void UC_ItemInStoreCard_DataRefreshed()
        {
            panel9.Show();
            iter = 0;
            GetItemsInCurrentStore();
        }

        private void UC_StoreCard_DataRefreshed()
        {
            GetAllStores();
        }

        private void UC_StoreCard_StoreEditClicked(Store store)
        {
            EditFlag = true;
            currentStore = store;
            ShowStoreInfo();
        }

        private void ShowStoreInfo()
        {
            txtStoreName.Text = currentStore.Name;
            txtStorePhone.Text = currentStore.Phone;
            txtStoreAddress.Text = currentStore.Address;
            cbxStoreEmp.Text = dictEmps.First(x => x.Key == currentStore.Employee.Id.ToString()).Value;
        }

        private void FillCbxEmployee()
        {
            dictEmps = new Dictionary<string, string>();
            var emps = EmployeeTbl.GetEAllmployees();
            if (emps.Count == 0)
                return;
            foreach (var emp in emps)
            {
                dictEmps.Add(emp.Id.ToString(), emp.Name);
            }
            cbxStoreEmp.DataSource = new BindingSource(dictEmps, null);
            cbxStoreEmp.DisplayMember = "Value";
            cbxStoreEmp.ValueMember = "Key";
        }

        private void UC_StoreCard_StoreCardClicked(Store store)
        {
            
            EditFlag = true;
            panel9.Show();
            iter = 0;
            currentStore = store;
            ShowStoreInfo();
            List<ItemInStore> items;
            if(store.Id == 0)
                items = StoreInfoTbl.GetItemsFromShop();
            else
                items = StoreInfoTbl.GetItemsInStore(currentStore.Id.ToString());
            if (items.Count == 0)
            {
                panelItemCards.Controls.Clear();
                txtItemsTotal.Text = "";
                txtTotalGood.Text = "";
                txtTotalIsexpiring.Text = "";
                txtTotalExpied.Text = "";
                return;
            }
            CardsList.Clear();
            txtItemsTotal.Text = CardsList.Count().ToString();
            txtTotalGood.Text = items.Count(x => x.ItemStoreState == ItemStoreState.Good).ToString();
            txtTotalIsexpiring.Text = items.Count(x => x.ItemStoreState == ItemStoreState.IsExpiring).ToString();
            txtTotalExpied.Text = items.Count(x => x.ItemStoreState == ItemStoreState.Expired).ToString();
            foreach (var item in items)
            {
                CardsList.Add(new UC_ItemInStoreCard(item));
            }
            double small_item_total = items.FindAll(x => x.Unit == x.SmallUnit).Sum(u => u.SmallUnitBuyPrice * u.Quantity);
            double big_item_total = items.FindAll(x => x.Unit == x.BigUnit).Sum(u => u.BigUnitBuyPrice * u.Quantity);
            //MessageBox.Show($"{big_item_total}, {small_item_total}");
            lblTotalMoneyInStore.Text = $"{Math.Round(small_item_total + big_item_total):n}";
            GetItemsInCurrentStore();
            
        }

        private void GetItemsInCurrentStore()
        {
            panelItemCards.Controls.Clear();
            MoreItems();
        }

        private void MoreItems()
        {
            int i = 0;
            while (i <= itemsNumPerTime)
            {
                if (iter == CardsList.Count)
                {
                    panel9.Hide();
                    break;
                }
                panelItemCards.Controls.Add(CardsList[iter]);
                iter++;
                i++;
            }
            txtItemsTotal.Text = CardsList.Count().ToString();
        }

        private void UC_Store_Load(object sender, EventArgs e)
        {
            LoadStores();
            FillCbxEmployee();
        }

        private void LoadStores()
        {
            
            GetAllStores();
            if (panelStoresCards.Controls.Count > 4) panel1.Height -= 15;
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            if(txtStoreName.Text == "")
            {
                new CustomeMessageDialogue("يجب ادخال اسم المخزن");
                txtStoreName.Focus();
                return;
            }
            if (!EditFlag)
            {
                SaveNewStore();
            }
            else
            {
                using (var msg = new CustomeMessageDialogue("تأكيد تعديل بيانات المخزن", MessageType.Warning))
                {
                    DialogResult res = msg.ShowDialog();
                    if (res == DialogResult.No)
                        return;

                }
                EditCurrentStore();
            }
            MyTools.ClearWidget(panel3);
            GetAllStores();
        }

        private void GetAllStores()
        {
            var stores = StoreTbl.GetAllStores();
            if (stores.Count == 0)
                return;
            panelStoresCards.Controls.Clear();
            foreach (var store in stores)
            {
                panelStoresCards.Controls.Add(new UC_StoreCard(store));
            }
        }

        private void EditCurrentStore()
        {
            Store store = new Store()
            {
                Id = currentStore.Id,
                Name = txtStoreName.Text.Trim(),
                Address = txtStoreAddress.Text.Trim(),
                Phone = txtStorePhone.Text.Trim(),
                Employee = new Employee() { Id = int.Parse(cbxStoreEmp.SelectedValue.ToString()) }
            };

            StoreTbl.EditStore(store);
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Edit,
                Description = currentStore.Name
            });
            EditFlag = false;
        }

        private void SaveNewStore()
        {
            Store store = new Store()
            {
                Name = txtStoreName.Text.Trim(),
                Address = txtStoreAddress.Text.Trim(),
                Phone = txtStorePhone.Text.Trim(),
                Employee = new Employee() { Id = int.Parse(cbxStoreEmp.SelectedValue.ToString()) }
            };
            StoreTbl.SaveStore(store);
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Add,
                Description = store.Name
            });
        }

        private void cbxItemState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxItemState.SelectedIndex != 0)
                GetItemsToSpecificState(cbxItemState.Text.FromString());
            else
                GetItemsInCurrentStore();
        }

        private void GetItemsToSpecificState(ItemStoreState itemStoreState)
        {
            panelItemCards.Controls.Clear();
            foreach (var item in CardsList)
            {
                if(item.currentItem.ItemStoreState == itemStoreState)
                    panelItemCards.Controls.Add(item);
            }
            
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            EditFlag = false;
            MyTools.ClearWidget(panel3);
        }

        private void btnShowMore_Click_1(object sender, EventArgs e)
        {
            MoreItems();
        }
    }
}
