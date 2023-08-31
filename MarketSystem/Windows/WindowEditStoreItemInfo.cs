
using BL.Enitiies;
using DL.DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem.Windows
{
    public partial class WindowEditStoreItemInfo : Form
    {
        ItemInStore CurrentItem;
        Dictionary<string, string> dictStores;
        public delegate void ClickBtnSave();
        public static event ClickBtnSave BtnSaveClicked;
        public delegate void RefershData();
        public static event RefershData DataRefreshed;
        public WindowEditStoreItemInfo(ItemInStore itemIn)
        {
            CurrentItem = itemIn;
            InitializeComponent();
            
            
            lblItemName.Text = itemIn.Name;
            txtQuantity.Text = itemIn.Quantity.ToString();
            txtPrice.Text = itemIn.Unit == itemIn.SmallUnit? itemIn.SmallUnitSellPrice.ToString(): itemIn.BigUnitSellPrice.ToString();
            
            if (itemIn.ExpirationDate is null)
                dtExp.Hide();
            else
            {
                bool done = DateTime.TryParse(itemIn.ExpirationDate, out DateTime dt);
                if (done)
                    dtExp.Value = dt;
            }
               
            
            cbxUnit.DataSource = new BindingSource(new List<string>() { itemIn.SmallUnit , itemIn.BigUnit}, null);
            cbxUnit.Text = itemIn.Unit;
            FillCbxStores();
            cbxStores.Text = dictStores.First(x => x.Key == itemIn.Store.Id.ToString()).Value;

        }

        private void btnSaveItemInfo_Click(object sender, EventArgs e)
        {
            
            var item = new ItemInStore()
            {
                Code = CurrentItem.Code,
                Id = CurrentItem.Id,
                IdInShop = CurrentItem.IdInShop,
                Store = CurrentItem.Store,
                Quantity = double.Parse(txtQuantity.Text.Trim()),
                Unit = CurrentItem.SmallUnit,
                Price = CurrentItem.Price,
                ExpirationDate = CurrentItem.IsExpiring == "yes" ? dtExp.Value.ToString("yyyy-MM-dd") : "",
            };
            item.Price = CurrentItem.SmallUnitSellPrice;
            item.BigUnitSellPrice = CurrentItem.BigUnitSellPrice;
            item.Unit = cbxUnit.Text;
            if (cbxUnit.SelectedIndex == 1)
            {
                item.Unit = cbxUnit.Text;
                item.Price = CurrentItem.BigUnitSellPrice;
            }
            if(cbxStores.SelectedIndex > 0)
            StoreInfoTbl.EditItemInStore(item);
            else
            {
                ShopTbl.EditItemInShop(item);
            }
            
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Edit,
                Description = item.Code + ": " + item.Name +  ": " + item.ExpirationDate + ": " + item.Quantity
            });
            BtnSaveClicked?.Invoke();
            this.Close();
        }

        private void FillCbxStores()
        {
            dictStores = new Dictionary<string, string>();
            var stores = StoreTbl.GetAllStores();
            if (stores.Count == 0)
                return;
            foreach (var store in stores)
            {
                dictStores.Add(store.Id.ToString(), store.Name);
            }
            cbxStores.DataSource = new BindingSource(dictStores, null);
            cbxStores.DisplayMember = "Value";
            cbxStores.ValueMember = "Key";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            using (CustomeMessageDialogue MsgBox = new CustomeMessageDialogue("لن يتم تعديل البيانات.", MessageType.Warning))
            {
                DialogResult result = MsgBox.ShowDialog();
                if (result == DialogResult.Yes)
                    this.Close();
                else return;
            }
        }

        private void cbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cbxUnit.SelectedIndex == 0 ? CurrentItem.SmallUnitSellPrice.ToString() : CurrentItem.BigUnitSellPrice.ToString();
        }


    }
}
