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
    public partial class UC_Items : UserControl
    {
        UC_ItemMainInfo UC_ItemMainInfo = new UC_ItemMainInfo();
        UC_StoresItemInfo UC_StoresItemInfo = new UC_StoresItemInfo() { Dock = DockStyle.Fill};
        UC_HandleItems UC_HandleItems = new UC_HandleItems() { Dock = DockStyle.Fill };
        List<UC_ItemInfoCard> CardsList = new List<UC_ItemInfoCard>();
        int itemsNumPerTime = 10;
        int iter = 0;
        public UC_Items()
        {
            InitializeComponent();
            UC_ItemMainInfo.DataRefreshed += UC_ItemMainInfo_DataRefreshed;
            UC_ItemInfoCard.DataRefreshed += UC_ItemMainInfo_DataRefreshed;
            cbxItemState.Hide();
            dtExpDate.Hide();
            //this.Size = new Size(1275, 740);
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                UC_ItemMainInfo.DataRefreshed -= UC_ItemMainInfo_DataRefreshed;
                UC_ItemInfoCard.DataRefreshed -= UC_ItemMainInfo_DataRefreshed;

                base.Dispose();
            };

        }

        private void UC_ItemMainInfo_DataRefreshed()
        {
            panel3.Show();
            iter = 0;
            //panelItemsCards.Controls.Clear();
            //GetAllItems();
        }

        

        private void UC_Items_Load(object sender, EventArgs e)
        {
            ShowUC_MainInfo();
            GetAllItems();
        }
        private void GetAllItems(string code = "")
        {
            List<Item> items = ItemTbl.GetItems(code);
            if (items.Count == 0)
            {
                panelItemsCards.Controls.Clear();
                return;
            }
            CardsList.Clear();
            foreach (var item in items)
            {
                CardsList.Add(new UC_ItemInfoCard(item));
            }
            panelItemsCards.Controls.Clear();
            ShowAllItems();
        }

        private void ShowAllItems()
        {
            int i = 0;
           while( i  <= itemsNumPerTime)
            {
                if (iter == CardsList.Count)
                {
                    panel3.Hide();
                    break;
                }
                panelItemsCards.Controls.Add(CardsList[iter]);
                iter++;
                i++;
            }
        }

        private void btnShowUCMainInfo_Click(object sender, EventArgs e)
        {
            ShowUC_MainInfo();
        }

        private void ShowUC_MainInfo()
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_ItemMainInfo);
        }

        private void btnShowUCStoreswzItem_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_StoresItemInfo);
        }

        private void txtItemSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                panel3.Show();
                iter = 0;
                GetAllItems(txtItemSearch.Text.Trim());
            }
        }

        private void txtItemSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtItemSearch.Text.Trim() == "")
            {
                panel3.Show();
                iter = 0;
                GetAllItems();
            }
            else
                panelItemsCards.Controls.Clear();
        }

        private void btnHandleItems_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_HandleItems);
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            ShowAllItems();
        }

        private void btnRefreshItems_Click(object sender, EventArgs e)
        {
            panel3.Show();
            iter = 0;
            panelItemsCards.Controls.Clear();
            GetAllItems();
        }

        private void cbxItemState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxItemState.SelectedIndex == 0)
            {
                panel3.Show();
                iter = 0;
                panelItemsCards.Controls.Clear();
                ShowAllItems();
            }
            else if (cbxItemState.SelectedIndex <= 2)
            {
                panel3.Hide();
                panelItemsCards.Controls.Clear();
                var items = CardsList.FindAll(x => x.ItemState == cbxItemState.Text.ToItemState());
                foreach (var item in items)
                {
                    panelItemsCards.Controls.Add(item);
                }
            }
            else
            {
                panel3.Hide();
                panelItemsCards.Controls.Clear();
                var items = CardsList.FindAll(x => x.ItemStoreState == cbxItemState.Text.FromString());
                foreach (var item in items)
                {
                    panelItemsCards.Controls.Add(item);
                }
            }
            if (cbxItemState.SelectedIndex == 3)
                dtExpDate.Show();
            else dtExpDate.Hide();
        }

        private void btnShowFilter_Click(object sender, EventArgs e)
        {
            if (cbxItemState.Visible)
            {
                cbxItemState.Hide();
            }
            else
            {
                cbxItemState.Show();
            }
        }

        private void dtExpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtExpDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelItemsCards.Controls.Clear();
            var items = CardsList.FindAll(x => x.CurrentItem.IsExpiring == "yes");
            items = CardsList.FindAll(x => x.ChildsItms.Any(g => DateTime.Parse(g.ExpirationDate).Month == dtExpDate.SelectedIndex + 1));
            foreach (var item in items)
            {
                panelItemsCards.Controls.Add(item);
            }
        }
    }
}
