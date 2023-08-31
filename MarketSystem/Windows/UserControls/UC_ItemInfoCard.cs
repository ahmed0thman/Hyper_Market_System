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
    public partial class UC_ItemInfoCard : UserControl
    {
        public delegate void ClickItemCard(Item item);
        public static event ClickItemCard ItemCardClicked;
        public delegate void CLickBtnEdit(Item item, UC_ItemInfoCard ItemCard);
        public static event CLickBtnEdit BtnEditClicked;
        public delegate void ClickCard(UC_ItemInfoCard ItemCard);
        public static event ClickCard CardClicked;
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        public Item CurrentItem;
        public ItemState ItemState;
        public ItemStoreState ItemStoreState;
        public List<ItemInStore> ChildsItms = new List<ItemInStore>();
        public UC_ItemInfoCard(Item item)
        {
            InitializeComponent();
            CurrentItem = item;
            lblItemName.Text = item.Name;
            ChildsItms = StoreInfoTbl.GetItemsFromShop(it: item).FindAll(x => x.IsExpiring == "yes" && DateTime.Parse(x.ExpirationDate).Year == DateTime.Today.Year);
            if(ChildsItms.Count == 0)
            {
                ItemState = ItemState.Empty;
                picItemState.BackColor = Color.FromArgb(154, 89, 179);
                return;
            }
            ChildsItms = ChildsItms.FindAll(g => g.Quantity > 0);
            if (ChildsItms.Count == 0)
            {
                ItemState = ItemState.Empty;
                picItemState.BackColor = Color.FromArgb(154, 89, 179);
                return;
            }
            var itm = ChildsItms.OrderBy(x => DateTime.Parse(x.ExpirationDate)).ToList()[0];
            ItemState = itm.ItemState;
            ItemStoreState = itm.ItemStoreState;
            HandleItemState(itm);
        }

        private void HandleItemState(ItemInStore itemInStore)
        {
            switch (itemInStore.ItemState)
            {
                case ItemState.Available:
                    picItemState.BackColor = Color.FromArgb(126, 211, 33);
                    break;
                case ItemState.Indeed:
                    picItemState.BackColor = Color.FromArgb(0, 183, 250);
                    break;
                case ItemState.Empty:
                    picItemState.BackColor = Color.FromArgb(154, 89, 179);
                    break;
                default:
                    break;
            }
            switch (itemInStore.ItemStoreState)
            {
                case ItemStoreState.Expired:
                    picItemState.BackColor = Color.Red;
                    break;
                case ItemStoreState.IsExpiring:
                    picItemState.BackColor = Color.Orange;
                    break;
                default:
                    break;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            using (CustomeMessageDialogue MsgBox = new CustomeMessageDialogue("اذا قمت بالضغط على نعم سوف تقوم بحذف هذا والمنتج بشكل نهائى \n " +
                "بمافى ذلك الفواتير الملحقة و الارباح", MessageType.Warning))
            {
                DialogResult result = MsgBox.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    ItemTbl.DeleteItem(CurrentItem);
                    
                }
            }
            DataRefreshed?.Invoke();
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {
            ItemCardClicked?.Invoke(CurrentItem);
            CardClicked?.Invoke(this);
        }

        private void guna2ShadowPanel2_Click(object sender, EventArgs e)
        {
            ItemCardClicked?.Invoke(CurrentItem);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            BtnEditClicked?.Invoke(CurrentItem, this);
        }
    }
}
