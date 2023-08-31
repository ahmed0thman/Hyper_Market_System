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
    public partial class UC_HandleItems : UserControl
    {
        List<ItemInStore> OldItems = new List<ItemInStore>();
        List<ItemInStore> NewItems = new List<ItemInStore>();
        List<Item> AllItems = new List<Item>();
        Dictionary<string, string> dictStores;
        AutoCompleteStringCollection ItemsCodeCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection UnitCollection = new AutoCompleteStringCollection();
        DataTable tblCureentItems = new DataTable("tblCurrentItems");
        bool WindowLoaded = false;
        DateTimePicker dtp = new DateTimePicker();
        Rectangle rectangle;
        DataGridViewCell CurrentCell;


        public UC_HandleItems()
        {
            InitializeComponent();
            
            
            
            tblCureentItems.Columns.Add("Code");
            tblCureentItems.Columns.Add("Id");
            tblCureentItems.Columns.Add("Name");
            tblCureentItems.Columns.Add("Unit");
            tblCureentItems.Columns.Add("Quantity");
            tblCureentItems.Columns.Add("ExpDate");
            FillCbxStores();

            UC_ItemInfoCard.DataRefreshed += UC_ItemInfoCard_DataRefreshed;
            UC_ItemMainInfo.DataRefreshed += UC_ItemMainInfo_DataRefreshed;
        }

        private void UC_ItemMainInfo_DataRefreshed()
        {
            RefreshWindowInfo();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            //if (e.KeyData != Keys.Enter)
            //    return;

            dgvItems.CurrentCell.Value = dtp.Value.ToString("d");
            dgvItems_CellEndEdit(dgvItems.CurrentCell, new DataGridViewCellEventArgs(dgvItems.CurrentCell.ColumnIndex, dgvItems.CurrentCell.RowIndex));

        }

        private void UC_ItemInfoCard_DataRefreshed()
        {
            RefreshWindowInfo();
        }

        private void RefreshWindowInfo()
        {
            OldItems.Clear();
            NewItems.Clear();
            WindowLoaded = false;
            GetOldItems();
            HandleAutoCompleteCollections();
            FillDgvWithItems();
            WindowLoaded = true;
        }

        private void UC_HandleItems_Load(object sender, EventArgs e)
        {
            GetOldItems();
            HandleAutoCompleteCollections();
            WindowLoaded = true;
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


        private void HandleAutoCompleteCollections()
        {
            AllItems = ItemTbl.GetItems();
            if (AllItems.Count == 0)
                return;

            foreach (var item in AllItems)
            {
                ItemsCodeCollection.Add(item.Code);
            }
        }

        private void GetOldItems()
        {
            colId.Visible = false;
            OldItems.Clear();
            NewItems.Clear();
            if (cbxStores.SelectedIndex == 0)
            {
                OldItems = StoreInfoTbl.GetItemsFromShop().FindAll(x => x.Quantity > 0);
                FillDgvWithItems();
                colUnit.Visible = true;
            }
            else
            {
                OldItems = StoreInfoTbl.GetItemsInStore(st: cbxStores.SelectedValue.ToString()).FindAll(x => x.Quantity > 0);
                FillDgvWithItems();
                colUnit.Visible = false;
            }
            if (OldItems.Count == 0)
                return;
            dgvItems.DataSource = tblCureentItems;
            
        }

        private void FillDgvWithItems()
        {
            tblCureentItems.Rows.Clear();
            foreach (var item in OldItems)
            {
                DataRow temp = tblCureentItems.NewRow();
                temp["Code"] = item.Code;
                temp["Id"] = item.Id;
                temp["Name"] = item.Name;
                temp["Unit"] = item.Unit;
                temp["Quantity"] = item.Quantity;
                temp["ExpDate"] = item.ExpirationDate;
                tblCureentItems.Rows.Add(temp);
            }
            dgvItems.DataSource = tblCureentItems;
            colId.Visible = false;
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentCell = dgvItems.CurrentCell;
                if (dgvItems.Rows[e.RowIndex] is null
                    || dgvItems.Rows[e.RowIndex].Cells["colCode"] is null
                    || dgvItems.Rows[e.RowIndex].Cells["colCode"].Value is null
                    )
                {

                    CurrentCell = null;
                    return;
                }
                string itemId = dgvItems.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
                //bool done = int.TryParse(dgvItems.Rows[e.RowIndex].Cells["colCode"].Value.ToString(), out int itemId);
                bool done = itemId.ToList().TrueForAll(x => Char.IsDigit(x));
                if (!done)
                {
                    new CustomeMessageDialogue($"تأكد من ادخل كود صنف سليم");
                    CurrentCell.Value = "";
                    CurrentCell = null;
                    return;
                }
                if (!AllItems.Any(x => x.Code == itemId.ToString()))
                {
                    new CustomeMessageDialogue("كود الصنف غير صحيح");
                    CurrentCell.Value = "";
                    CurrentCell = null;
                    return;
                }
                var item = AllItems.Find(x => x.Code == itemId.ToString());
                if (e.RowIndex < OldItems.Count)
                {
                    //MessageBox.Show("fuck1");
                    InsertNewItems(e, item, false, true);

                }
                else if (e.RowIndex >= OldItems.Count && e.RowIndex < (OldItems.Count + NewItems.Count))
                {
                    //MessageBox.Show("fuck2");
                    InsertNewItems(e, item, false);

                }
                else if (e.RowIndex >= (OldItems.Count + NewItems.Count))
                {
                    //MessageBox.Show("fuck3");
                    InsertNewItems(e, item);

                }

                dgvItems.Columns["colCode"].ReadOnly = true;
                //dtp.Value = DateTime.Now;
            }
            catch (Exception)
            {

            }
            

        }

        private void InsertNewItems(DataGridViewCellEventArgs e, Item item, bool add = true, bool editOld = false)
        {
            
            ItemInStore itemInStore;
            if (add)
            {
                itemInStore = item.ToItemInStore();

                itemInStore.Id = int.Parse(GenerateId());
                dgvItems.Rows[e.RowIndex].Cells["colName"].Value = item.Name;
                dgvItems.Rows[e.RowIndex].Cells["colUnit"].Value = item.SmallUnit;
                if (cbxStores.SelectedIndex > 0)
                    dgvItems.Rows[e.RowIndex].Cells["colUnit"].Value = item.BigUnit;
                dgvItems.Rows[e.RowIndex].Cells["colId"].Value = itemInStore.Id.ToString();

            }

            else
            {
                if (!editOld)
                    itemInStore = NewItems.Find(x => x.Id == int.Parse(dgvItems.Rows[e.RowIndex].Cells["colId"].Value.ToString()));
                else
                    itemInStore = OldItems.Find(x => x.Id == int.Parse(dgvItems.Rows[e.RowIndex].Cells["colId"].Value.ToString()));
            }

            Store store = new Store( int.Parse(cbxStores.SelectedValue.ToString()));
            itemInStore.Store = store;
            itemInStore.Bill = "0";
            if (dgvItems.Rows[e.RowIndex].Cells["colUnit"].Value.ToString() == item.SmallUnit)
            {
                itemInStore.Unit = item.SmallUnit;
                itemInStore.Price = item.SmallUnitSellPrice;
            }
            else
            {
                itemInStore.Unit = item.BigUnit;
                itemInStore.Price = item.BigUnitSellPrice;
            }
            
            if (store.Id !=0)
            {
                itemInStore.Unit = item.BigUnit;
                itemInStore.Price = item.BigUnitSellPrice;
            }

            itemInStore.ExpirationDate = dgvItems.Rows[e.RowIndex].Cells["colExpDate"].Value.ToString();
            bool donedouble = double.TryParse(dgvItems.Rows[e.RowIndex].Cells["colQuantity"].Value.ToString().Trim(), out double quantity);
            if (donedouble)
                itemInStore.Quantity = quantity;
            itemInStore.SmallUnitBuyPrice = item.SmallUnitBuyPrice;
            itemInStore.SmallUnitSellPrice = item.SmallUnitSellPrice;
            itemInStore.BigUnitBuyPrice = item.BigUnitBuyPrice;
            itemInStore.BigUnitSellPrice = item.BigUnitSellPrice;
            itemInStore.SmallProfit = item.SmallUnitSellPrice - item.SmallUnitBuyPrice;
            itemInStore.BigProfit = item.BigUnitSellPrice - item.BigUnitBuyPrice;
            if (add)
                NewItems.Add(itemInStore);
        }

        private string GenerateId()
        {
            string code;
            while (true)
            {
                code = GlobalFunc.RandomCode(5);
                if (!StoreInfoTbl.CheckItemExist(int.Parse(code)))
                {
                    return code;
                }
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if (e.RowIndex < OldItems.Count)
                    {
                        new CustomeMessageDialogue("لا يمكنك تعديل هذا الحقل");
                        dgvItems.Columns["colCode"].ReadOnly = true;
                        return;
                    }
                    dgvItems.Columns["colCode"].ReadOnly = false;
                }
                if (e.ColumnIndex == 3)
                {
                    if (cbxStores.SelectedIndex > 0)
                    {
                        new CustomeMessageDialogue("لا يمكنك تعديل هذا الحقل");
                        dgvItems.Columns["colCode"].ReadOnly = true;
                        return;
                    }
                    dgvItems.Columns["colCode"].ReadOnly = false;
                }
            }
            catch
            {

            }
            
        }

        private void dgvItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            //if (dgvItems.CurrentCell.ColumnIndex == 0)
            //{
            //    TextBox txtCode = e.Control as TextBox;
            //    if (txtCode != null)
            //    {
            //        txtCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //        txtCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //        txtCode.AutoCompleteCustomSource = ItemsCodeCollection;

            //    }
            //}
            if (dgvItems.Columns[dgvItems.CurrentCell.ColumnIndex].Name == "colUnit")
            {
                if (cbxStores.SelectedIndex > 0)
                    return;
                TextBox txtCode = e.Control as TextBox;
                if (txtCode != null)
                {
                    var item = AllItems.Find(x => x.Code == dgvItems.CurrentRow.Cells[0].Value.ToString());
                    if (item is null)
                    {
                        return;
                    }
                    txtCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    UnitCollection.Add(item.SmallUnit);
                    UnitCollection.Add(item.BigUnit);
                    txtCode.AutoCompleteCustomSource = UnitCollection;

                }
            }
        }

        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (!WindowLoaded)
                return;
            if (e.RowIndex == dgvItems.RowCount)
                return;
            //ItemInStore item;

            if (e.RowIndex < OldItems.Count)
            {
                //item = OldItems[e.RowIndex];
                OldItems.RemoveAt(e.RowIndex);
            }
            else
            {
                //item = OldItems[e.RowIndex];
                NewItems.RemoveAt(e.RowIndex);
            }

            //MessageBox.Show(item.ToStr());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using(var msg = new CustomeMessageDialogue("تأكيد تسوية الاصناف", MessageType.Warning))
                {
                    var res = msg.ShowDialog();
                    if (res != DialogResult.Yes)
                        return;
                }
                if(cbxStores.SelectedIndex == 0)
                {
                    if (OldItems.Count > 0)
                    {
                        foreach (var item in OldItems)
                        {
                            ShopTbl.EditItemInShop(item);

                        }
                        ActivityTbl.SaveActivity(new Activitiy()
                        {
                            Employee = Program.EmpLogedin,
                            Date = DateTime.Now,
                            ActivityType = ActivityType.Edit,
                            Description = "تسوية الاصناف"
                        });
                    }
                    if (NewItems.Count > 0)
                    {
                        foreach (var item in NewItems)
                        {
                            item.Bill = "1";
                            double q = item.Quantity;
                            item.Quantity = 0;
                            StoreInfoTbl.SaveItemInStore(item);
                            item.Id = StoreInfoTbl.FindItemIdWithCode(item.Code);
                            item.Quantity = q;
                            ShopTbl.SaveItemInShop(item);
                            ActivityTbl.SaveActivity(new Activitiy()
                            {
                                Employee = Program.EmpLogedin,
                                Date = DateTime.Now,
                                ActivityType = ActivityType.Add,
                                Description = " Name: " + item.Name + ",exp: " + item.ExpirationDate + ",quantity: " + item.Quantity
                            });
                        }
                    }

                }
                else
                {
                    if (OldItems.Count > 0)
                    {
                        foreach (var item in OldItems)
                        {
                            StoreInfoTbl.EditItemInStore(item);

                        }
                        ActivityTbl.SaveActivity(new Activitiy()
                        {
                            Employee = Program.EmpLogedin,
                            Date = DateTime.Now,
                            ActivityType = ActivityType.Edit,
                            Description = "تسوية الاصناف"
                        });
                    }
                    if (NewItems.Count > 0)
                    {
                        foreach (var item in NewItems)
                        {
                            item.Bill = "1";
                            StoreInfoTbl.SaveItemInStore(item);
                            ActivityTbl.SaveActivity(new Activitiy()
                            {
                                Employee = Program.EmpLogedin,
                                Date = DateTime.Now,
                                ActivityType = ActivityType.Add,
                                Description = " Name: " + item.Name + ",exp: " + item.ExpirationDate + ",quantity: " + item.Quantity
                            });
                        }
                    }
                }
                    
                if (NewItems.Count == 0 && OldItems.Count == 0)
                {
                    new CustomeMessageDialogue("لم تضف اى اصناف لتسويتها");
                    return;
                }
                RefreshWindowInfo();
                new CustomeMessageDialogue("تم تسوية الاصناف بنجاح");
            }
            catch (Exception ex)
            {

                new CustomeMessageDialogue( $"برجاء نسخ هذة الرسالة و ارسالها للدعم الفنى للنظام" +
                    $"{ex.ToString()}");
            }
            
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtp.Visible = false;
                if (dgvItems.Columns[e.ColumnIndex].Name == "colExpDate")
                {
                    dtp = new DateTimePicker(); ;
                    dgvItems.Controls.Add(dtp);
                    dtp.Visible = false;
                    dtp.MinDate = DateTime.Now;
                    dtp.ValueChanged += Dtp_ValueChanged;
                    rectangle = dgvItems.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(rectangle.Width, rectangle.Height);
                    dtp.Location = new Point(rectangle.X, rectangle.Y);
                    dtp.Visible = true;
                }
            }
            catch (Exception)
            {

            }
            
            
        }



        private void dgvItems_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dgvItems_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void dgvItems_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                dtp.Visible = false;
            }
            catch (Exception)
            {
            }
            
        }

        private void cbxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOldItems();
        }
    }
}
