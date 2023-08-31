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
    public partial class WindowTransferItem : Form
    {
        ItemInStore CurrentItem;
        public delegate void ClickBtnSave();
        public static event ClickBtnSave BtnSaveClicked;
        public delegate void RefershData();
        public static event RefershData DataRefreshed;
        public WindowTransferItem(ItemInStore itemIn)
        {
            CurrentItem = itemIn;
            InitializeComponent();
            if (itemIn.Store.Id == 0)
                lblTransferType.Text = $"فتح {itemIn.BigUnit}";
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

        private void btnSaveTransfer_Click(object sender, EventArgs e)
        {
            bool donedouble = double.TryParse(txtQuantity.Text.Trim(), out double quantity);
            if (!donedouble)
            {
                new CustomeMessageDialogue("أدخل كمية صحيحة");
                txtQuantity.SelectAll();
                txtQuantity.Focus();
                return;
            }
            if(quantity > CurrentItem.Quantity)
            {
                new CustomeMessageDialogue("الكمية الحالية لا تكفى");
                txtQuantity.SelectAll();
                txtQuantity.Focus();
                return;
            }
            if (quantity == 0)
            {
                new CustomeMessageDialogue("الكمية يجب ان تكون اكبر من صفر");
                txtQuantity.SelectAll();
                txtQuantity.Focus();
                return;
            }
            
            if (CurrentItem.Store.Id == 0)
            {
                int id = ShopTbl.CheckItemExist(CurrentItem);
                CurrentItem.Unit = CurrentItem.SmallUnit;
                if (CurrentItem.Quantity == 1)
                {
                    CurrentItem.Quantity = CurrentItem.SmallNumInBig;
                    CurrentItem.Price = CurrentItem.SmallUnitSellPrice;
                    if(id == 0)
                    {
                        ShopTbl.EditItemInShop(CurrentItem);
                    }
                    else
                    {
                        ShopTbl.DeleteItemInShop(CurrentItem.IdInShop.ToString());
                        CurrentItem.IdInShop = id;
                        ShopTbl.EditQuantity(CurrentItem);
                    }
                }
                else if (CurrentItem.Quantity > 1)
                {
                    
                    if (id == 0)
                    {
                        
                        if (quantity == CurrentItem.Quantity)
                        {
                            CurrentItem.Quantity = CurrentItem.SmallNumInBig * quantity;
                            CurrentItem.Price = CurrentItem.SmallUnitSellPrice;
                            ShopTbl.EditItemInShop(CurrentItem);
                        }
                        else
                        {
                            CurrentItem.Quantity =  quantity *-1;
                            ShopTbl.EditQuantity(CurrentItem);
                            CurrentItem.Quantity = CurrentItem.SmallNumInBig * quantity;
                            ShopTbl.SaveItemInShop(CurrentItem);
                        }
                    }
                    else
                    {
                        if (quantity == CurrentItem.Quantity)
                        {
                            ShopTbl.DeleteItemInShop(CurrentItem.IdInShop.ToString());
                            CurrentItem.Quantity = CurrentItem.SmallNumInBig * quantity;
                            CurrentItem.IdInShop = id;
                            ShopTbl.EditQuantity(CurrentItem);
                        }
                        else
                        {
                            CurrentItem.Quantity = quantity * -1;
                            ShopTbl.EditQuantity(CurrentItem);
                            CurrentItem.Quantity = CurrentItem.SmallNumInBig * quantity;
                            CurrentItem.IdInShop = id;
                            ShopTbl.EditQuantity(CurrentItem);
                        }
                    }
                }
            }
            else
            {
                if (StoreInfoTbl.CheckItemExist(CurrentItem.Id, CurrentItem.ExpirationDate, CurrentItem.Code))
                {
                    CurrentItem.Quantity -= quantity;
                    StoreInfoTbl.EditItemInStore(CurrentItem);
                    CurrentItem.Store.Id = 0;
                    CurrentItem.Id = StoreInfoTbl.FindItemIdWithDate(CurrentItem.ExpirationDate, CurrentItem.Code);
                    CurrentItem.Quantity = quantity;
                    int id = ShopTbl.CheckItemExist(CurrentItem, bigUnit: true);
                    if (id == 0)
                    {
                        ShopTbl.SaveItemInShop(CurrentItem);
                    }
                    else
                    {
                        CurrentItem.IdInShop = id;
                        ShopTbl.EditQuantity(CurrentItem);
                    }
                }

                else
                {
                    CurrentItem.Quantity -= quantity;
                    StoreInfoTbl.EditItemInStore(CurrentItem);
                    CurrentItem.Store.Id= 0;
                    CurrentItem.Quantity = 0;
                    StoreInfoTbl.SaveItemInStore(CurrentItem);
                    CurrentItem.Quantity = quantity;
                    CurrentItem.Id = StoreInfoTbl.FindItemIdWithCode(CurrentItem.Code);
                    ShopTbl.SaveItemInShop(CurrentItem);
                }
            }
            BtnSaveClicked?.Invoke();
            this.Close();
        }
    }
}
