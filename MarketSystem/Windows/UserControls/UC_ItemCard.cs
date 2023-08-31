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

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_ItemCard : UserControl
    {
        public delegate void ClickItemCard(ItemInStore item);
        public event ClickItemCard CardItemClicked;
        ItemInStore ItemInStore;
        public UC_ItemCard(ItemInStore itemInStore)
        {
            //itemInStore.ItemState = (ItemState)(int.Parse(RandomCode()));
            //itemInStore.ItemStoreState = (ItemStoreState)(int.Parse(RandomCode()));
            InitializeComponent();
            ItemInStore = itemInStore;
            lblItemName.Text = itemInStore.Name;
            lblItemPrice.Text = string.Format("{0:c}", itemInStore.Price);
            HandleItemState(itemInStore);
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

        private void picItemState_Click(object sender, EventArgs e)
        {
            CardItemClicked.Invoke(ItemInStore);
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            CardItemClicked.Invoke(ItemInStore);
        }

        private void lblItemPrice_Click(object sender, EventArgs e)
        {
            CardItemClicked.Invoke(ItemInStore);
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {
            CardItemClicked.Invoke(ItemInStore);
        }
    }
}
