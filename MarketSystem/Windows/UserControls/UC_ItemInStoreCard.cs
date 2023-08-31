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
    
    public partial class UC_ItemInStoreCard : UserControl
    {
        public ItemInStore currentItem;
        public delegate void ClickItemCard();
        public static event ClickItemCard CardItemCliked;
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        public UC_ItemInStoreCard(ItemInStore itemInStore)
        {
            InitializeComponent();
            currentItem = itemInStore;
            lblItemName.Text = itemInStore.Name;
            lblDateExpire.Text = itemInStore.ExpirationDate;
            lblBill.Text = itemInStore.Bill;
            lblQuantity.Text = itemInStore.Quantity.ToString();
            if (currentItem.ItemStoreState == ItemStoreState.Expired)
                SetItemStoreStatus(Color.Red);
            else if (currentItem.ItemStoreState == ItemStoreState.IsExpiring)
                SetItemStoreStatus(Color.Orange);

            
        }

        private void SetItemStoreStatus(Color color)
        {
            picItemState.FillColor = color;
            lblItemState.ForeColor = color;
            lblItemState.Text = currentItem.ItemStoreState.ToStr();
        }

        private void guna2ShadowPanel2_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void lblBill_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void lblDateExpire_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void lblItemState_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void picItemState_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {
            CardItemCliked?.Invoke();
        }

        private void btnEditItemInStore_Click(object sender, EventArgs e)
        {
            using(WindowEditStoreItemInfo frmEditingItem = new WindowEditStoreItemInfo(currentItem))
            {
                frmEditingItem.ShowDialog();
            }
        }

        private void btnDeleteItemInStore_Click(object sender, EventArgs e)
        {
            using (CustomeMessageDialogue MsgBox = new CustomeMessageDialogue("تأكيد حذف المنتج من المخزن!", MessageType.Warning))
            {
                DialogResult result = MsgBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    StoreInfoTbl.DeleteItemInStore(currentItem);
                    ActivityTbl.SaveActivity(new Activitiy()
                    {
                        Employee = Program.EmpLogedin,
                        Date = DateTime.Now,
                        ActivityType = ActivityType.Edit,
                        Description = currentItem.Code + ": " + currentItem.Name
                    });
                    DataRefreshed?.Invoke();
                }
            }
        }
    }
}
