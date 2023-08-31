namespace MarketSystem.Windows.UserControls
{
    partial class UC_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Bill));
            this.panelItemsInfo = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.dgvBillInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBillHint = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tglBigUnit = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panelBillInfo = new System.Windows.Forms.Panel();
            this.cbxclients = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnDelCurrentBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCurrentBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveCurrentBill = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.btnBillsArchive = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategoriesItems = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelItemsInfo.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.panelBillHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel14.SuspendLayout();
            this.panelBillInfo.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItemsInfo
            // 
            this.panelItemsInfo.BackColor = System.Drawing.Color.White;
            this.panelItemsInfo.Controls.Add(this.panel18);
            this.panelItemsInfo.Controls.Add(this.panel14);
            this.panelItemsInfo.Controls.Add(this.panel15);
            this.panelItemsInfo.Controls.Add(this.panelBillInfo);
            this.panelItemsInfo.Controls.Add(this.panel13);
            this.panelItemsInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelItemsInfo.Location = new System.Drawing.Point(926, 0);
            this.panelItemsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelItemsInfo.Name = "panelItemsInfo";
            this.panelItemsInfo.Size = new System.Drawing.Size(839, 825);
            this.panelItemsInfo.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.dgvBillInfo);
            this.panel18.Controls.Add(this.panelBillHint);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 48);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(839, 510);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(124)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillInfo.ColumnHeadersHeight = 34;
            this.dgvBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colUnit,
            this.colPrice,
            this.colQuantity,
            this.colTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvBillInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBillInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBillInfo.RowHeadersVisible = false;
            this.dgvBillInfo.RowHeadersWidth = 51;
            this.dgvBillInfo.RowTemplate.Height = 24;
            this.dgvBillInfo.Size = new System.Drawing.Size(839, 510);
            this.dgvBillInfo.TabIndex = 21;
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
            this.colUnit.Width = 150;
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
            // panelBillHint
            // 
            this.panelBillHint.Controls.Add(this.label13);
            this.panelBillHint.Controls.Add(this.pictureBox2);
            this.panelBillHint.Location = new System.Drawing.Point(0, 0);
            this.panelBillHint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBillHint.Name = "panelBillHint";
            this.panelBillHint.Size = new System.Drawing.Size(717, 549);
            this.panelBillHint.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label13.Location = new System.Drawing.Point(233, 369);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(243, 36);
            this.label13.TabIndex = 22;
            this.label13.Text = "إضغط على المنتجات لإضافتها للفاتورة";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panel14.Controls.Add(this.tglBigUnit);
            this.panel14.Controls.Add(this.label1);
            this.panel14.Controls.Add(this.txtItemSearch);
            this.panel14.Controls.Add(this.btnNewClient);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 2);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(5, 5, 8, 5);
            this.panel14.Size = new System.Drawing.Size(839, 46);
            this.panel14.TabIndex = 4;
            // 
            // tglBigUnit
            // 
            this.tglBigUnit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglBigUnit.CheckedState.BorderRadius = 2;
            this.tglBigUnit.CheckedState.BorderThickness = 0;
            this.tglBigUnit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglBigUnit.Location = new System.Drawing.Point(447, 15);
            this.tglBigUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tglBigUnit.Name = "tglBigUnit";
            this.tglBigUnit.Size = new System.Drawing.Size(20, 20);
            this.tglBigUnit.TabIndex = 29;
            this.tglBigUnit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglBigUnit.UncheckedState.BorderRadius = 2;
            this.tglBigUnit.UncheckedState.BorderThickness = 0;
            this.tglBigUnit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 28;
            this.label1.Text = "وحدة كبري";
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.BorderRadius = 10;
            this.txtItemSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemSearch.DefaultText = "";
            this.txtItemSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtItemSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemSearch.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtItemSearch.IconRight")));
            this.txtItemSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtItemSearch.Location = new System.Drawing.Point(494, 5);
            this.txtItemSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.PasswordChar = '\0';
            this.txtItemSearch.PlaceholderText = "كود المنتج او الاسم";
            this.txtItemSearch.SelectedText = "";
            this.txtItemSearch.Size = new System.Drawing.Size(337, 36);
            this.txtItemSearch.TabIndex = 17;
            this.txtItemSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemSearch_KeyDown);
            // 
            // btnNewClient
            // 
            this.btnNewClient.Animated = true;
            this.btnNewClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnNewClient.BorderRadius = 7;
            this.btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewClient.FillColor = System.Drawing.Color.Transparent;
            this.btnNewClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNewClient.ForeColor = System.Drawing.Color.White;
            this.btnNewClient.Image = ((System.Drawing.Image)(resources.GetObject("btnNewClient.Image")));
            this.btnNewClient.ImageSize = new System.Drawing.Size(35, 35);
            this.btnNewClient.Location = new System.Drawing.Point(5, 5);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnNewClient.PressedDepth = 10;
            this.btnNewClient.Size = new System.Drawing.Size(67, 36);
            this.btnNewClient.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnNewClient, "عميل جديد");
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(839, 2);
            this.panel15.TabIndex = 3;
            // 
            // panelBillInfo
            // 
            this.panelBillInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panelBillInfo.Controls.Add(this.cbxclients);
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
            this.panelBillInfo.Location = new System.Drawing.Point(0, 558);
            this.panelBillInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBillInfo.Name = "panelBillInfo";
            this.panelBillInfo.Size = new System.Drawing.Size(839, 209);
            this.panelBillInfo.TabIndex = 2;
            // 
            // cbxclients
            // 
            this.cbxclients.BackColor = System.Drawing.Color.Transparent;
            this.cbxclients.BorderRadius = 5;
            this.cbxclients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxclients.DropDownHeight = 200;
            this.cbxclients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxclients.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxclients.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxclients.Font = new System.Drawing.Font("Simplified Arabic", 10.2F);
            this.cbxclients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxclients.IntegralHeight = false;
            this.cbxclients.ItemHeight = 30;
            this.cbxclients.Location = new System.Drawing.Point(3, 6);
            this.cbxclients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxclients.MaxDropDownItems = 3;
            this.cbxclients.MaxLength = 8;
            this.cbxclients.Name = "cbxclients";
            this.cbxclients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxclients.Size = new System.Drawing.Size(305, 36);
            this.cbxclients.TabIndex = 34;
            // 
            // lblRest
            // 
            this.lblRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRest.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRest.Location = new System.Drawing.Point(479, 107);
            this.lblRest.Name = "lblRest";
            this.lblRest.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblRest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRest.Size = new System.Drawing.Size(187, 36);
            this.lblRest.TabIndex = 31;
            this.lblRest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label12.Location = new System.Drawing.Point(687, 107);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(137, 36);
            this.label12.TabIndex = 30;
            this.label12.Text = "الباقى:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(479, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(187, 36);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label10.Location = new System.Drawing.Point(687, 57);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(137, 36);
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
            this.toggleButton1.Location = new System.Drawing.Point(607, 161);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffColor = System.Drawing.Color.DarkGray;
            this.toggleButton1.OffText = "";
            this.toggleButton1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleButton1.OnText = "";
            this.toggleButton1.Size = new System.Drawing.Size(56, 30);
            this.toggleButton1.TabIndex = 26;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.TextEnabled = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(671, 155);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(153, 36);
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
            this.txtPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaid.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaid.Location = new System.Drawing.Point(5, 148);
            this.txtPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.PasswordChar = '\0';
            this.txtPaid.PlaceholderText = "";
            this.txtPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaid.SelectedText = "";
            this.txtPaid.Size = new System.Drawing.Size(233, 43);
            this.txtPaid.TabIndex = 24;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(315, 155);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(119, 36);
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
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Location = new System.Drawing.Point(5, 100);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionStart = 1;
            this.txtDiscount.Size = new System.Drawing.Size(233, 43);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(315, 107);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(119, 36);
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
            this.lblItemsCount.Location = new System.Drawing.Point(5, 60);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblItemsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemsCount.Size = new System.Drawing.Size(233, 36);
            this.lblItemsCount.TabIndex = 22;
            this.lblItemsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(263, 60);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(171, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "عدد الاصناف:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(479, 10);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalPrice.Size = new System.Drawing.Size(187, 36);
            this.lblTotalPrice.TabIndex = 20;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(687, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(137, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "الأجمالى:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.panel17.Location = new System.Drawing.Point(439, 54);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(3, 148);
            this.panel17.TabIndex = 18;
            // 
            // btnShowPanelBillInfo
            // 
            this.btnShowPanelBillInfo.Animated = true;
            this.btnShowPanelBillInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnShowPanelBillInfo.BorderRadius = 7;
            this.btnShowPanelBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPanelBillInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowPanelBillInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPanelBillInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowPanelBillInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPanelBillInfo.Image")));
            this.btnShowPanelBillInfo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowPanelBillInfo.Location = new System.Drawing.Point(423, 5);
            this.btnShowPanelBillInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowPanelBillInfo.Name = "btnShowPanelBillInfo";
            this.btnShowPanelBillInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowPanelBillInfo.PressedDepth = 10;
            this.btnShowPanelBillInfo.Size = new System.Drawing.Size(35, 34);
            this.btnShowPanelBillInfo.TabIndex = 17;
            this.btnShowPanelBillInfo.Click += new System.EventHandler(this.btnShowPanelBillInfo_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(839, 2);
            this.panel16.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.panel13.Controls.Add(this.btnDelCurrentBill);
            this.panel13.Controls.Add(this.btnEditCurrentBill);
            this.panel13.Controls.Add(this.btnSaveCurrentBill);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 767);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel13.Size = new System.Drawing.Size(839, 58);
            this.panel13.TabIndex = 0;
            // 
            // btnDelCurrentBill
            // 
            this.btnDelCurrentBill.Animated = true;
            this.btnDelCurrentBill.BorderRadius = 5;
            this.btnDelCurrentBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnDelCurrentBill.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnDelCurrentBill.Location = new System.Drawing.Point(20, 7);
            this.btnDelCurrentBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelCurrentBill.Name = "btnDelCurrentBill";
            this.btnDelCurrentBill.Size = new System.Drawing.Size(165, 48);
            this.btnDelCurrentBill.TabIndex = 2;
            this.btnDelCurrentBill.Text = "تفريغ الفاتورة";
            this.btnDelCurrentBill.Click += new System.EventHandler(this.btnDelCurrentBill_Click);
            // 
            // btnEditCurrentBill
            // 
            this.btnEditCurrentBill.Animated = true;
            this.btnEditCurrentBill.BorderRadius = 5;
            this.btnEditCurrentBill.Enabled = false;
            this.btnEditCurrentBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.btnEditCurrentBill.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnEditCurrentBill.Location = new System.Drawing.Point(205, 7);
            this.btnEditCurrentBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCurrentBill.Name = "btnEditCurrentBill";
            this.btnEditCurrentBill.Size = new System.Drawing.Size(165, 48);
            this.btnEditCurrentBill.TabIndex = 1;
            this.btnEditCurrentBill.Text = "تعديل ";
            this.btnEditCurrentBill.Click += new System.EventHandler(this.btnEditCurrentBill_Click);
            // 
            // btnSaveCurrentBill
            // 
            this.btnSaveCurrentBill.Animated = true;
            this.btnSaveCurrentBill.BorderRadius = 5;
            this.btnSaveCurrentBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveCurrentBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveCurrentBill.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCurrentBill.ForeColor = System.Drawing.Color.White;
            this.btnSaveCurrentBill.Location = new System.Drawing.Point(551, 5);
            this.btnSaveCurrentBill.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.btnSaveCurrentBill.Name = "btnSaveCurrentBill";
            this.btnSaveCurrentBill.Size = new System.Drawing.Size(268, 48);
            this.btnSaveCurrentBill.TabIndex = 0;
            this.btnSaveCurrentBill.Text = "حفظ الفاتورة";
            this.btnSaveCurrentBill.Click += new System.EventHandler(this.btnSaveCurrentBill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panelNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 825);
            this.panel1.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 50);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(926, 775);
            this.panelContainer.TabIndex = 1;
            // 
            // panelNavigator
            // 
            this.panelNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.panelNavigator.Controls.Add(this.btnBillsArchive);
            this.panelNavigator.Controls.Add(this.btnCategoriesItems);
            this.panelNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigator.Location = new System.Drawing.Point(0, 0);
            this.panelNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Padding = new System.Windows.Forms.Padding(5, 5, 11, 5);
            this.panelNavigator.Size = new System.Drawing.Size(926, 50);
            this.panelNavigator.TabIndex = 0;
            // 
            // btnBillsArchive
            // 
            this.btnBillsArchive.Animated = true;
            this.btnBillsArchive.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBillsArchive.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btnBillsArchive.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnBillsArchive.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnBillsArchive.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnBillsArchive.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBillsArchive.FillColor = System.Drawing.Color.Transparent;
            this.btnBillsArchive.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillsArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btnBillsArchive.Location = new System.Drawing.Point(516, 5);
            this.btnBillsArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillsArchive.Name = "btnBillsArchive";
            this.btnBillsArchive.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnBillsArchive.Size = new System.Drawing.Size(200, 40);
            this.btnBillsArchive.TabIndex = 3;
            this.btnBillsArchive.Text = "أرشيف الفواتير";
            this.btnBillsArchive.Click += new System.EventHandler(this.btnBillsArchive_Click);
            // 
            // btnCategoriesItems
            // 
            this.btnCategoriesItems.Animated = true;
            this.btnCategoriesItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategoriesItems.Checked = true;
            this.btnCategoriesItems.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btnCategoriesItems.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCategoriesItems.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCategoriesItems.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnCategoriesItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCategoriesItems.FillColor = System.Drawing.Color.Transparent;
            this.btnCategoriesItems.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriesItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.btnCategoriesItems.Location = new System.Drawing.Point(716, 5);
            this.btnCategoriesItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoriesItems.Name = "btnCategoriesItems";
            this.btnCategoriesItems.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnCategoriesItems.Size = new System.Drawing.Size(199, 40);
            this.btnCategoriesItems.TabIndex = 2;
            this.btnCategoriesItems.Text = "القوائم و المنتجات";
            this.btnCategoriesItems.Click += new System.EventHandler(this.btnCategoriesItems_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelItemsInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(1765, 825);
            this.Load += new System.EventHandler(this.UC_Bill_Load);
            this.panelItemsInfo.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.panelBillHint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panelBillInfo.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItemsInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel13;
        private Guna.UI2.WinForms.Guna2Button btnEditCurrentBill;
        private Guna.UI2.WinForms.Guna2Button btnSaveCurrentBill;
        private System.Windows.Forms.Panel panelBillInfo;
        private System.Windows.Forms.Panel panel17;
        private Guna.UI2.WinForms.Guna2Button btnShowPanelBillInfo;
        private System.Windows.Forms.Panel panel16;
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
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2TextBox txtItemSearch;
        private Guna.UI2.WinForms.Guna2Button btnNewClient;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panelBillHint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillInfo;
        private System.Windows.Forms.Panel panelNavigator;
        private Guna.UI2.WinForms.Guna2Button btnBillsArchive;
        private Guna.UI2.WinForms.Guna2Button btnCategoriesItems;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnDelCurrentBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private Guna.UI2.WinForms.Guna2ComboBox cbxclients;
        private Guna.UI2.WinForms.Guna2CustomCheckBox tglBigUnit;
        private System.Windows.Forms.Label label1;
    }
}
