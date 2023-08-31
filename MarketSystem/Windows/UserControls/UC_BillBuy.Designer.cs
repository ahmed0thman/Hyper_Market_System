namespace MarketSystem.Windows.UserControls
{
    partial class UC_BillBuy
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BillBuy));
            this.panelItemsInfo = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dgvBillInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBillInfo = new System.Windows.Forms.Panel();
            this.cbxAccounts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxStores = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toggleButton1 = new MarketSystem.ToggleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPaid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnShowPanelBillInfo = new Guna.UI2.WinForms.Guna2Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtItemSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNewSupplier = new Guna.UI2.WinForms.Guna2Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnEditCurrentBill = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveCurrentBill = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBillsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHandleBillSearch = new System.Windows.Forms.Panel();
            this.txtBillSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBillDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelItemsInfo.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.panelBillInfo.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHandleBillSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemsInfo
            // 
            this.panelItemsInfo.BackColor = System.Drawing.Color.White;
            this.panelItemsInfo.Controls.Add(this.panel18);
            this.panelItemsInfo.Controls.Add(this.panel14);
            this.panelItemsInfo.Controls.Add(this.panel15);
            this.panelItemsInfo.Controls.Add(this.panel13);
            this.panelItemsInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelItemsInfo.Location = new System.Drawing.Point(596, 2);
            this.panelItemsInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelItemsInfo.Name = "panelItemsInfo";
            this.panelItemsInfo.Size = new System.Drawing.Size(775, 717);
            this.panelItemsInfo.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dgvBillInfo);
            this.panel18.Controls.Add(this.panelBillInfo);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 44);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(775, 626);
            this.panel18.TabIndex = 5;
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.AllowUserToAddRows = false;
            this.dgvBillInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(124)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillInfo.ColumnHeadersHeight = 34;
            this.dgvBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colUnit,
            this.colPrice,
            this.colQuantity,
            this.colTotal,
            this.colExpDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillInfo.EnableHeadersVisualStyles = false;
            this.dgvBillInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvBillInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBillInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBillInfo.RowHeadersVisible = false;
            this.dgvBillInfo.RowHeadersWidth = 51;
            this.dgvBillInfo.RowTemplate.Height = 24;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(775, 580);
            this.dgvBillInfo.TabIndex = 23;
            this.dgvBillInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(124)))), ((int)(((byte)(202)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvBillInfo.ThemeStyle.ReadOnly = false;
            this.dgvBillInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvBillInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBillInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBillInfo.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBillInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvBillInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillInfo_CellClick);
            this.dgvBillInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillInfo_CellDoubleClick);
            this.dgvBillInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillInfo_CellEndEdit);
            this.dgvBillInfo.CurrentCellChanged += new System.EventHandler(this.dgvBillInfo_CurrentCellChanged);
            this.dgvBillInfo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvBillInfo_Scroll);
            this.dgvBillInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBillInfo_KeyDown);
            // 
            // colItem
            // 
            this.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colItem.DataPropertyName = "name";
            this.colItem.FillWeight = 200F;
            this.colItem.Frozen = true;
            this.colItem.HeaderText = "إسم المنتج";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            this.colItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItem.Width = 200;
            // 
            // colUnit
            // 
            this.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUnit.DataPropertyName = "unit";
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrice.DataPropertyName = "price";
            this.colPrice.FillWeight = 20F;
            this.colPrice.HeaderText = "السعر";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrice.Width = 90;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.FillWeight = 50F;
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colQuantity.Width = 60;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotal.DataPropertyName = "total";
            this.colTotal.HeaderText = "الإجمالى";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotal.Width = 125;
            // 
            // colExpDate
            // 
            this.colExpDate.HeaderText = "تاريخ انتهاء الصلاحية";
            this.colExpDate.Name = "colExpDate";
            // 
            // panelBillInfo
            // 
            this.panelBillInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panelBillInfo.Controls.Add(this.cbxAccounts);
            this.panelBillInfo.Controls.Add(this.cbxStores);
            this.panelBillInfo.Controls.Add(this.lblRest);
            this.panelBillInfo.Controls.Add(this.label12);
            this.panelBillInfo.Controls.Add(this.lblPrice);
            this.panelBillInfo.Controls.Add(this.label10);
            this.panelBillInfo.Controls.Add(this.toggleButton1);
            this.panelBillInfo.Controls.Add(this.label8);
            this.panelBillInfo.Controls.Add(this.txtPaid);
            this.panelBillInfo.Controls.Add(this.label7);
            this.panelBillInfo.Controls.Add(this.txtDiscount);
            this.panelBillInfo.Controls.Add(this.label6);
            this.panelBillInfo.Controls.Add(this.lblItemsCount);
            this.panelBillInfo.Controls.Add(this.label5);
            this.panelBillInfo.Controls.Add(this.lblTotalPrice);
            this.panelBillInfo.Controls.Add(this.label2);
            this.panelBillInfo.Controls.Add(this.panel17);
            this.panelBillInfo.Controls.Add(this.btnShowPanelBillInfo);
            this.panelBillInfo.Controls.Add(this.panel16);
            this.panelBillInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBillInfo.Location = new System.Drawing.Point(0, 580);
            this.panelBillInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBillInfo.Name = "panelBillInfo";
            this.panelBillInfo.Size = new System.Drawing.Size(775, 46);
            this.panelBillInfo.TabIndex = 22;
            // 
            // cbxAccounts
            // 
            this.cbxAccounts.BackColor = System.Drawing.Color.Transparent;
            this.cbxAccounts.BorderRadius = 7;
            this.cbxAccounts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccounts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAccounts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAccounts.FocusedState.Parent = this.cbxAccounts;
            this.cbxAccounts.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxAccounts.HoverState.Parent = this.cbxAccounts;
            this.cbxAccounts.ItemHeight = 30;
            this.cbxAccounts.ItemsAppearance.Parent = this.cbxAccounts;
            this.cbxAccounts.Location = new System.Drawing.Point(4, 5);
            this.cbxAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAccounts.Name = "cbxAccounts";
            this.cbxAccounts.ShadowDecoration.Parent = this.cbxAccounts;
            this.cbxAccounts.Size = new System.Drawing.Size(198, 36);
            this.cbxAccounts.TabIndex = 95;
            this.cbxAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxStores
            // 
            this.cbxStores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxStores.BackColor = System.Drawing.Color.Transparent;
            this.cbxStores.BorderRadius = 8;
            this.cbxStores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStores.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStores.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStores.FocusedState.Parent = this.cbxStores;
            this.cbxStores.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxStores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxStores.HoverState.Parent = this.cbxStores;
            this.cbxStores.ItemHeight = 30;
            this.cbxStores.Items.AddRange(new object[] {
            "المحل"});
            this.cbxStores.ItemsAppearance.Parent = this.cbxStores;
            this.cbxStores.Location = new System.Drawing.Point(211, 5);
            this.cbxStores.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStores.Name = "cbxStores";
            this.cbxStores.ShadowDecoration.Parent = this.cbxStores;
            this.cbxStores.Size = new System.Drawing.Size(151, 36);
            this.cbxStores.StartIndex = 0;
            this.cbxStores.TabIndex = 94;
            this.cbxStores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxStores.TextOffset = new System.Drawing.Point(-5, 0);
            // 
            // lblRest
            // 
            this.lblRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRest.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRest.Location = new System.Drawing.Point(434, 87);
            this.lblRest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRest.Name = "lblRest";
            this.lblRest.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblRest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRest.Size = new System.Drawing.Size(211, 29);
            this.lblRest.TabIndex = 31;
            this.lblRest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label12.Location = new System.Drawing.Point(661, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(103, 29);
            this.label12.TabIndex = 30;
            this.label12.Text = "الباقى:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(434, 49);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(211, 29);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label10.Location = new System.Drawing.Point(661, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(103, 29);
            this.label10.TabIndex = 28;
            this.label10.Text = "الكلى:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleButton1.BorderColor = System.Drawing.Color.LightGray;
            this.toggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton1.ForeColor = System.Drawing.Color.White;
            this.toggleButton1.IsOn = false;
            this.toggleButton1.Location = new System.Drawing.Point(601, 131);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffColor = System.Drawing.Color.DarkGray;
            this.toggleButton1.OffText = "";
            this.toggleButton1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleButton1.OnText = "";
            this.toggleButton1.Size = new System.Drawing.Size(44, 24);
            this.toggleButton1.TabIndex = 26;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.TextEnabled = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(649, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "طباعة فاتورة";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaid.BorderRadius = 10;
            this.txtPaid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaid.DefaultText = "";
            this.txtPaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaid.DisabledState.Parent = this.txtPaid;
            this.txtPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaid.FocusedState.Parent = this.txtPaid;
            this.txtPaid.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaid.HoverState.Parent = this.txtPaid;
            this.txtPaid.Location = new System.Drawing.Point(4, 123);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.PasswordChar = '\0';
            this.txtPaid.PlaceholderText = "";
            this.txtPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaid.SelectedText = "";
            this.txtPaid.ShadowDecoration.Parent = this.txtPaid;
            this.txtPaid.Size = new System.Drawing.Size(248, 35);
            this.txtPaid.TabIndex = 24;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(307, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "المدفوع";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscount.BorderRadius = 10;
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "0";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(4, 84);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionStart = 1;
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(248, 35);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(307, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "الخصم:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemsCount.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemsCount.Location = new System.Drawing.Point(4, 49);
            this.lblItemsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblItemsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemsCount.Size = new System.Drawing.Size(248, 29);
            this.lblItemsCount.TabIndex = 22;
            this.lblItemsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(268, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "عدد الاصناف:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(434, 8);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPrice.Size = new System.Drawing.Size(211, 29);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(661, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "الأجمالى:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.panel17.Location = new System.Drawing.Point(400, 46);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(2, 120);
            this.panel17.TabIndex = 18;
            // 
            // btnShowPanelBillInfo
            // 
            this.btnShowPanelBillInfo.Animated = true;
            this.btnShowPanelBillInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnShowPanelBillInfo.BorderRadius = 7;
            this.btnShowPanelBillInfo.CheckedState.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPanelBillInfo.CustomImages.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowPanelBillInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPanelBillInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowPanelBillInfo.HoverState.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPanelBillInfo.Image")));
            this.btnShowPanelBillInfo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowPanelBillInfo.Location = new System.Drawing.Point(388, 7);
            this.btnShowPanelBillInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPanelBillInfo.Name = "btnShowPanelBillInfo";
            this.btnShowPanelBillInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowPanelBillInfo.PressedDepth = 10;
            this.btnShowPanelBillInfo.ShadowDecoration.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.Size = new System.Drawing.Size(26, 28);
            this.btnShowPanelBillInfo.TabIndex = 17;
            this.btnShowPanelBillInfo.Click += new System.EventHandler(this.btnShowPanelBillInfo_Click_1);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(775, 2);
            this.panel16.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panel14.Controls.Add(this.txtItemSearch);
            this.panel14.Controls.Add(this.cbxSupplier);
            this.panel14.Controls.Add(this.btnNewSupplier);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 2);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(4, 4, 6, 4);
            this.panel14.Size = new System.Drawing.Size(775, 42);
            this.panel14.TabIndex = 4;
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.BorderRadius = 10;
            this.txtItemSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemSearch.DefaultText = "";
            this.txtItemSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemSearch.DisabledState.Parent = this.txtItemSearch;
            this.txtItemSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtItemSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemSearch.FocusedState.Parent = this.txtItemSearch;
            this.txtItemSearch.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemSearch.HoverState.Parent = this.txtItemSearch;
            this.txtItemSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtItemSearch.IconRight")));
            this.txtItemSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtItemSearch.Location = new System.Drawing.Point(516, 4);
            this.txtItemSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.PasswordChar = '\0';
            this.txtItemSearch.PlaceholderText = "كود المنتج او الاسم";
            this.txtItemSearch.SelectedText = "";
            this.txtItemSearch.ShadowDecoration.Parent = this.txtItemSearch;
            this.txtItemSearch.Size = new System.Drawing.Size(253, 34);
            this.txtItemSearch.TabIndex = 18;
            this.txtItemSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemSearch_KeyDown);
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cbxSupplier.BorderRadius = 10;
            this.cbxSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSupplier.DropDownHeight = 120;
            this.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSupplier.FocusedState.Parent = this.cbxSupplier;
            this.cbxSupplier.Font = new System.Drawing.Font("Simplified Arabic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxSupplier.HoverState.Parent = this.cbxSupplier;
            this.cbxSupplier.IntegralHeight = false;
            this.cbxSupplier.ItemHeight = 30;
            this.cbxSupplier.ItemsAppearance.Parent = this.cbxSupplier;
            this.cbxSupplier.Location = new System.Drawing.Point(60, 2);
            this.cbxSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.ShadowDecoration.Parent = this.cbxSupplier;
            this.cbxSupplier.Size = new System.Drawing.Size(196, 36);
            this.cbxSupplier.TabIndex = 33;
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.Animated = true;
            this.btnNewSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnNewSupplier.BorderRadius = 7;
            this.btnNewSupplier.CheckedState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSupplier.CustomImages.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewSupplier.FillColor = System.Drawing.Color.Transparent;
            this.btnNewSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewSupplier.ForeColor = System.Drawing.Color.White;
            this.btnNewSupplier.HoverState.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSupplier.Image")));
            this.btnNewSupplier.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNewSupplier.Location = new System.Drawing.Point(4, 4);
            this.btnNewSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnNewSupplier.PressedDepth = 10;
            this.btnNewSupplier.ShadowDecoration.Parent = this.btnNewSupplier;
            this.btnNewSupplier.Size = new System.Drawing.Size(50, 34);
            this.btnNewSupplier.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnNewSupplier, "اضفة مورد او شركة");
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(775, 2);
            this.panel15.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panel13.Controls.Add(this.btnEditCurrentBill);
            this.panel13.Controls.Add(this.guna2Button14);
            this.panel13.Controls.Add(this.btnSaveCurrentBill);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 670);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(15, 4, 15, 4);
            this.panel13.Size = new System.Drawing.Size(775, 47);
            this.panel13.TabIndex = 0;
            // 
            // btnEditCurrentBill
            // 
            this.btnEditCurrentBill.Animated = true;
            this.btnEditCurrentBill.BorderRadius = 5;
            this.btnEditCurrentBill.CheckedState.Parent = this.btnEditCurrentBill;
            this.btnEditCurrentBill.CustomImages.Parent = this.btnEditCurrentBill;
            this.btnEditCurrentBill.Enabled = false;
            this.btnEditCurrentBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.btnEditCurrentBill.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnEditCurrentBill.HoverState.Parent = this.btnEditCurrentBill;
            this.btnEditCurrentBill.Location = new System.Drawing.Point(165, 6);
            this.btnEditCurrentBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCurrentBill.Name = "btnEditCurrentBill";
            this.btnEditCurrentBill.ShadowDecoration.Parent = this.btnEditCurrentBill;
            this.btnEditCurrentBill.Size = new System.Drawing.Size(124, 39);
            this.btnEditCurrentBill.TabIndex = 2;
            this.btnEditCurrentBill.Text = "تعديل ";
            this.btnEditCurrentBill.Click += new System.EventHandler(this.btnEditCurrentBill_Click);
            // 
            // guna2Button14
            // 
            this.guna2Button14.Animated = true;
            this.guna2Button14.BorderRadius = 5;
            this.guna2Button14.CheckedState.Parent = this.guna2Button14;
            this.guna2Button14.CustomImages.Parent = this.guna2Button14;
            this.guna2Button14.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.guna2Button14.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.HoverState.Parent = this.guna2Button14;
            this.guna2Button14.Location = new System.Drawing.Point(15, 4);
            this.guna2Button14.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.ShadowDecoration.Parent = this.guna2Button14;
            this.guna2Button14.Size = new System.Drawing.Size(143, 39);
            this.guna2Button14.TabIndex = 1;
            this.guna2Button14.Text = "تفريغ الفاتورة";
            // 
            // btnSaveCurrentBill
            // 
            this.btnSaveCurrentBill.Animated = true;
            this.btnSaveCurrentBill.BorderRadius = 5;
            this.btnSaveCurrentBill.CheckedState.Parent = this.btnSaveCurrentBill;
            this.btnSaveCurrentBill.CustomImages.Parent = this.btnSaveCurrentBill;
            this.btnSaveCurrentBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveCurrentBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveCurrentBill.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnSaveCurrentBill.HoverState.Parent = this.btnSaveCurrentBill;
            this.btnSaveCurrentBill.Location = new System.Drawing.Point(559, 4);
            this.btnSaveCurrentBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCurrentBill.Name = "btnSaveCurrentBill";
            this.btnSaveCurrentBill.ShadowDecoration.Parent = this.btnSaveCurrentBill;
            this.btnSaveCurrentBill.Size = new System.Drawing.Size(201, 39);
            this.btnSaveCurrentBill.TabIndex = 0;
            this.btnSaveCurrentBill.Text = "حفظ الفاتورة";
            this.btnSaveCurrentBill.Click += new System.EventHandler(this.btnSaveCurrentBill_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelBillsCards);
            this.panel1.Controls.Add(this.panelHandleBillSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 717);
            this.panel1.TabIndex = 2;
            // 
            // panelBillsCards
            // 
            this.panelBillsCards.AutoScroll = true;
            this.panelBillsCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.panelBillsCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillsCards.Location = new System.Drawing.Point(0, 44);
            this.panelBillsCards.Margin = new System.Windows.Forms.Padding(2);
            this.panelBillsCards.Name = "panelBillsCards";
            this.panelBillsCards.Padding = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.panelBillsCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelBillsCards.Size = new System.Drawing.Size(594, 673);
            this.panelBillsCards.TabIndex = 3;
            // 
            // panelHandleBillSearch
            // 
            this.panelHandleBillSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.panelHandleBillSearch.Controls.Add(this.txtBillSearch);
            this.panelHandleBillSearch.Controls.Add(this.dtpBillDate);
            this.panelHandleBillSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandleBillSearch.Location = new System.Drawing.Point(0, 0);
            this.panelHandleBillSearch.Margin = new System.Windows.Forms.Padding(2);
            this.panelHandleBillSearch.Name = "panelHandleBillSearch";
            this.panelHandleBillSearch.Size = new System.Drawing.Size(594, 44);
            this.panelHandleBillSearch.TabIndex = 0;
            // 
            // txtBillSearch
            // 
            this.txtBillSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBillSearch.BorderRadius = 10;
            this.txtBillSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillSearch.DefaultText = "";
            this.txtBillSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBillSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBillSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillSearch.DisabledState.Parent = this.txtBillSearch;
            this.txtBillSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillSearch.FocusedState.Parent = this.txtBillSearch;
            this.txtBillSearch.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.txtBillSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBillSearch.HoverState.Parent = this.txtBillSearch;
            this.txtBillSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtBillSearch.IconRight")));
            this.txtBillSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtBillSearch.Location = new System.Drawing.Point(317, 5);
            this.txtBillSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillSearch.Name = "txtBillSearch";
            this.txtBillSearch.PasswordChar = '\0';
            this.txtBillSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBillSearch.PlaceholderText = "ابحث برقم الفاتورة";
            this.txtBillSearch.SelectedText = "";
            this.txtBillSearch.ShadowDecoration.Parent = this.txtBillSearch;
            this.txtBillSearch.Size = new System.Drawing.Size(266, 31);
            this.txtBillSearch.TabIndex = 22;
            this.txtBillSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.BorderColor = System.Drawing.Color.White;
            this.dtpBillDate.BorderRadius = 5;
            this.dtpBillDate.BorderThickness = 1;
            this.dtpBillDate.CheckedState.Parent = this.dtpBillDate;
            this.dtpBillDate.FillColor = System.Drawing.Color.Transparent;
            this.dtpBillDate.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBillDate.HoverState.Parent = this.dtpBillDate;
            this.dtpBillDate.Location = new System.Drawing.Point(12, 6);
            this.dtpBillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBillDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBillDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.ShadowDecoration.Parent = this.dtpBillDate;
            this.dtpBillDate.Size = new System.Drawing.Size(236, 29);
            this.dtpBillDate.TabIndex = 21;
            this.dtpBillDate.Value = new System.DateTime(2020, 11, 13, 21, 44, 19, 526);
            this.dtpBillDate.ValueChanged += new System.EventHandler(this.dtpBillDate_ValueChanged);
            // 
            // UC_BillBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelItemsInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_BillBuy";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(1373, 721);
            this.Load += new System.EventHandler(this.UC_BillBuy_Load);
            this.panelItemsInfo.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.panelBillInfo.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelHandleBillSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemsInfo;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2Button btnNewSupplier;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel13;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button btnSaveCurrentBill;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelBillsCards;
        private System.Windows.Forms.Panel panelHandleBillSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtBillSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBillDate;
        private System.Windows.Forms.Panel panelBillInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSupplier;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label10;
        private ToggleButton toggleButton1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPaid;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI2.WinForms.Guna2Button btnShowPanelBillInfo;
        private System.Windows.Forms.Panel panel16;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStores;
        private Guna.UI2.WinForms.Guna2TextBox txtItemSearch;
        private Guna.UI2.WinForms.Guna2Button btnEditCurrentBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAccounts;
    }
}
