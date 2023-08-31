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
using BL;
using Guna.UI2.WinForms;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_ItemMainInfo : UserControl
    {
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        Dictionary<string, string> dicCategories;
        Dictionary<string, string> dictStores;
        Item CurrentItem;
        UC_ItemInfoCard Currentcard;
        bool EditFlag = false;
        public UC_ItemMainInfo()
        {
            InitializeComponent();
            //panelExpirationInfo.Hide();
            //panelExpirationAlarm.Hide();
            txtMenuName.Hide();
            dtItemExp.MinDate = DateTime.Now;
            UC_ItemInfoCard.ItemCardClicked += UC_ItemInfoCard_ItemCardClicked;
            UC_ItemInfoCard.CardClicked += UC_ItemInfoCard_CardClicked;
            UC_ItemInfoCard.BtnEditClicked += UC_ItemInfoCard_BtnEditClicked;
            
        }

        private void UC_ItemInfoCard_BtnEditClicked(Item item, UC_ItemInfoCard ItemCard)
        {
            CurrentItem = item;
            EditFlag = true;
            SetCurrentCard(ItemCard);
        }

        private void UC_ItemInfoCard_CardClicked(UC_ItemInfoCard ItemCard)
        {
            SetCurrentCard(ItemCard);
        }

        private void SetCurrentCard(UC_ItemInfoCard ItemCard)
        {
            if (Currentcard is null)
            {
                Currentcard = ItemCard;
                Currentcard.card.FillColor = Color.PaleGoldenrod;
            }
            else
            {
                Currentcard.card.FillColor = Color.White;
                Currentcard = ItemCard;
                Currentcard.card.FillColor = Color.PaleGoldenrod;
            }
        }

        private void UC_ItemInfoCard_ItemCardClicked(Item item)
        {
            CurrentItem = item;
            ShowItemInfo();
        }

        private void ShowItemInfo()
        {
            txtItemCode.Text = CurrentItem.Code;
            txtItemName.Text = CurrentItem.Name;
            txtSmallUnit.Text = CurrentItem.SmallUnit;
            txtSmallBuyPrice.Text = CurrentItem.SmallUnitBuyPrice.ToString();
            txtSmallSellPrice.Text = CurrentItem.SmallUnitSellPrice.ToString();
            txtBigUnit.Text = CurrentItem.BigUnit;
            txtBigBuyPrice.Text = CurrentItem.BigUnitBuyPrice.ToString();
            txtBigSellPrice.Text = CurrentItem.BigUnitSellPrice.ToString();
            txtSmallProfit.Text = (CurrentItem.SmallUnitSellPrice - CurrentItem.SmallUnitBuyPrice).ToString();
            txtBigProfit.Text = (CurrentItem.BigUnitSellPrice - CurrentItem.BigUnitBuyPrice).ToString();
            txtSmallNumInBig.Text = CurrentItem.SmallNumInBig.ToString();
            cbxItemMenu.SelectedValue = CurrentItem.Menu.ToString();
            txtLimitNeed.Text = CurrentItem.LimitNeed.ToString();
            tglAlarmIndeed.IsOn = CurrentItem.LimitAlarm == "yes" ? true : false;
            tglIsExpiring.IsOn = CurrentItem.IsExpiring == "yes" ? true : false;
            tglAlarmExpiration.IsOn = CurrentItem.ExpDurationAlarm > 0? true : false;
            txtAlarmDuration.Text = CurrentItem.ExpDurationAlarm.ToString();
            cbxDurationType.SelectedIndex = CurrentItem.ExpDurationAlarm % 30 == 0 ? 1 : 0;
        }

        private void tglIsExpiring_Click(object sender, EventArgs e)
        {
            if (!tglIsExpiring.IsOn)
                trPanelExpiration.HideSync(panelExpirationInfo);
            else
                trPanelExpiration.ShowSync(panelExpirationInfo);
        }

        private void tglAlarmExpiration_Click(object sender, EventArgs e)
        {
            if (!tglAlarmExpiration.IsOn)
                trPanelExpiration.HideSync(panelExpirationAlarm);
            else
                trPanelExpiration.ShowSync(panelExpirationAlarm);
        }

        private void btnShowPanelBillInfo_Click(object sender, EventArgs e)
        {
            if (txtMenuName.Visible)
                trPanelExpiration.HideSync(txtMenuName);
            else
                trPanelExpiration.ShowSync(txtMenuName);
        }

        private void UC_ItemMainInfo_Load(object sender, EventArgs e)
        {
            FillCbxMenu();
            FillCbxStores();
            txtItemCode.Focus();
        }


        private void FillCbxMenu()
        {
            dicCategories = new Dictionary<string, string>();
            var tbl = MenuTbl.GetAllMenu();
            if (tbl.Count == 0)
                return;
            foreach (var item in tbl)
            {
                dicCategories.Add(item.ID.ToString(), item.Name.ToString());
            }
            cbxItemMenu.DataSource = new BindingSource(dicCategories, null);
            cbxItemMenu.DisplayMember = "Value";
            cbxItemMenu.ValueMember = "Key";
            cbxItemMenu.SelectedIndex = 0;
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
            cbxStores.SelectedIndex = 0;
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentItem is null)
                {
                    if (!MyTools.checkItemValidData(this, txtItemQuantity, txtMenuName, txtSmallUnit, txtBigUnit))
                        return;
                    SaveNewItem();
                }
                else
                {
                    if (!EditFlag)
                    {
                        new CustomeMessageDialogue("اضغط على زر تعديل الصنف قبل حفظ البيانات للتأكيد");
                        return;
                    }
                    if (!MyTools.checkItemValidData(this, txtItemQuantity, txtMenuName, txtSmallUnit, txtBigUnit))
                        return;
                    EditCurrentItem();
                }
                DataRefreshed?.Invoke();
                ClearInfo();
                txtItemCode.Focus();
                txtItemCode.SelectAll();
            }
            catch
            {
                new CustomeMessageDialogue("تأكد من ان كود المنتج صحيح او غير مكرر");
            }

        }

        private void EditCurrentItem()
        {
           
            Item item = new Item()
            {
                Code = CurrentItem.Code,
                Name = txtItemName.Text.Trim(),
                Menu = int.Parse(cbxItemMenu.SelectedValue.ToString()),
                SmallUnit = CurrentItem.SmallUnit,
                SmallUnitBuyPrice = double.Parse(txtSmallBuyPrice.Text.Trim()),
                SmallUnitSellPrice = double.Parse(txtSmallSellPrice.Text.Trim()),
                BigUnit = CurrentItem.BigUnit,
                BigUnitBuyPrice = double.Parse(txtBigBuyPrice.Text.Trim()),
                BigUnitSellPrice = double.Parse(txtBigSellPrice.Text.Trim()),
                SmallNumInBig = double.Parse(txtSmallNumInBig.Text.Trim()),
                LimitNeed = int.Parse(txtLimitNeed.Text.Trim()),
                LimitAlarm = tglAlarmIndeed.IsOn ? "yes" : "no",
                ExpDurationAlarm = cbxDurationType.SelectedIndex == 0 ? int.Parse(txtAlarmDuration.Text.Trim()) : int.Parse(txtAlarmDuration.Text.Trim()) * 30
            };
            ItemTbl.EditItem(item);
            if(item.SmallUnitBuyPrice != CurrentItem.SmallUnitBuyPrice
                || item.SmallUnitSellPrice != CurrentItem.SmallUnitSellPrice
                || item.BigUnitBuyPrice != CurrentItem.BigUnitBuyPrice
                || item.BigUnitSellPrice != CurrentItem.BigUnitSellPrice
                )
            {
                using (var msg = new CustomeMessageDialogue("لقد قمت بتعديل اسعار الصنف \n" +
                    "تعديل اسعار الصنف الموجود حاليا؟", MessageType.Warning))
                {
                    var res = msg.ShowDialog();
                    if(res == DialogResult.Yes)
                    {
                        StoreInfoTbl.EditItemInStorePrices(item);
                    }
                }
            }
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Edit,
                Description = item.Code + ": " + item.Name
            });
        }

        private void GenerateId()
        {
            string code;
            while (true)
            {
                 code = GlobalFunc.RandomCode(10);
                if (!ItemTbl.FindItemCode(code))
                {
                    txtItemCode.Text = code;
                    return;
                }
            }
        }

        private void SaveNewItem()
        {

            ItemInStore item = new ItemInStore()
            {
                Code = txtItemCode.Text.Trim(),
                Name = txtItemName.Text.Trim(),
                Menu = int.Parse(cbxItemMenu.SelectedValue.ToString().Trim()),
                SmallUnit ="صغري",
                SmallUnitBuyPrice = double.Parse(txtSmallBuyPrice.Text.Trim()),
                SmallUnitSellPrice = double.Parse(txtSmallSellPrice.Text.Trim()),
                BigUnit ="كبري",
                BigUnitBuyPrice = double.Parse(txtBigBuyPrice.Text.Trim()),
                BigUnitSellPrice = double.Parse(txtBigSellPrice.Text.Trim()),
                SmallNumInBig = double.Parse(txtSmallNumInBig.Text.Trim()),
                LimitNeed = int.Parse(txtLimitNeed.Text.Trim()),
                LimitAlarm = tglAlarmIndeed.IsOn ? "yes" : "no",
                IsExpiring = tglIsExpiring.IsOn ? "yes" : "no",
                ExpDurationAlarm = cbxDurationType.SelectedIndex == 0 ? int.Parse(txtAlarmDuration.Text.Trim()) : int.Parse(txtAlarmDuration.Text.Trim()) * 30
            };
            ItemInStore itemInStore = item;
            if (txtSmallUnit.Text.Trim() != "")
                itemInStore.SmallUnit = txtSmallUnit.Text.Trim();
            if (txtBigUnit.Text.Trim() != "")
                itemInStore.BigUnit = txtBigUnit.Text.Trim();
            //itemInStore.Store = new Store() { Id = int.Parse(dictStores.First(x => x.Value == cbxStores.Text).Key) };
            itemInStore.Store = new Store() { Id =0 };
            itemInStore.Bill = "1";
            itemInStore.Unit = item.SmallUnit;
            itemInStore.Price = item.SmallUnitSellPrice;

            if (item.IsExpiring == "yes")
                itemInStore.ExpirationDate = dtItemExp.Value.ToString("yyyy-MM-dd");
            itemInStore.Quantity = 0;
            itemInStore.SmallUnitBuyPrice = item.SmallUnitBuyPrice;
            itemInStore.SmallUnitSellPrice = item.SmallUnitSellPrice;
            itemInStore.BigUnitBuyPrice = item.BigUnitBuyPrice;
            itemInStore.BigUnitSellPrice = item.BigUnitSellPrice;
            itemInStore.SmallProfit = item.SmallUnitSellPrice - item.SmallUnitBuyPrice;
            itemInStore.BigProfit = item.BigUnitSellPrice - item.BigUnitBuyPrice;

            ItemTbl.SaveItem(item);
            StoreInfoTbl.SaveItemInStore(itemInStore);
            if(txtItemQuantity.Text.Trim() != "")
            {
                bool vaildQuantity = double.TryParse(txtItemQuantity.Text.Trim(), out double quantity);
                itemInStore.Quantity = vaildQuantity ? quantity: itemInStore.SmallNumInBig;
                itemInStore.Id = StoreInfoTbl.FindItemIdWithCode(itemInStore.Code);
                ShopTbl.SaveItemInShop(itemInStore);
            }
            
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Add,
                Description = item.Code + ": " + item.Name
            });
        }


        private void txtMenuName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if(txtMenuName.Text.Trim() == "")
                {
                    return;
                }
                MenuTbl.SaveMenu( new Category() { Name = txtMenuName.Text.Trim() });
                FillCbxMenu();
                txtMenuName.Text = "";
            }
        }

        private void bntGenerateCode_Click(object sender, EventArgs e)
        {
            GenerateId();
        }

        private void txtSmallBuyPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSmallProfit();
        }

        private void txtSmallSellPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateSmallProfit();
        }

        private void CalculateSmallProfit()
        {
            try
            {
                if(txtSmallSellPrice.Text.Trim() != "" && txtSmallBuyPrice.Text.Trim() != "")
                txtSmallProfit.Text = (double.Parse(txtSmallSellPrice.Text.Trim()) - double.Parse(txtSmallBuyPrice.Text.Trim())).ToString();

            }
            catch (Exception)
            {
                new CustomeMessageDialogue("أدخل بيانات صحيحة فى كل من سعر البيع و الشراء");
            }
        }

        private void txtBigBuyPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateBigProfit();
        }

        private void txtBigSellPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateBigProfit();
        }
        private void CalculateBigProfit()
        {
            try
            {
                if (txtBigSellPrice.Text.Trim() != "" && txtBigBuyPrice.Text.Trim() != "")
                    txtBigProfit.Text = (double.Parse(txtBigSellPrice.Text.Trim()) - double.Parse(txtBigBuyPrice.Text.Trim())).ToString();
            }
            catch (Exception)
            {
                new CustomeMessageDialogue("أدخل بيانات صحيحة فى كل من سعر البيع و الشراء");
            }
                
        }

        private void txtAlarmDuration_Leave(object sender, EventArgs e)
        {
            if (int.Parse(txtAlarmDuration.Text.Trim()) % 30 == 0)
            {
                txtAlarmDuration.Text = (int.Parse(txtAlarmDuration.Text.Trim()) / 30).ToString();
                cbxDurationType.SelectedIndex = 1;
            }
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            
            ClearInfo();

        }

        private void ClearInfo()
        {
            CurrentItem = null;
            EditFlag = false;
            if (Currentcard is null)
                return;
            Currentcard.card.FillColor = Color.White;
            Currentcard = null;
        }

        private void btnClearControls_DoubleClick(object sender, EventArgs e)
        {
            MyTools.ClearUCWidget(this);
        }
    }
}
