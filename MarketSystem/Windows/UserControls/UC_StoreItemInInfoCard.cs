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
    public partial class UC_StoreItemInInfoCard : UserControl
    {
        ItemInStore currentItem;
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        public UC_StoreItemInInfoCard(ItemInStore itemInStore)
        {
            InitializeComponent();
            if (itemInStore.Unit == itemInStore.SmallUnit)
                btnTrasfer.Hide();
            currentItem = itemInStore;
            lblStoreName.Text = itemInStore.Store.Name;
            lblDateExpire.Text = itemInStore.ExpirationDate;
            lblBill.Text = itemInStore.Bill;
            lblQuantity.Text = itemInStore.Quantity.ToString();
            lblUnit.Text = itemInStore.Unit;
            lblPrice.Text = itemInStore.Unit == itemInStore.SmallUnit ? itemInStore.SmallUnitSellPrice.ToString() : itemInStore.BigUnitSellPrice.ToString();
            if (lblStoreName.Text == "المحل")
            if (currentItem.ItemState == ItemState.Indeed)
                SetItemStatus(Color.Blue);
           
            if (currentItem.ItemState == ItemState.Empty)
            SetItemStatus(Color.DarkViolet);
            else
            {
                if (currentItem.ItemStoreState == ItemStoreState.Expired)
                    SetItemStoreStatus(Color.Red);
                else if (currentItem.ItemStoreState == ItemStoreState.IsExpiring)
                    SetItemStoreStatus(Color.Orange);
            }
            


        }

        private void SetItemStoreStatus(Color color)
        {
            picItemState.FillColor = color;
            lblItemState.ForeColor = color;
            lblItemState.Text = currentItem.ItemStoreState.ToStr();
        }

        private void SetItemStatus(Color color)
        {
            picItemState.FillColor = color;
            lblItemState.ForeColor = color;
            lblItemState.Text = currentItem.ItemState.ToStr();
        }

        private void btnEditItemInStore_Click(object sender, EventArgs e)
        {
            using (WindowEditStoreItemInfo frmEditingItem = new WindowEditStoreItemInfo(currentItem))
            {
                frmEditingItem.ShowDialog();
            }
        }

        private void btnDeleteItemInStore_Click(object sender, EventArgs e)
        {
            using (CustomeMessageDialogue MsgBox = new CustomeMessageDialogue("تأكيد حذف المنتج!", MessageType.Warning))
            {
                DialogResult result = MsgBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (currentItem.Store.Id > 1)
                            StoreInfoTbl.DeleteItemInStore(currentItem);
                        else
                            ShopTbl.DeleteItemInShop(currentItem.IdInShop.ToString());
                        DataRefreshed?.Invoke();
                        ActivityTbl.SaveActivity(new Activitiy()
                        {
                            Employee = Program.EmpLogedin,
                            Date = DateTime.Now,
                            ActivityType = ActivityType.Delete,
                            Description = currentItem.Name + ": " + currentItem.Name
                        });
                    }
                    catch (Exception)
                    {
                        new CustomeMessageDialogue("لا يمكنك حذف الصنف");
                    }
                }
            }
        }

        private void btnTrasfer_Click(object sender, EventArgs e)
        {
            using (WindowTransferItem frmTransfer = new WindowTransferItem(currentItem))
            {
                frmTransfer.ShowDialog();
            }
        }
    }
}
