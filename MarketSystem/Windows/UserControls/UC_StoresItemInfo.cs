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
    public partial class UC_StoresItemInfo : UserControl
    {
        List<UC_StoreItemInInfoCard> CardsList = new List<UC_StoreItemInInfoCard>();
        Item CurrentItem;
        public UC_StoresItemInfo()
        {
            InitializeComponent();
            UC_ItemInfoCard.ItemCardClicked += UC_ItemInfoCard_ItemCardClicked;
            WindowEditStoreItemInfo.BtnSaveClicked += WindowEditStoreItemInfo_BtnSaveClicked;
            UC_StoreItemInInfoCard.DataRefreshed += UC_StoreItemInInfoCard_DataRefreshed;
            WindowTransferItem.BtnSaveClicked += WindowTransferItem_BtnSaveClicked;
        }

        private void WindowTransferItem_BtnSaveClicked()
        {
            UC_ItemInfoCard_ItemCardClicked(CurrentItem);
        }

        private void UC_StoreItemInInfoCard_DataRefreshed()
        {
            UC_ItemInfoCard_ItemCardClicked(CurrentItem);
        }

        private void WindowEditStoreItemInfo_BtnSaveClicked()
        {
            UC_ItemInfoCard_ItemCardClicked(CurrentItem);
        }

        private void UC_ItemInfoCard_ItemCardClicked(Item item)
        {
            CurrentItem = item;
            CardsList.Clear();
            var itemsInStores = StoreInfoTbl.GetItemsInStore(it: CurrentItem);
            var ItemsInShop = StoreInfoTbl.GetItemsFromShop(it: CurrentItem);
            itemsInStores = itemsInStores.FindAll(x => x.Quantity > 0);
            ItemsInShop = ItemsInShop.FindAll(x => x.Quantity > 0);
            if (itemsInStores.Count == 0 && ItemsInShop.Count == 0)
            {
                panelItemsContainer.Controls.Clear();
                txtItemsTotal.Text ="";
                txtTotalGood.Text = "";
                txtTotalIsexpiring.Text = "";
                txtTotalExpied.Text = "";
                txtTotalInStores.Text = "";
                txtGoodTotalInStores.Text = "";
                txtIsExpTotalInStores.Text = "";
                txtExpTotalInStores.Text = "";
                return;
            }
                

            txtItemsTotal.Text =
                ((from i in ItemsInShop where i.Store.Name == "المحل" && i.Unit == i.SmallUnit select i.Quantity).Sum() +
                (from i in ItemsInShop where i.Store.Name == "المحل" && i.Unit == i.BigUnit select i.Quantity * i.SmallNumInBig).Sum()).ToString();
            txtTotalGood.Text = ItemsInShop.Count(x => CheckItemState(x, ItemStoreState.Good)).ToString();
            txtTotalIsexpiring.Text = ItemsInShop.Count(x => CheckItemState(x, ItemStoreState.IsExpiring)).ToString();
            txtTotalExpied.Text = ItemsInShop.Count(x => CheckItemState(x, ItemStoreState.Expired)).ToString();
            txtTotalInStores.Text = (from i in itemsInStores where i.Store.Name != "المحل" select i.Quantity).Sum().ToString();
            txtGoodTotalInStores.Text = itemsInStores.Count(x => CheckItemState(x, ItemStoreState.Good, true)).ToString();
            txtIsExpTotalInStores.Text = itemsInStores.Count(x => CheckItemState(x, ItemStoreState.IsExpiring, true)).ToString();
            txtExpTotalInStores.Text = itemsInStores.Count(x => CheckItemState(x, ItemStoreState.Expired, true)).ToString();

            foreach (var i in ItemsInShop)
            {
                CardsList.Add(new UC_StoreItemInInfoCard(i));
            }
            foreach (var i in itemsInStores)
            {
                CardsList.Add(new UC_StoreItemInInfoCard(i));
            }
            GetInfoOfCurrentItem();

        }
        private bool CheckItemState(ItemInStore itemInStore, ItemStoreState state, bool s = false)
        {
            if (CheckItemStore(itemInStore) ^ s)
                if (itemInStore.ItemStoreState == state && itemInStore.Quantity != 0)
                    return true;
                else 
                    return false;
            else
                return false;
        }
        private bool CheckItemStore(ItemInStore itemInStore)
        {
            if (itemInStore.Store.Name == "المحل")
                return true;
            else
                return false;
        }

        private void GetInfoOfCurrentItem()
        {
            panelItemsContainer.Controls.Clear();
            foreach (var item in CardsList)
            {
                panelItemsContainer.Controls.Add(item);
            }
        }

        private void UC_StoresItemInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
