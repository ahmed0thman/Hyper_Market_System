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
using Guna.UI2.WinForms;

namespace MarketSystem.Windows.UserControls
{
    #region Panel Bill State Enumration
    enum PanelBillSatate
    {
        Show, Hide
    }
    #endregion
    public partial class UC_Bill : UserControl
    {
        public delegate void RefreshWalet();
        public static event RefreshWalet WaletRefreshed;

        Guna2ComboBox cbxUnit = new Guna2ComboBox();
        Rectangle rectangle;
        bool windowLoaded = false;
        List<ItemInStore> AllItems;
        AutoCompleteStringCollection ItemsNamesCollection = new AutoCompleteStringCollection();
        PanelBillSatate panelBillSatate = PanelBillSatate.Show;
        PanelBillSatate panelHandleSearchSatate = PanelBillSatate.Hide;
        Dictionary<string, string> dictClients = new Dictionary<string, string>();
        double oldBalance = 0;
        FlowLayoutPanel panelCategories = new FlowLayoutPanel()
                {
            Dock = DockStyle.Top,
            Height = 300,
            Padding = new Padding(5),
            AutoScroll = true,
            RightToLeft = RightToLeft.Yes
        };
        FlowLayoutPanel panelItemsContainer = new FlowLayoutPanel()
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(5),
            AutoScroll = true,
            RightToLeft = RightToLeft.Yes
        };
        Bill CurrentBill;
        List<ItemInStore> ListItemToEdit = new List<ItemInStore>();
        Category CurrentCategory;
        public UC_Bill(bool billRequested = false, string BillId = "")
        {
            InitializeComponent();
            GEtAllItems();
            this.CurrentBill = null;
            InitListsItems();
            UC_SupplierMainInfo.DataRefreshed += UC_SupplierMainInfo_DataRefreshed;
            UC_ItemMainInfo.DataRefreshed += UC_ItemMainInfo_DataRefreshed;
            UC_BillCard.BillClicked += UC_BillCard_BillClicked;
            UC_BillCard.BillDeleted += UC_BillCard_BillDeleted;
            UC_BILLDebts.PaymentHandeled += UC_BILLDebts_PaymentHandeled;
            GetAllClients();
            HandleAutoCompleteCollections();
            if (billRequested)
            {
                btnBillsArchive.Checked = true;
                dgvBillInfo.BringToFront();
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(new UC_BillSellArchive(true, BillId) { Dock = DockStyle.Fill });
            }
            else 
                btnCategoriesItems.PerformClick();
            GetAllCategories();
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                this.CurrentBill = null;
                ListItemToEdit = null;
                UC_SupplierMainInfo.DataRefreshed -= UC_SupplierMainInfo_DataRefreshed;
                UC_ItemMainInfo.DataRefreshed -= UC_ItemMainInfo_DataRefreshed;
                UC_BillCard.BillClicked -= UC_BillCard_BillClicked;
                UC_BillCard.BillDeleted -= UC_BillCard_BillDeleted;
                UC_BILLDebts.PaymentHandeled -= UC_BILLDebts_PaymentHandeled;
                base.Dispose();
            };
        }

        private void UC_BILLDebts_PaymentHandeled()
        {
            try
            {
                InitListsItems();
                ClearCurrentBillData();
                CalCulateAllBillInfo();
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                btnSaveCurrentBill.Enabled = true;
                btnEditCurrentBill.Enabled = false;
            }
            catch
            {

            }
            
        }
        private void UC_BillCard_BillDeleted(Bill bill)
        {
            try
            {
                

                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.DeleteBill,
                    Description = "Code: " +this.CurrentBill.Id + ", Price: " +this.CurrentBill.TotalPrice
                });
                InitListsItems();
                ClearCurrentBillData();
                CalCulateAllBillInfo();
                dgvBillInfo.DataSource =this.CurrentBill.tblCureentItems;
                btnSaveCurrentBill.Enabled = true;
                btnEditCurrentBill.Enabled = false;
            }
            catch (Exception)
            {
            }
            
        }


        private void UC_BillCard_BillClicked(Bill bill)
        {
            try
            {
                if (bill.Type == BillType.Buy) return;
                if (CurrentBill != null && this.CurrentBill.countItems() > 0)
                {

                    using (var msg = new CustomeMessageDialogue("هل تريد مسح الفاتورة الحالية", MessageType.Warning))
                    {
                        var res = msg.ShowDialog();
                        if (res != DialogResult.Yes)
                            return;
                    }
                }
                oldBalance = bill.Paid;
                GEtAllItems();
                dgvBillInfo.Refresh();
                cbxclients.SelectedIndex = 0;
                btnSaveCurrentBill.Enabled = false;
                btnEditCurrentBill.Enabled = true;
                var itemsInBill = BillInfoTable.GetBillInfo(bill);
                for (int i = 0; i < itemsInBill.Count; i++)
                {
                    double price = itemsInBill[i].Price;
                    double total = itemsInBill[i].Totalprice;
                    double count = itemsInBill[i].Count;
                    int idInShop = itemsInBill[i].IdInShop;
                    var itemToBill = AllItems.Find(x => x.IdInShop == itemsInBill[i].IdInShop);
                    itemsInBill[i] = itemToBill.ToItemInBill();
                    itemsInBill[i].IdInShop = idInShop;
                    itemsInBill[i].Price = price;
                    itemsInBill[i].Totalprice = total;
                    itemsInBill[i].Count = count;
                    itemsInBill[i].Bill = bill.Id;
                }

                bill.ItemsInBill = itemsInBill;
                txtDiscount.Text = bill.Discount.ToString();
                InitListsItems();
                this.CurrentBill = bill;
                CalCulateAllBillInfo();
                this.CurrentBill.FillTbl();
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                cbxclients.SelectedValue = bill.Person.Id.ToString();
            }
            catch
            {

            }
        }

        private void InitListsItems()
        {
            try
            {
               this.CurrentBill = new Bill()
                {
                    Person = new Person(0),
                    Type = BillType.Sell,
                    Employee = Program.EmpLogedin,
                    profit = 0,
                    date = DateTime.Now,
                    Account = "الدرج"
                };
               this.CurrentBill.ItemsInBill.Clear();
                ListItemToEdit.Clear();
            }
            catch (Exception)
            {
            }

            
        }

        private void HandleAutoCompleteCollections()
        {
            try
            {
                foreach (var item in AllItems)
                {
                    ItemsNamesCollection.Add(item.Name);
                }
                txtItemSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtItemSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtItemSearch.AutoCompleteCustomSource = ItemsNamesCollection;
            }
            catch (Exception)
            {
            }
           
        }

        private void GEtAllItems()
        {
            try { 

                AllItems = StoreInfoTbl.GetItemsFromShop(); //.FindAll(x => x.Store.Id == 1);
                                                        //AllItems = AllItems.FindAll(x => x.Quantity > 0);
            }
            catch
            {

            }
        }

        private void UC_ItemMainInfo_DataRefreshed()
        {
            try
            {
                GEtAllItems();
                GetAllCategories();
            }
            catch (Exception)
            {
            }

        }

        private void UC_SupplierMainInfo_DataRefreshed()
        {
            try
            {
                GetAllClients();
            }
            catch (Exception)
            {
            }
            
        }

        private void GetAllClients()
        {
            try
            { 
            dictClients.Clear();
            var clients = PersonTbl.GetPersonsButSupplier();
            dictClients.Add("0", "زائر");
            foreach (var client in clients)
            {
                dictClients.Add(client.Id.ToString(), client.Name);
            }
            
            cbxclients.DataSource = new BindingSource(dictClients, null);
            cbxclients.DisplayMember = "Value";
            cbxclients.ValueMember = "Key";
            }
            catch
            {

            }
        }

        private void UC_ItemCard_CardItemClicked(ItemInStore item)
        {
            try 
            { 
            dgvBillInfo.BringToFront();
            if (tglBigUnit.Checked)
                return;
            AddItemToBill(item);
            }
            catch
            {

            }

        }

        private void UC_Category_CategoryClicked(Category category)
        {
            try
            {
                CurrentCategory = category;
                panelItemsContainer.Controls.Clear();
                var allItemsInCqtegory = AllItems.FindAll(x => x.Menu == category.ID && x.Quantity > 0 && x.Unit == x.SmallUnit);
                var results = allItemsInCqtegory.GroupBy(x => x.Code)
                                .Select(g => g.OrderBy(o => o.ExpirationDate).First()).ToList();
                foreach (var item in results)
                {
                    var tempCard = new UC_ItemCard(item);
                    tempCard.CardItemClicked += UC_ItemCard_CardItemClicked;
                    panelItemsContainer.Controls.Add(tempCard);
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void btnShowPanelBillInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (panelBillInfo.Height <= 50)
                    btnShowPanelBillInfo.Image = Image.FromFile("ICO\\arrowDown.png");
                else
                    btnShowPanelBillInfo.Image = Image.FromFile("ICO\\arrowUp.png");
                timer1.Start();
            }
            catch
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (panelBillSatate)
                {
                    case PanelBillSatate.Show:
                        panelBillInfo.Height -= 25;
                        if (panelBillInfo.Height <= 50)
                        {
                            panelBillSatate = PanelBillSatate.Hide;
                            timer1.Stop();
                        }
                        break;
                    case PanelBillSatate.Hide:
                        panelBillInfo.Height += 25;
                        if (panelBillInfo.Height >= 170)
                        {
                            panelBillSatate = PanelBillSatate.Show;
                            timer1.Stop();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void UC_Bill_Load(object sender, EventArgs e)
        {
           
            windowLoaded = true;
        }

        private void GetAllCategories()
        {
            try
            { 
            var Categories = MenuTbl.GetAllMenu();
            if (Categories.Count == 0)
                return;
            panelCategories.Controls.Clear();
            foreach (var cat in Categories)
            {
                UC_Category tempcat = new UC_Category(cat);
                tempcat.CategoryClicked += UC_Category_CategoryClicked;
                panelCategories.Controls.Add(tempcat);
            }
            CurrentCategory = Categories[0];
            }
            catch
            {

            }
        }

        private void btnCategoriesItems_Click(object sender, EventArgs e)
        {
            ShowPanelsCategoriesItems();

        }

        private void ShowPanelsCategoriesItems()
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(panelItemsContainer);
            panelContainer.Controls.Add(panelCategories);
            txtItemSearch.Text = "";
            txtItemSearch.Focus();

        }

        private void btnBillsArchive_Click(object sender, EventArgs e)
        {
            dgvBillInfo.BringToFront();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(new UC_BillSellArchive() { Dock = DockStyle.Fill });
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowClients = new FormWindowContainer(new UC_Suppliers(PersonType.Client), "العملاء");
            WindowClients.Show();
        }

        private void txtItemSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string searchType = txtItemSearch.Text.Trim();
                SearchForAvailableItem(searchType);
            }
        }

        private bool SearchForAvailableItem(string searchType)
        {
            try
            {
                ItemInStore itemToBill;
                if (searchType.ToList().TrueForAll(x => Char.IsDigit(x)))
                {
                    List<ItemInStore> item;
                    if (tglBigUnit.Checked)
                    {
                        item = AllItems.FindAll(x => x.Code == searchType && x.Unit == x.BigUnit && x.Quantity > 0);
                    }
                    else
                    {
                        item = AllItems.FindAll(x => x.Code == searchType && x.Unit == x.SmallUnit && x.Quantity > 0);
                    }
                    var itemsearch = item.GroupBy(x => x.Code)
                                    .Select(g => g.OrderBy(o => o.ExpirationDate).First()).ToList();
                    if (itemsearch.Count == 0)
                    {
                        new CustomeMessageDialogue(" الصنف غير متوفر");
                        return false;
                    }
                    itemToBill = itemsearch[0];
                }
                else
                {
                    List<ItemInStore> item;
                    if (tglBigUnit.Checked)
                    {
                        item = AllItems.FindAll(x => x.Name == searchType && x.Unit == x.BigUnit && x.Quantity > 0);
                    }
                    else
                    {
                        item = AllItems.FindAll(x => x.Name == searchType && x.Unit == x.SmallUnit && x.Quantity > 0);
                    }
                    var itemsearch = item.GroupBy(x => x.Code)
                                   .Select(g => g.OrderBy(o => o.ExpirationDate).First()).ToList();
                    if (itemsearch.Count == 0)
                    {
                        new CustomeMessageDialogue("الصنف غير متوفر");
                        return false;
                    }
                    itemToBill = itemsearch[0];
                }
                if (itemToBill is null)
                {
                    new CustomeMessageDialogue("الصنف غير متوفر");
                    return false;
                }
                AddItemToBill(itemToBill);
                txtItemSearch.Text = "";
                txtItemSearch.Focus();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        private void AddItemToBill(ItemInStore itemToBill)
        {
            try
            {
                if (itemToBill.Quantity == 0)
                {
                    new CustomeMessageDialogue("الصنف غير متاح");
                    return;
                }

                ItemInBill itemInBill = new ItemInBill()
                {
                    Code = itemToBill.Code,
                    Id = itemToBill.Id,
                    IdInShop = itemToBill.IdInShop,
                    Name = itemToBill.Name,
                    Unit = itemToBill.Unit,
                    //Bill =this.CurrentBill.Id,
                    Price = tglBigUnit.Checked ? itemToBill.BigUnitSellPrice : itemToBill.SmallUnitSellPrice,
                    Totalprice = itemToBill.Price,
                    BigUnit = itemToBill.BigUnit,
                    SmallUnit = itemToBill.SmallUnit,
                    SmallUnitSellPrice = itemToBill.SmallUnitSellPrice,
                    BigUnitSellPrice = itemToBill.BigUnitSellPrice,
                    SmallNumInBig = itemToBill.SmallNumInBig
                };
                this.CurrentBill.Add(itemInBill);
                itemToBill.Quantity -= 1;
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                CalCulateAllBillInfo();
                if (itemToBill.Quantity == 0)
                {
                    UC_Category_CategoryClicked(CurrentCategory);
                }
                if (!ListItemToEdit.Contains(itemToBill))
                {
                    ListItemToEdit.Add(itemToBill);
                }
            }
            catch (Exception)
            {

            }
            
            
        }

        private void CalCulateAllBillInfo()
        {
            try
            {
                lblPrice.Text =this.CurrentBill.GetPrice().ToString();
                lblTotalPrice.Text =this.CurrentBill.GetTotalPrice().ToString();
                lblItemsCount.Text =this.CurrentBill.countItems().ToString();
                lblRest.Text =this.CurrentBill.GetRest().ToString();
                txtPaid.Text =this.CurrentBill.GetTotalPrice().ToString();
            }
            catch (Exception)
            {

            }
            

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text.Trim() == "")
                {
                    txtDiscount.Text = "0";
                    this.CurrentBill.Discount = 0;
                    CalCulateAllBillInfo();
                    return;
                }
                bool done = double.TryParse(txtDiscount.Text.Trim(), out double discount);
                if (done)
                {
                    this.CurrentBill.Discount = discount;
                    CalCulateAllBillInfo();
                }
                else
                {
                    new CustomeMessageDialogue("الخصم يجب ان يكون ارقام فقط");
                    txtDiscount.SelectAll();
                    txtDiscount.Focus();
                }
            }
            catch (Exception)
            {
            }
            

        }

        private void dgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i > dgvBillInfo.RowCount)
                    return;
                if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colPrice")
                {
                    if (Program.EmpLogedin.Permission == EmpPermission.Cashier)
                    {
                        new CustomeMessageDialogue("ليس لديك صلاحية لتعديل هذة البيانات");
                        return;
                    }
                }

                if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colUnit")
                {
                    cbxUnit = new Guna2ComboBox(); ;
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("1", this.CurrentBill[i].SmallUnit);
                    dict.Add("2", this.CurrentBill[i].BigUnit);
                    cbxUnit.DataSource = new BindingSource(dict, null);
                    cbxUnit.DisplayMember = "Value";
                    cbxUnit.ValueMember = "Key";
                    dgvBillInfo.Controls.Add(cbxUnit);
                    cbxUnit.Visible = false;
                    cbxUnit.SelectedIndex = 0;
                    cbxUnit.SelectedIndexChanged += CbxUnit_SelectedIndexChanged;
                    rectangle = dgvBillInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    cbxUnit.Size = new Size(rectangle.Width, rectangle.Height);
                    cbxUnit.Location = new Point(rectangle.X, rectangle.Y);
                    cbxUnit.Visible = true;
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void CbxUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = dgvBillInfo.CurrentCell.RowIndex;
                if (i >= dgvBillInfo.RowCount)
                    return;
                var cbx = ((Guna2ComboBox)sender);
                ItemInStore itemToDecreasQuantuty;
                List<ItemInStore> itemCollection;
                if (cbx.SelectedIndex == 0)
                {
                    var matchedItems = AllItems.FindAll(x => x.Code == this.CurrentBill[i].Code
                        && x.Unit == x.SmallUnit
                        && x.Quantity >= this.CurrentBill[i].Count
                    );
                    itemCollection = matchedItems.GroupBy(x => x.Code)
                                   .Select(g => g.OrderBy(o => o.ExpirationDate).First()).ToList();
                }
                else
                {
                    var matchedItems = AllItems.FindAll(x => x.Code == this.CurrentBill[i].Code
                        && x.Unit == x.BigUnit
                        && x.Quantity >= this.CurrentBill[i].Count
                    );
                    itemCollection = matchedItems.GroupBy(x => x.Code)
                                   .Select(g => g.OrderBy(o => o.ExpirationDate).First()).ToList();
                }
                if (itemCollection.Count == 0)
                {
                    if (cbx.SelectedIndex == 0)
                    {
                        using (var msg = new CustomeMessageDialogue($"الصنف غير متاح كوحدة {CurrentBill[i].SmallUnit} هل تريد فتح وحدة {CurrentBill[i].BigUnit}", MessageType.Warning))
                        {
                            var res = msg.ShowDialog();
                            if (res == DialogResult.Yes)
                            {
                                var newItem = this.CurrentBill[i].ToItemInBill();
                                newItem.Count = 1;
                                ShopTbl.MinusQuantity(newItem);
                                var Item = newItem.ToItemInStore();
                                Item.Quantity = Item.SmallNumInBig;
                                Item.Id = CurrentBill[i].Id;
                                Item.Unit = this.CurrentBill[i].SmallUnit;
                                ShopTbl.SaveItemInShop(Item);
                                GEtAllItems();
                                CbxUnit_SelectedIndexChanged(sender, e);
                                return;
                            }
                        }

                    }
                    new CustomeMessageDialogue("الصنف غير موجود");
                    return;
                }
                itemToDecreasQuantuty = itemCollection[0];
                var itemTotIncreasQuantity = AllItems.Find(x => x.IdInShop == this.CurrentBill[i].IdInShop);
                if (itemTotIncreasQuantity is null) return;
                this.CurrentBill[i].IdInShop = itemToDecreasQuantuty.IdInShop;
                this.CurrentBill[i].Unit = itemToDecreasQuantuty.Unit;
                this.CurrentBill[i].Price = cbx.SelectedIndex == 0 ? itemToDecreasQuantuty.SmallUnitSellPrice : itemToDecreasQuantuty.BigUnitSellPrice;
                this.CurrentBill[i].Totalprice = this.CurrentBill[i].Price * this.CurrentBill[i].Count;
                itemToDecreasQuantuty.Quantity -= this.CurrentBill[i].Count;
                itemTotIncreasQuantity.Quantity += this.CurrentBill[i].Count;
                ListItemToEdit.Add(itemTotIncreasQuantity);
                ListItemToEdit.Add(itemToDecreasQuantuty);
                UC_Category_CategoryClicked(CurrentCategory);
                this.CurrentBill.FillTbl();
                CalCulateAllBillInfo();
                cbx.Hide();
                UC_Category_CategoryClicked(CurrentCategory);
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
            }
            catch (Exception)
            {

            }
        }

        private void dgvBillInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i > dgvBillInfo.RowCount)
                    return;
                if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colPrice")
                {

                    bool done = double.TryParse(dgvBillInfo.CurrentCell.Value.ToString(), out double price);
                    if (!done)
                    {
                        new CustomeMessageDialogue("قيمة السعر غير صحية");
                        dgvBillInfo.CurrentCell.Value = "";
                        return;
                    }
                    this.CurrentBill[i].Price = price;
                    this.CurrentBill[i].Totalprice = price * this.CurrentBill[i].Count;
                    this.CurrentBill.FillTbl();
                    CalCulateAllBillInfo();

                }
                else if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colQuantity")
                {
                    bool done = double.TryParse(dgvBillInfo.CurrentCell.Value.ToString(), out double quantity);
                    if (!done)
                    {
                        new CustomeMessageDialogue("قيمة  غير صحية");
                        dgvBillInfo.CurrentCell.Value = this.CurrentBill[i].Count.ToString();
                        return;
                    }
                    if (quantity == 0)
                    {
                        new CustomeMessageDialogue("الكمية لايمكن تساوى 0 قم بتحديد الصنف واضغط على زر delete اذا كنت تريد حذفة");
                        dgvBillInfo.CurrentCell.Value = this.CurrentBill[i].Count.ToString();
                        return;
                    }
                    if (CurrentBill[i].Count == quantity)
                        return;
                    var itemToDecreasQuantuty = AllItems.Find(x => x.IdInShop == this.CurrentBill[i].IdInShop && x.Quantity >= quantity - this.CurrentBill[i].Count);
                    if (itemToDecreasQuantuty is null)
                    {
                        var itemToDecreas = AllItems.Find(x => x.IdInShop == this.CurrentBill[i].IdInShop);
                        if (itemToDecreas is null) return;
                        //new CustomeMessageDialogue($"الكمية غير كافية المتوفر {itemToDecreas.Quantity}");
                        double q = itemToDecreas.Quantity;
                        itemToDecreas.Quantity = 0;
                        this.CurrentBill[i].Count += q;
                        this.CurrentBill[i].Totalprice = this.CurrentBill[i].Price * this.CurrentBill[i].Count;
                        ListItemToEdit.Remove(itemToDecreas);
                        ListItemToEdit.Add(itemToDecreas);
                        this.CurrentBill.FillTbl();
                        CalCulateAllBillInfo();
                        for (int j = 0; j < quantity - this.CurrentBill[i].Count; j++)
                        {
                            bool found = SearchForAvailableItem(itemToDecreas.Code);
                            if (!found) break;
                        }
                        UC_Category_CategoryClicked(CurrentCategory);
                        dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                        return;
                    }
                    itemToDecreasQuantuty.Quantity -= quantity - this.CurrentBill[i].Count;
                    this.CurrentBill[i].Count = quantity;
                    this.CurrentBill[i].Totalprice = this.CurrentBill[i].Price * this.CurrentBill[i].Count;
                    ListItemToEdit.Remove(itemToDecreasQuantuty);
                    ListItemToEdit.Add(itemToDecreasQuantuty);
                    UC_Category_CategoryClicked(CurrentCategory);
                    this.CurrentBill.FillTbl();
                    CalCulateAllBillInfo();

                    UC_Category_CategoryClicked(CurrentCategory);
                    dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void btnSaveCurrentBill_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (CurrentBill.countItems() == 0)
                    return;
                //if (CurrentBill.Paid == 0)
                //{
                //    new CustomeMessageDialogue("مفيش فلوس مفيش فاتورة يالا باى");
                //    txtPaid.Focus();
                //    return;
                //}
                bool vaildPrice = double.TryParse(txtPaid.Text.Trim(), out double pricePaid);
                if (!vaildPrice)
                {
                    new CustomeMessageDialogue("أدخل رقم صحيح");
                    txtPaid.SelectAll();
                    txtPaid.Focus();
                    return;
                }
                this.CurrentBill.profit =this.CurrentBill.Sum(delegate (ItemInBill item)
                {
                    if (item.Unit == item.BigUnit)
                        return item.Totalprice - (item.SmallUnitBuyPrice * item.Count);
                    else
                        return item.Totalprice - (item.BigUnitBuyPrice * item.Count);
                });
               this.CurrentBill.Id = BillTbl.GetLastBillCode() + 1;
               this.CurrentBill.IdInDay = BillTbl.GetLastBillInDay(DateTime.Now, BillType.Sell) + 1;
                this.CurrentBill.Paid = Math.Round(pricePaid, 1);
               this.CurrentBill.Discount = double.Parse(txtDiscount.Text);
               this.CurrentBill.CountItems =this.CurrentBill.countItems();
               this.CurrentBill.Price =this.CurrentBill.GetPrice();
               this.CurrentBill.TotalPrice =this.CurrentBill.GetTotalPrice();
               this.CurrentBill.Rest =this.CurrentBill.GetRest();
               this.CurrentBill.Person = new Person(int.Parse(cbxclients.SelectedValue.ToString()));
                BillTbl.SaveBill(CurrentBill);
                BillInfoTable.SaveBillInfo(CurrentBill);
                //foreach (var item in ListItemToEdit)
                //{
                //    ShopTbl.EditItemInShop(item);
                //}
                foreach (var item in CurrentBill)
                {
                    ShopTbl.MinusQuantity(item);
                }
                WaletTbl.Plus(CurrentBill.Paid);
                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.NewBill,
                    Description = "Code: " +this.CurrentBill.IdInDay + ", Price: " +this.CurrentBill.TotalPrice
                });
                ClearCurrentBillData();

                WaletRefreshed?.Invoke();
            }
            catch (Exception)
            {
            }
            
        }

        private void ClearCurrentBillData()
        {
            InitListsItems();
            GEtAllItems();
            dgvBillInfo.DataSource =this.CurrentBill.tblCureentItems;
            dgvBillInfo.Refresh();
            lblPrice.Text = "";
            lblTotalPrice.Text = "";
            lblRest.Text = "";
            lblItemsCount.Text = "";
            txtDiscount.Text = "";
            txtPaid.Text = "";
            cbxclients.SelectedIndex = 0;
        }

        private void dgvBillInfo_CurrentCellChanged(object sender, EventArgs e)
        {
            cbxUnit.Dispose();
        }

        private void dgvBillInfo_Scroll(object sender, ScrollEventArgs e)
        {
            cbxUnit.Dispose();
        }

        private void dgvBillInfo_KeyDown(object sender, KeyEventArgs e)
        {
            try { 

                if (dgvBillInfo.CurrentCell is null)
                    return;
                int i = dgvBillInfo.CurrentCell.RowIndex;
                if (e.KeyData == Keys.Delete)
                {
                    using (var msg = new CustomeMessageDialogue("تأكيد حذف الصنف؟", MessageType.Warning))
                    {
                        var res = msg.ShowDialog();
                        if (res != DialogResult.Yes)
                            return;
                        var itemToIcreaseQuantuty = AllItems.Find(x => x.IdInShop == this.CurrentBill[i].IdInShop);
                        if (itemToIcreaseQuantuty is null) return;
                        itemToIcreaseQuantuty.Quantity += this.CurrentBill[i].Count;
                        if (btnSaveCurrentBill.Enabled)
                        {
                            ListItemToEdit.Remove(CurrentBill[i]);

                        }
                        else
                        {
                            ListItemToEdit.Add(itemToIcreaseQuantuty);
                        }

                        this.CurrentBill.RemoveAt(i);
                        CalCulateAllBillInfo();
                        this.CurrentBill.FillTbl();
                        dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                        UC_Category_CategoryClicked(CurrentCategory);
                    }
                }
            }
            catch
            {

            }


        }

        private void btnDelCurrentBill_Click(object sender, EventArgs e)
        {
            try
            {
                using (var msg = new CustomeMessageDialogue("تأكيد تفريغ الفاتورة", MessageType.Warning))
                {
                    var res = msg.ShowDialog();
                    if (res == DialogResult.Yes)
                    {
                        ClearCurrentBillData();
                        btnSaveCurrentBill.Enabled = true;
                        btnEditCurrentBill.Enabled = false;
                        WaletRefreshed?.Invoke();
                    }
                }
            }
            catch (Exception)
            {

            }
            
            
        }

        private void btnEditCurrentBill_Click(object sender, EventArgs e)
        {
            try
            {
                bool vaildPrice = double.TryParse(txtPaid.Text.Trim(), out double pricePaid);
                if (!vaildPrice)
                {
                    new CustomeMessageDialogue("أدخل رقم صحيح");
                    txtPaid.SelectAll();
                    txtPaid.Focus();
                    return;
                }
                this.CurrentBill.profit =this.CurrentBill.Sum(delegate (ItemInBill item)
                {
                    if (item.Unit == item.BigUnit)
                        return item.Totalprice - (item.BigUnitBuyPrice * item.Count);
                    else
                        return item.Totalprice - (item.SmallUnitBuyPrice * item.Count);
                });
                this.CurrentBill.Paid = Math.Round(pricePaid, 1);
                this.CurrentBill.Discount = double.Parse(txtDiscount.Text);
                this.CurrentBill.CountItems =this.CurrentBill.countItems();
                this.CurrentBill.Price =this.CurrentBill.GetPrice();
                this.CurrentBill.TotalPrice =this.CurrentBill.GetTotalPrice();
                this.CurrentBill.Person = new Person(int.Parse(cbxclients.SelectedValue.ToString()));
                this.CurrentBill.Rest =this.CurrentBill.GetRest();
                WaletTbl.Minus(oldBalance - CurrentBill.Paid);
                BillTbl.EditBill(CurrentBill);
                BillInfoTable.DeleteBillInfo(CurrentBill);
                BillInfoTable.SaveBillInfo(CurrentBill);
                foreach (var item in ListItemToEdit)
                {
                    ShopTbl.EditItemInShop(item);
                }

                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.EditBill,
                    Description = "Code: " +this.CurrentBill.Id + ", Price: " +this.CurrentBill.TotalPrice
                });
                if(CurrentBill.Paid > oldBalance)
                {
                    BillPayment billPayment = new BillPayment()
                    {
                        DateTime = DateTime.Now,
                        Price = CurrentBill.Paid - oldBalance,
                        BillId = CurrentBill.Id
                    };
                    BillPaymentTbl.AddPayment(billPayment);
                }

                //if (CurrentBill.Paid < oldBalance)
                //{
                //    WaletTbl.Minus(oldBalance - CurrentBill.Paid);
                //}
                //else if(CurrentBill.Paid >= oldBalance)
                //    WaletTbl.Minus(oldBalance - CurrentBill.TotalPrice);

                ClearCurrentBillData();
                btnEditCurrentBill.Enabled = false;
                btnSaveCurrentBill.Enabled = true;
                WaletRefreshed?.Invoke();
            }
            catch (Exception)
            {

            }
            
        }

        private void dgvBillInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colPrice")
            {
                if (Program.EmpLogedin.Permission == EmpPermission.Cashier)
                {
                    new CustomeMessageDialogue("ليس لديك صلاحية لتعديل هذة البيانات");
                    return;
                }
            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPaid.Text.Trim() == "")
            {
                this.CurrentBill.Paid = 0;
                lblPrice.Text =this.CurrentBill.GetPrice().ToString();
                lblTotalPrice.Text =this.CurrentBill.GetTotalPrice().ToString();
                lblItemsCount.Text =this.CurrentBill.countItems().ToString();
                lblRest.Text =this.CurrentBill.GetRest().ToString();
                return;
            }
            bool done = double.TryParse(txtPaid.Text.Trim(), out double paid);
            if (done)
            {
               this.CurrentBill.Paid = paid;
                lblPrice.Text =this.CurrentBill.GetPrice().ToString();
                lblTotalPrice.Text =this.CurrentBill.GetTotalPrice().ToString();
                lblItemsCount.Text =this.CurrentBill.countItems().ToString();
                lblRest.Text =this.CurrentBill.GetRest().ToString();
            }
            else
            {
                new CustomeMessageDialogue("المبلغ يجب ان يكون ارقام فقط");
                txtPaid.SelectAll();
                txtPaid.Focus();
            }
        }

    }
}
