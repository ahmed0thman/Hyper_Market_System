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

    public partial class UC_BillBuy : UserControl
    {
        public delegate void RefreshWalet();
        public static event RefreshWalet WaletRefreshed;
        List<Item> AllItems = new List<Item>();
        private Dictionary<string, string> dictAccounts;
        private List<BalanceMachine> AllAcounts = new List<BalanceMachine>();
        Dictionary<string, string> dictStores;
        Dictionary<string, string> dicSuppliers = new Dictionary<string, string>();
        List<Bill> BillsList = new List<Bill>();
        AutoCompleteStringCollection ItemsNamesCollection = new AutoCompleteStringCollection();
        bool WindowLoaded = false;
        DateTimePicker dtp = new DateTimePicker();
        Guna2ComboBox cbxUnit = new Guna2ComboBox();
        Rectangle rectangle;
        DataGridViewCell CurrentCell;
        PanelBillSatate panelBillSatate = PanelBillSatate.Hide;
        Bill CurrentBill;
        double oldBalance = 0;
        public UC_BillBuy(bool billRequested = false, string BillId = "")
        {
            InitializeComponent();
            FillCbxStores();
            InitListsItems();
            this.CurrentBill = null;
            InitListsItems();
            UC_SupplierMainInfo.DataRefreshed += UC_SupplierMainInfo_DataRefreshed;
            UC_ItemMainInfo.DataRefreshed += UC_ItemMainInfo_DataRefreshed;
            UC_BillCard.BillClicked += UC_BillCard_BillClicked;
            UC_BillCard.BillDeleted += UC_BillCard_BillDeleted;
            UC_Machines.MachineHandeled += UC_Machines_MachineHandeled;
            UC_BILLDebts.PaymentHandeled += UC_BILLDebts_PaymentHandeled;
            GetAllSuppliers();
            GetAllAcounts();
            dtpBillDate.Value = DateTime.Now;
            if (billRequested)
            {
                panelBillsCards.Controls.Clear();
                dgvBillInfo.BringToFront();
                var listTbl = BillTbl.GetBill(BillType.Buy, BillId);
                foreach (var bill in listTbl)
                {
                    panelBillsCards.Controls.Add(new UC_BillCard(bill));
                }

            }
            else
            {
                panelBillsCards.Controls.Clear();
                ShowBills(DateTime.Now);
                GetAllBills();
            }
                
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                UC_SupplierMainInfo.DataRefreshed -= UC_SupplierMainInfo_DataRefreshed;
                UC_ItemMainInfo.DataRefreshed -= UC_ItemMainInfo_DataRefreshed;
                UC_BillCard.BillClicked -= UC_BillCard_BillClicked;
                UC_BillCard.BillDeleted -= UC_BillCard_BillDeleted;
                UC_Machines.MachineHandeled -= UC_Machines_MachineHandeled;
                UC_BILLDebts.PaymentHandeled -= UC_BILLDebts_PaymentHandeled;

                base.Dispose();
            };
        }

        private void UC_BILLDebts_PaymentHandeled()
        {
            try
            {
                panelBillsCards.Controls.Clear();
                InitListsItems();
                ClearCurrentBillData();
                CalCulateAllBillInfo();
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                GetAllBills();
                ShowBills(DateTime.Now);
                btnSaveCurrentBill.Enabled = true;
                btnEditCurrentBill.Enabled = false;
            }
            catch (Exception)
            {
            }
            
        }

        private void UC_Machines_MachineHandeled()
        {
            GetAllAcounts();
        }

        private void GetAllBills(string dtFrm = "", string dt2 = "")
        {
            try
            {
                BillsList.Clear();
                var listTbl = BillTbl.GetBill(BillType.Buy);
                if (listTbl.Count == 0)
                    return;
               
                foreach (var bill in listTbl)
                {

                    BillsList.Add(bill);
                }
            }
            catch (Exception)
            {
            }

        }
        private void GetAllAcounts(bool stop = false)
        {
            AllAcounts.Clear();
            dictAccounts = new Dictionary<string, string>();
            dictAccounts.Add("0", "الدرج");
            var accounts = MachineTbl.GetMachines();
            for (int i = 0; i < accounts.Rows.Count; i++)
            {
                BalanceMachine account = new BalanceMachine()
                {
                    Id = int.Parse(accounts.Rows[i][BalanceMachine.IDC].ToString()),
                    Name = accounts.Rows[i][BalanceMachine.NAMEC].ToString(),
                    Balance = double.Parse(accounts.Rows[i][BalanceMachine.BALANCEC].ToString())
                };
                dictAccounts.Add(accounts.Rows[i][BalanceMachine.IDC].ToString(), accounts.Rows[i][BalanceMachine.NAMEC].ToString());
                AllAcounts.Add(account);
            }
            if (stop)
                return;
            cbxAccounts.DataSource = new BindingSource(dictAccounts, null);
            cbxAccounts.DisplayMember = "Value";
            cbxAccounts.ValueMember = "Key";
            cbxAccounts.SelectedIndex = -1;
        }

        private void UC_BillBuy_Load(object sender, EventArgs e)
        {
            GetAllItems();
            
            WindowLoaded = true;
        }
        private void ShowBills(DateTime dt)
        {
            try
            {
                panelBillsCards.Controls.Clear();
                foreach (var bill in BillsList.FindAll(x => x.date.Date == dt.Date))
                {
                    panelBillsCards.Controls.Add(new UC_BillCard(bill));
                }
            }
            catch (Exception)
            {
            }

        }

        private void dtpBillDate_ValueChanged(object sender, EventArgs e)
        {
            ShowBills(dtpBillDate.Value);
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
                    Description = "Code: " + this.CurrentBill.Id + ", Price: " + this.CurrentBill.TotalPrice
                });
                panelBillsCards.Controls.Clear();
                InitListsItems();
                ClearCurrentBillData();
                CalCulateAllBillInfo();
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                GetAllBills();
                ShowBills(DateTime.Now);
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

            
                if (bill.Type == BillType.Sell) return;
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
                dgvBillInfo.Refresh();
                cbxSupplier.SelectedIndex = 0;
                btnSaveCurrentBill.Enabled = false;
                btnEditCurrentBill.Enabled = true;
                var itemsInBill = BillInfoTable.GetBillBuyInfo(bill);
                for (int i = 0; i < itemsInBill.Count; i++)
                {
                    double price = itemsInBill[i].Price;
                    double total = itemsInBill[i].Totalprice;
                    double count = itemsInBill[i].Count;
                    int idInShop = itemsInBill[i].IdInShop;
                    string unit = itemsInBill[i].Unit;
                    string date = itemsInBill[i].ExpirationDate;
                    var item = AllItems.Find(x => x.Code == itemsInBill[i].Code);
                    if (item is null) continue;
                    var itemToBill = item.ToItemInStore();
                    itemsInBill[i] = itemToBill.ToItemInBill();
                    itemsInBill[i].IdInShop = idInShop;
                    itemsInBill[i].Price = price;
                    itemsInBill[i].Totalprice = total;
                    itemsInBill[i].Count = count;
                    itemsInBill[i].Bill = bill.Id;
                    itemsInBill[i].Unit = unit;
                    itemsInBill[i].ExpirationDate = date;
                }
            
                bill.ItemsInBill = itemsInBill;
                txtDiscount.Text = bill.Discount.ToString();
                InitListsItems();
                this.CurrentBill = bill;
                cbxAccounts.Text = this.CurrentBill.Account;
                CalCulateAllBillInfo();
                this.CurrentBill.FillTbl();
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                cbxSupplier.SelectedValue = bill.Person.Id.ToString();
            }
            catch
            {

            }
        }

        private void ClearCurrentBillData()
        {
            InitListsItems();
            //GetAllItems();
            dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
            dgvBillInfo.Refresh();
            lblPrice.Text = "";
            lblTotalPrice.Text = "";
            lblRest.Text = "";
            lblItemsCount.Text = "";
            txtDiscount.Text = "";
            txtPaid.Text = "";
            cbxSupplier.SelectedIndex = 0;
        }
        private void InitListsItems()
        {
            try
            {
                this.CurrentBill = new Bill()
                {
                    Person = new Person(0),
                    Type = BillType.Buy,
                    Employee = Program.EmpLogedin,
                    date = DateTime.Now,
                };
                this.CurrentBill.ItemsInBill.Clear();
            }
            catch (Exception)
            {
            }
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
        private void GetAllItems()
        {
            AllItems = ItemTbl.GetItems();
            if (AllItems.Count == 0)
                return;

            foreach (var item in AllItems)
            {
                ItemsNamesCollection.Add(item.Name);
            }
            txtItemSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtItemSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItemSearch.AutoCompleteCustomSource = ItemsNamesCollection;
        }
        private void UC_ItemMainInfo_DataRefreshed()
        {
            GetAllItems();
        }

        private void UC_SupplierMainInfo_DataRefreshed()
        {
            GetAllSuppliers();
        }

        private void GetAllSuppliers()
        {
            dicSuppliers.Clear();
            var suppliers = PersonTbl.GetAllPersons(PersonType.Supplier);
            if(suppliers.Count == 0)
            {
                new CustomeMessageDialogue("يجب ادخال مورد واحد على الاقل من خلال شاشة الموردين");
                this.Enabled = false;
                return;
            }
            foreach (var person in suppliers)
            {
                dicSuppliers.Add(person.Id.ToString(), person.Name);
            }

            cbxSupplier.DataSource = new BindingSource(dicSuppliers, null);
            cbxSupplier.DisplayMember = "Value";
            cbxSupplier.ValueMember = "Key";
        }
        private void btnShowPanelBillInfo_Click(object sender, EventArgs e)
        {
            if (panelBillSatate == PanelBillSatate.Show)
                btnShowPanelBillInfo.Image = Image.FromFile("ICO\\arrowDown.png");
            else
                btnShowPanelBillInfo.Image = Image.FromFile("ICO\\arrowUp.png");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            FormWindowContainer WindowSuppliers = new FormWindowContainer(new UC_Suppliers(PersonType.Supplier), "الموردين");
            WindowSuppliers.Show();
        }

        private void btnShowPanelBillInfo_Click_1(object sender, EventArgs e)
        {
            if (panelBillInfo.Height <= 50)
                btnShowPanelBillInfo.Image = Image.FromFile("ICO\\arrowDown.png");
            else
                btnShowPanelBillInfo.Image = Image.FromFile("ICO\\arrowUp.png");
            timer1.Start();
        }

        private void txtItemSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    string searchType = txtItemSearch.Text.Trim();
                    Item item;
                    if (searchType.ToList().TrueForAll(x => Char.IsDigit(x)))
                    {
                        item = AllItems.Find(x => x.Code == searchType);

                        if (item is null)
                        {
                            new CustomeMessageDialogue(" الصنف غير موجود");
                            return;
                        }
                    }
                    else
                    {
                        item = AllItems.Find(x => x.Name == searchType);

                        if (item is null)
                        {
                            new CustomeMessageDialogue(" الصنف غير موجود");
                            return;
                        }
                    }
                    AddItemToBill(item);
                    txtItemSearch.Text = "";
                    txtItemSearch.Focus();
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void AddItemToBill(Item itemToBill)
        {
            try
            {
                ItemInBill itemInBill = new ItemInBill()
                {
                    Code = itemToBill.Code,
                    Name = itemToBill.Name,
                    Unit = itemToBill.BigUnit,
                    Price = itemToBill.BigUnitBuyPrice,
                    Totalprice = itemToBill.BigUnitBuyPrice,
                    BigUnit = itemToBill.BigUnit,
                    SmallUnit = itemToBill.SmallUnit,
                    SmallUnitBuyPrice = itemToBill.SmallUnitBuyPrice,
                    BigUnitBuyPrice = itemToBill.BigUnitBuyPrice,
                    SmallUnitSellPrice = itemToBill.SmallUnitSellPrice,
                    BigUnitSellPrice = itemToBill.BigUnitSellPrice,
                    SmallNumInBig = itemToBill.SmallNumInBig,
                    ExpirationDate = DateTime.Today.AddMonths(3).ToString("d")
                };
                itemInBill.SmallProfit = itemInBill.SmallUnitSellPrice - itemInBill.SmallUnitBuyPrice;
                itemInBill.BigProfit = itemInBill.BigUnitSellPrice - itemInBill.BigUnitBuyPrice;
                this.CurrentBill.Add(itemInBill);
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                CalCulateAllBillInfo();
            }
            catch (Exception)
            {

            }
            
        }

        private void CalCulateAllBillInfo()
        {
            try
            {
                lblPrice.Text = this.CurrentBill.GetPrice().ToString();
                lblTotalPrice.Text = this.CurrentBill.GetTotalPrice().ToString();
                lblItemsCount.Text = this.CurrentBill.countItems().ToString();
                lblRest.Text = this.CurrentBill.GetRest().ToString();
                txtPaid.Text = this.CurrentBill.GetTotalPrice().ToString();
            }
            catch (Exception)
            {

            }


        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
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

        private void dgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                if (i > dgvBillInfo.RowCount)
                    return;

                dtp.Visible = false;
                if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colExpDate")
                {
                    dtp = new DateTimePicker(); ;
                    dgvBillInfo.Controls.Add(dtp);
                    dtp.Visible = false;
                    dtp.MinDate = DateTime.Now;
                    dtp.ValueChanged += Dtp_ValueChanged;
                    rectangle = dgvBillInfo.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(rectangle.Width, rectangle.Height);
                    dtp.Location = new Point(rectangle.X, rectangle.Y);
                    dtp.Visible = true;
                }
                if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colUnit")
                {
                    cbxUnit = new Guna2ComboBox(); ;
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict.Add("1", this.CurrentBill[i].BigUnit);
                    dict.Add("2", this.CurrentBill[i].SmallUnit);
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

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            //if (e.KeyData != Keys.Enter)
            //    return;
            try
            {
                dgvBillInfo.CurrentCell.Value = dtp.Value.ToString("d");
                dgvBillInfo_CellEndEdit(dgvBillInfo.CurrentCell, new DataGridViewCellEventArgs(dgvBillInfo.CurrentCell.ColumnIndex, dgvBillInfo.CurrentCell.RowIndex));

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
                this.CurrentBill[i].Unit = cbx.Text;
                this.CurrentBill[i].Price = this.CurrentBill[i].Unit == this.CurrentBill[i].SmallUnit ? CurrentBill[i].SmallUnitBuyPrice : CurrentBill[i].BigUnitBuyPrice;
                this.CurrentBill[i].Totalprice = this.CurrentBill[i].Price * this.CurrentBill[i].Count;

                this.CurrentBill.FillTbl();
                CalCulateAllBillInfo();
                cbx.Hide();
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
                    this.CurrentBill[i].Count = quantity;
                    this.CurrentBill[i].Totalprice = this.CurrentBill[i].Price * this.CurrentBill[i].Count;
                    this.CurrentBill.FillTbl();
                    CalCulateAllBillInfo();
                    dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
                }
                else if (dgvBillInfo.Columns[e.ColumnIndex].Name == "colExpDate")
                {
                    this.CurrentBill[i].ExpirationDate = dgvBillInfo.Rows[e.RowIndex].Cells["colExpDate"].Value.ToString();
                
                }
            }
            catch { }
        }

        private void btnSaveCurrentBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxAccounts.SelectedIndex < 0)
                {
                    new CustomeMessageDialogue("اختر الحساب");
                    return;
                }
                bool vaildPrice = double.TryParse(txtPaid.Text.Trim(), out double pricePaid);
                if (!vaildPrice)
                {
                    new CustomeMessageDialogue("أدخل رقم صحيح");
                    txtPaid.SelectAll();
                    txtPaid.Focus();
                    return;
                }
                if (CurrentBill.countItems() == 0)
                    return;

                
                this.CurrentBill.Id = BillTbl.GetLastBillCode() + 1;
                this.CurrentBill.IdInDay = BillTbl.GetLastBillInDay(DateTime.Now, BillType.Buy) + 1;
                this.CurrentBill.Paid = double.Parse(txtPaid.Text);
                this.CurrentBill.Discount = double.Parse(txtDiscount.Text);
                this.CurrentBill.CountItems = this.CurrentBill.countItems();
                this.CurrentBill.Price = this.CurrentBill.GetPrice();
                this.CurrentBill.TotalPrice = this.CurrentBill.GetTotalPrice();
                this.CurrentBill.Rest = this.CurrentBill.GetRest();
                this.CurrentBill.Person = new Person(int.Parse(cbxSupplier.SelectedValue.ToString()));
                this.CurrentBill.Account = cbxAccounts.Text;
                BillTbl.SaveBill(CurrentBill);
                ItemInStore newitem;
                if (cbxStores.SelectedIndex > 0)
                {
                    foreach (ItemInBill item in CurrentBill)
                    {
                        item.Store = new Store(int.Parse(cbxStores.SelectedValue.ToString()));
                        newitem = (ItemInStore)item;
                        newitem.Bill = CurrentBill.Id.ToString();
                        newitem.Unit = item.Unit;
                        newitem.Price = item.Price;
                        newitem.Quantity = item.Count;
                        StoreInfoTbl.SaveItemInStore(newitem);
                    }
                }
                else
                {
                    foreach (ItemInBill item in CurrentBill)
                    {
                        item.Store = new Store(int.Parse(cbxStores.SelectedValue.ToString()));
                        newitem = (ItemInStore)item;
                        newitem.Quantity = 0;
                        newitem.Bill = CurrentBill.Id.ToString();
                        newitem.Unit = item.Unit;
                        newitem.Price = item.Price;
                        StoreInfoTbl.SaveItemInStore(newitem);
                        newitem.Id = StoreInfoTbl.FindItemIdWithCode(item.Code);
                        newitem.Quantity = item.Count;
                        ShopTbl.SaveItemInShop(newitem);
                    }
                }

                BillInfoTable.SaveBillBuyInfo(CurrentBill);

                if (cbxAccounts.SelectedIndex == 0)
                {
                    WaletTbl.Minus(CurrentBill.Paid);
                }
                else
                {
                    int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
                    MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                    {
                        Date = DateTime.Now,
                        Machine = new BalanceMachine(machineId),
                        Price = CurrentBill.Paid,
                        Type = OperationType.Transaction,
                        Details = $"اضافة فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                    }
                    );
                    MachineTbl.Minus(CurrentBill.Paid, machineId);
                }
                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.NewBill,
                    Description = "Code: " + this.CurrentBill.IdInDay + ", Price: " + this.CurrentBill.TotalPrice
                });
                ClearCurrentBillData();
                GetAllBills();
                ShowBills(DateTime.Now);
                WaletRefreshed?.Invoke();
            }
            catch (Exception)
            {

            }

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
            if (dgvBillInfo.CurrentCell is null)
                return;
            if (e.KeyData != Keys.Delete)
                return;
            int i = dgvBillInfo.CurrentCell.RowIndex;
            using (var msg = new CustomeMessageDialogue("تأكيد حذف الصنف؟", MessageType.Warning))
            {
                var res = msg.ShowDialog();
                if (res != DialogResult.Yes)
                    return;

                this.CurrentBill.RemoveAt(i);
                CalCulateAllBillInfo();
                this.CurrentBill.FillTbl();
                dgvBillInfo.DataSource = this.CurrentBill.tblCureentItems;
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
                if (cbxAccounts.SelectedIndex < 0)
                {
                    new CustomeMessageDialogue("اختر الحساب");
                    return;
                }
                bool vaildPrice = double.TryParse(txtPaid.Text.Trim(), out double pricePaid);
                if (!vaildPrice)
                {
                    new CustomeMessageDialogue("أدخل رقم صحيح");
                    txtPaid.SelectAll();
                    txtPaid.Focus();
                    return;
                }
                this.CurrentBill.profit = this.CurrentBill.Sum(delegate (ItemInBill item)
                {
                    if (item.Unit == item.BigUnit)
                        return item.Totalprice - (item.BigUnitBuyPrice * item.Count);
                    else
                        return item.Totalprice - (item.SmallUnitBuyPrice * item.Count);
                });
                this.CurrentBill.Paid = Math.Round(pricePaid, 1);
                this.CurrentBill.Discount = double.Parse(txtDiscount.Text);
                this.CurrentBill.CountItems = this.CurrentBill.countItems();
                this.CurrentBill.Price = this.CurrentBill.GetPrice();
                this.CurrentBill.TotalPrice = this.CurrentBill.GetTotalPrice();
                this.CurrentBill.Rest = this.CurrentBill.GetRest();
                this.CurrentBill.Person = new Person(int.Parse(cbxSupplier.SelectedValue.ToString()));
                using(var msg = new CustomeMessageDialogue("تعديل الحسابات و المدفوع فقط؟", MessageType.WarningCancel))
                {
                    var res = msg.ShowDialog();
                    if (res == DialogResult.No)
                    {
                        BillInfoTable.DeleteBillBuyInfo(CurrentBill);
                        StoreInfoTbl.DeleteItemInStoreByBill(CurrentBill.Id.ToString());
                        ItemInStore newitem;
                        if (cbxStores.SelectedIndex > 0)
                        {
                            foreach (ItemInBill item in CurrentBill)
                            {
                                item.Store = new Store(int.Parse(cbxStores.SelectedValue.ToString()));
                                newitem = (ItemInStore)item;
                                newitem.Bill = CurrentBill.Id.ToString();
                                newitem.Unit = item.Unit;
                                newitem.Price = item.Price;
                                newitem.Quantity = item.Count;
                                StoreInfoTbl.SaveItemInStore(newitem);
                            }
                        }
                        else
                        {
                            foreach (ItemInBill item in CurrentBill)
                            {
                                item.Store = new Store(int.Parse(cbxStores.SelectedValue.ToString()));
                                newitem = (ItemInStore)item;
                                newitem.Quantity = 0;
                                newitem.Bill = CurrentBill.Id.ToString();
                                newitem.Unit = item.Unit;
                                newitem.Price = item.Price;
                                StoreInfoTbl.SaveItemInStore(newitem);
                                newitem.Id = StoreInfoTbl.FindItemIdWithCode(item.Code);
                                newitem.Quantity = item.Count;
                                ShopTbl.SaveItemInShop(newitem);
                            }
                        }
                        BillInfoTable.SaveBillBuyInfo(CurrentBill);
                    }
                    else if (res == DialogResult.Cancel)
                        return;
                    
                }
                if (cbxAccounts.Text != this.CurrentBill.Account)
                {
                    if (cbxAccounts.SelectedIndex == 0)
                    {
                        int machineId = AllAcounts.Find(x => x.Name == CurrentBill.Account).Id;
                        WaletTbl.Minus(oldBalance);
                        MachineTbl.Plus(oldBalance, machineId);
                        MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                        {
                            Date = DateTime.Now,
                            Machine = new BalanceMachine(machineId),
                            Price = oldBalance,
                            Type = OperationType.TranseferIn,
                            Details = $"تعديل حساب فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                            + $" من {CurrentBill.Account}" + $" الى {cbxAccounts.Text}"
                        }
                        );
                    }
                    else
                    {
                        if(this.CurrentBill.Account == "الدرج")
                        {
                            int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
                            WaletTbl.Plus(oldBalance);
                            MachineTbl.Minus(oldBalance, machineId);
                            MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                            {
                                Date = DateTime.Now,
                                Machine = new BalanceMachine(machineId),
                                Price = oldBalance,
                                Type = OperationType.Transefer,
                                Details = $"تعديل حساب فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                                + $" من {CurrentBill.Account}" + $" الى {cbxAccounts.Text}"
                            }
                            );
                        }
                        else
                        {
                            int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
                            int machineIdOld = AllAcounts.Find(x => x.Name == CurrentBill.Account).Id;
                            MachineTbl.Plus(oldBalance, machineIdOld);
                            MachineTbl.Minus(oldBalance, machineId);
                            MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                            {
                                Date = DateTime.Now,
                                Machine = new BalanceMachine(machineId),
                                Price = oldBalance,
                                Type = OperationType.Transefer,
                                Details = $"تعديل حساب فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                                + $" من {CurrentBill.Account}" + $" الى {cbxAccounts.Text}"
                            }
                            );
                            MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                            {
                                Date = DateTime.Now,
                                Machine = new BalanceMachine(machineIdOld),
                                Price = oldBalance,
                                Type = OperationType.TranseferIn,
                                Details = $"تعديل حساب فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                                + $" من {CurrentBill.Account}" + $" الى {cbxAccounts.Text}"
                            }
                            );
                        }
                        
                    }
                }
                if (cbxAccounts.SelectedIndex == 0)
                {
                    if (CurrentBill.Paid < CurrentBill.TotalPrice)
                    {
                        WaletTbl.Plus(oldBalance - CurrentBill.Paid);
                    }
                    else if (CurrentBill.Paid >= CurrentBill.TotalPrice)
                        WaletTbl.Minus(CurrentBill.TotalPrice - oldBalance);
                }
                else
                {
                    int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
                    MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                    {
                        Date = DateTime.Now,
                        Machine = new BalanceMachine(machineId),
                        Price = Math.Abs(CurrentBill.Paid - oldBalance) ,
                        Type = CurrentBill.Paid > oldBalance? OperationType.Transaction : OperationType.Deposit,
                        Details = $"تعديل فاتورة شراء بتاريخ {DateTime.Now.ToString("d")}" + "\n" + "كود :" + CurrentBill.IdInDay.ToString()
                        + "\n" + $"فرق حساب {CurrentBill.Paid - oldBalance}"
                    }
                    );
                    if (CurrentBill.Paid < CurrentBill.TotalPrice)
                    {
                        MachineTbl.Plus(oldBalance - CurrentBill.Paid, machineId);
                    }
                    else if (CurrentBill.Paid >= CurrentBill.TotalPrice)
                        MachineTbl.Minus(CurrentBill.TotalPrice - oldBalance, machineId);

                }
                if (CurrentBill.Paid > oldBalance)
                {
                    BillPayment billPayment = new BillPayment()
                    {
                        DateTime = DateTime.Now,
                        Price = CurrentBill.Paid - oldBalance,
                        BillId = CurrentBill.Id
                    };
                    BillPaymentTbl.AddPayment(billPayment);
                }
                CurrentBill.Account = cbxAccounts.Text;
                BillTbl.EditBill(CurrentBill);
                

                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.EditBill,
                    Description = "Code: " + this.CurrentBill.Id + ", Price: " + this.CurrentBill.TotalPrice
                });
                ClearCurrentBillData();
                GetAllBills();
                ShowBills(DateTime.Now);
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
                lblPrice.Text = this.CurrentBill.GetPrice().ToString();
                lblTotalPrice.Text = this.CurrentBill.GetTotalPrice().ToString();
                lblItemsCount.Text = this.CurrentBill.countItems().ToString();
                lblRest.Text = this.CurrentBill.GetRest().ToString();
                return;
            }
            bool done = double.TryParse(txtPaid.Text.Trim(), out double paid);
            if (done)
            {
                this.CurrentBill.Paid = paid;
                lblPrice.Text = this.CurrentBill.GetPrice().ToString();
                lblTotalPrice.Text = this.CurrentBill.GetTotalPrice().ToString();
                lblItemsCount.Text = this.CurrentBill.countItems().ToString();
                lblRest.Text = this.CurrentBill.GetRest().ToString();
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
