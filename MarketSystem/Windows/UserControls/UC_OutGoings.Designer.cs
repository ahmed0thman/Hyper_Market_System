namespace MarketSystem.Windows.UserControls
{
    partial class UC_OutGoings
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OutGoings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAccounts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelWaletEdit = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSaveWalet = new Guna.UI2.WinForms.Guna2Button();
            this.txtWaletBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrentWalet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShowPanelWaletEdit = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalOutgoings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbxTypeFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvBillInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelelteOutgoing = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditOutgoing = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveOutgoing = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelEmpsList = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEmps = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxOutgoingType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtOutgoingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtOutgoing = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelWaletEdit.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).BeginInit();
            this.panelEmpsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxAccounts);
            this.panel1.Controls.Add(this.panelWaletEdit);
            this.panel1.Controls.Add(this.lblCurrentWalet);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnShowPanelWaletEdit);
            this.panel1.Controls.Add(this.txtTotalOutgoings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.guna2DateTimePicker1);
            this.panel1.Controls.Add(this.cbxTypeFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panel1.Controls.Add(this.btnDelelteOutgoing);
            this.panel1.Controls.Add(this.btnEditOutgoing);
            this.panel1.Controls.Add(this.btnSaveOutgoing);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.panelEmpsList);
            this.panel1.Controls.Add(this.cbxOutgoingType);
            this.panel1.Controls.Add(this.txtOutgoingPrice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtOutgoing);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 574);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label9.Location = new System.Drawing.Point(802, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(95, 29);
            this.label9.TabIndex = 67;
            this.label9.Text = "اسم الحساب";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxAccounts
            // 
            this.cbxAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAccounts.BackColor = System.Drawing.Color.Transparent;
            this.cbxAccounts.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxAccounts, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.cbxAccounts.Location = new System.Drawing.Point(564, 348);
            this.cbxAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAccounts.Name = "cbxAccounts";
            this.cbxAccounts.ShadowDecoration.Parent = this.cbxAccounts;
            this.cbxAccounts.Size = new System.Drawing.Size(228, 36);
            this.cbxAccounts.TabIndex = 66;
            this.cbxAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelWaletEdit
            // 
            this.panelWaletEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWaletEdit.BackColor = System.Drawing.Color.Transparent;
            this.panelWaletEdit.Controls.Add(this.btnSaveWalet);
            this.panelWaletEdit.Controls.Add(this.txtWaletBalance);
            this.transition.SetDecoration(this.panelWaletEdit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelWaletEdit.FillColor = System.Drawing.Color.White;
            this.panelWaletEdit.Location = new System.Drawing.Point(517, 2);
            this.panelWaletEdit.Margin = new System.Windows.Forms.Padding(2);
            this.panelWaletEdit.Name = "panelWaletEdit";
            this.panelWaletEdit.ShadowColor = System.Drawing.Color.Black;
            this.panelWaletEdit.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.panelWaletEdit.Size = new System.Drawing.Size(344, 67);
            this.panelWaletEdit.TabIndex = 65;
            // 
            // btnSaveWalet
            // 
            this.btnSaveWalet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveWalet.Animated = true;
            this.btnSaveWalet.BorderRadius = 5;
            this.btnSaveWalet.CheckedState.Parent = this.btnSaveWalet;
            this.btnSaveWalet.CustomImages.Parent = this.btnSaveWalet;
            this.transition.SetDecoration(this.btnSaveWalet, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSaveWalet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveWalet.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWalet.ForeColor = System.Drawing.Color.White;
            this.btnSaveWalet.HoverState.Parent = this.btnSaveWalet;
            this.btnSaveWalet.Location = new System.Drawing.Point(8, 18);
            this.btnSaveWalet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveWalet.Name = "btnSaveWalet";
            this.btnSaveWalet.ShadowDecoration.Parent = this.btnSaveWalet;
            this.btnSaveWalet.Size = new System.Drawing.Size(68, 28);
            this.btnSaveWalet.TabIndex = 51;
            this.btnSaveWalet.Text = "حفظ";
            this.btnSaveWalet.Click += new System.EventHandler(this.btnSaveWalet_Click);
            // 
            // txtWaletBalance
            // 
            this.txtWaletBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtWaletBalance.BorderRadius = 7;
            this.txtWaletBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtWaletBalance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtWaletBalance.DefaultText = "";
            this.txtWaletBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWaletBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWaletBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWaletBalance.DisabledState.Parent = this.txtWaletBalance;
            this.txtWaletBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWaletBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWaletBalance.FocusedState.Parent = this.txtWaletBalance;
            this.txtWaletBalance.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaletBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWaletBalance.HoverState.Parent = this.txtWaletBalance;
            this.txtWaletBalance.Location = new System.Drawing.Point(102, 18);
            this.txtWaletBalance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWaletBalance.Name = "txtWaletBalance";
            this.txtWaletBalance.PasswordChar = '\0';
            this.txtWaletBalance.PlaceholderText = "أدخل الرصيد الحالى";
            this.txtWaletBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWaletBalance.SelectedText = "";
            this.txtWaletBalance.ShadowDecoration.Parent = this.txtWaletBalance;
            this.txtWaletBalance.Size = new System.Drawing.Size(216, 28);
            this.txtWaletBalance.TabIndex = 46;
            this.txtWaletBalance.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // lblCurrentWalet
            // 
            this.lblCurrentWalet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.lblCurrentWalet, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCurrentWalet.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWalet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblCurrentWalet.Location = new System.Drawing.Point(557, 11);
            this.lblCurrentWalet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentWalet.Name = "lblCurrentWalet";
            this.lblCurrentWalet.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblCurrentWalet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentWalet.Size = new System.Drawing.Size(194, 29);
            this.lblCurrentWalet.TabIndex = 64;
            this.lblCurrentWalet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(755, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(100, 29);
            this.label7.TabIndex = 63;
            this.label7.Text = "رصيد الدرج";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowPanelWaletEdit
            // 
            this.btnShowPanelWaletEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPanelWaletEdit.Animated = true;
            this.btnShowPanelWaletEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnShowPanelWaletEdit.BorderRadius = 7;
            this.btnShowPanelWaletEdit.CheckedState.Parent = this.btnShowPanelWaletEdit;
            this.btnShowPanelWaletEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPanelWaletEdit.CustomImages.Parent = this.btnShowPanelWaletEdit;
            this.transition.SetDecoration(this.btnShowPanelWaletEdit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShowPanelWaletEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnShowPanelWaletEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPanelWaletEdit.ForeColor = System.Drawing.Color.White;
            this.btnShowPanelWaletEdit.HoverState.Parent = this.btnShowPanelWaletEdit;
            this.btnShowPanelWaletEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPanelWaletEdit.Image")));
            this.btnShowPanelWaletEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowPanelWaletEdit.Location = new System.Drawing.Point(873, 12);
            this.btnShowPanelWaletEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPanelWaletEdit.Name = "btnShowPanelWaletEdit";
            this.btnShowPanelWaletEdit.PressedColor = System.Drawing.Color.Silver;
            this.btnShowPanelWaletEdit.PressedDepth = 10;
            this.btnShowPanelWaletEdit.ShadowDecoration.Parent = this.btnShowPanelWaletEdit;
            this.btnShowPanelWaletEdit.Size = new System.Drawing.Size(26, 28);
            this.btnShowPanelWaletEdit.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnShowPanelWaletEdit, "اضغط لتعديل رصيد الدرج");
            this.btnShowPanelWaletEdit.Click += new System.EventHandler(this.btnShowPanelWaletEdit_Click);
            // 
            // txtTotalOutgoings
            // 
            this.txtTotalOutgoings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transition.SetDecoration(this.txtTotalOutgoings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtTotalOutgoings.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOutgoings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.txtTotalOutgoings.Location = new System.Drawing.Point(14, 542);
            this.txtTotalOutgoings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTotalOutgoings.Name = "txtTotalOutgoings";
            this.txtTotalOutgoings.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.txtTotalOutgoings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalOutgoings.Size = new System.Drawing.Size(374, 29);
            this.txtTotalOutgoings.TabIndex = 59;
            this.txtTotalOutgoings.Text = "0,0";
            this.txtTotalOutgoings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.transition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(392, 542);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 58;
            this.label4.Text = "اجمالى المصاريف";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2DateTimePicker1.BorderRadius = 7;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.transition.SetDecoration(this.guna2DateTimePicker1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(309, 12);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(227, 29);
            this.guna2DateTimePicker1.TabIndex = 57;
            this.guna2DateTimePicker1.Value = new System.DateTime(2020, 11, 18, 19, 34, 5, 470);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // cbxTypeFilter
            // 
            this.cbxTypeFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTypeFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypeFilter.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxTypeFilter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxTypeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypeFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypeFilter.FocusedState.Parent = this.cbxTypeFilter;
            this.cbxTypeFilter.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxTypeFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTypeFilter.HoverState.Parent = this.cbxTypeFilter;
            this.cbxTypeFilter.ItemHeight = 30;
            this.cbxTypeFilter.Items.AddRange(new object[] {
            "دفع راتب",
            "دفع ايجار",
            "كهربا",
            "مياة",
            "غاز",
            "صيانة",
            "أخرى"});
            this.cbxTypeFilter.ItemsAppearance.Parent = this.cbxTypeFilter;
            this.cbxTypeFilter.Location = new System.Drawing.Point(12, 6);
            this.cbxTypeFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTypeFilter.Name = "cbxTypeFilter";
            this.cbxTypeFilter.ShadowDecoration.Parent = this.cbxTypeFilter;
            this.cbxTypeFilter.Size = new System.Drawing.Size(107, 36);
            this.cbxTypeFilter.StartIndex = 0;
            this.cbxTypeFilter.TabIndex = 56;
            this.cbxTypeFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxTypeFilter.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(125, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "نوع المصروف";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.dgvBillInfo);
            this.transition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.guna2Panel1.Location = new System.Drawing.Point(2, 46);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(534, 488);
            this.guna2Panel1.TabIndex = 54;
            // 
            // dgvBillInfo
            // 
            this.dgvBillInfo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillInfo.ColumnHeadersHeight = 34;
            this.dgvBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDate,
            this.colType,
            this.colPrice,
            this.colAccount,
            this.colDetails});
            this.transition.SetDecoration(this.dgvBillInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillInfo.EnableHeadersVisualStyles = false;
            this.dgvBillInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillInfo.Location = new System.Drawing.Point(11, 12);
            this.dgvBillInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBillInfo.Name = "dgvBillInfo";
            this.dgvBillInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBillInfo.RowHeadersVisible = false;
            this.dgvBillInfo.RowHeadersWidth = 51;
            this.dgvBillInfo.RowTemplate.Height = 24;
            this.dgvBillInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillInfo.Size = new System.Drawing.Size(512, 464);
            this.dgvBillInfo.TabIndex = 54;
            this.dgvBillInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.dgvBillInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillInfo.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvBillInfo.ThemeStyle.ReadOnly = false;
            this.dgvBillInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBillInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBillInfo.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBillInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.dgvBillInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillInfo_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Column1";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDate.DataPropertyName = "_date";
            this.colDate.FillWeight = 200F;
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDate.Width = 200;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.FillWeight = 50F;
            this.colType.HeaderText = "نوع المصروف";
            this.colType.MinimumWidth = 100;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrice.DataPropertyName = "price";
            this.colPrice.FillWeight = 50F;
            this.colPrice.HeaderText = "المبلغ";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrice.Width = 125;
            // 
            // colAccount
            // 
            this.colAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAccount.DataPropertyName = "account";
            this.colAccount.FillWeight = 500F;
            this.colAccount.HeaderText = "الحساب";
            this.colAccount.Name = "colAccount";
            // 
            // colDetails
            // 
            this.colDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDetails.DataPropertyName = "descripion";
            this.colDetails.HeaderText = "الوصف";
            this.colDetails.MinimumWidth = 6;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            this.colDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDetails.Width = 200;
            // 
            // btnDelelteOutgoing
            // 
            this.btnDelelteOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelelteOutgoing.Animated = true;
            this.btnDelelteOutgoing.BorderRadius = 5;
            this.btnDelelteOutgoing.CheckedState.Parent = this.btnDelelteOutgoing;
            this.btnDelelteOutgoing.CustomImages.Parent = this.btnDelelteOutgoing;
            this.transition.SetDecoration(this.btnDelelteOutgoing, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDelelteOutgoing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnDelelteOutgoing.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelelteOutgoing.ForeColor = System.Drawing.Color.White;
            this.btnDelelteOutgoing.HoverState.Parent = this.btnDelelteOutgoing;
            this.btnDelelteOutgoing.Location = new System.Drawing.Point(597, 513);
            this.btnDelelteOutgoing.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelelteOutgoing.Name = "btnDelelteOutgoing";
            this.btnDelelteOutgoing.ShadowDecoration.Parent = this.btnDelelteOutgoing;
            this.btnDelelteOutgoing.Size = new System.Drawing.Size(84, 35);
            this.btnDelelteOutgoing.TabIndex = 52;
            this.btnDelelteOutgoing.Text = "حذف";
            this.btnDelelteOutgoing.Click += new System.EventHandler(this.btnDelelteOutgoing_Click);
            // 
            // btnEditOutgoing
            // 
            this.btnEditOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOutgoing.Animated = true;
            this.btnEditOutgoing.BorderRadius = 5;
            this.btnEditOutgoing.CheckedState.Parent = this.btnEditOutgoing;
            this.btnEditOutgoing.CustomImages.Parent = this.btnEditOutgoing;
            this.transition.SetDecoration(this.btnEditOutgoing, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEditOutgoing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(131)))), ((int)(((byte)(166)))));
            this.btnEditOutgoing.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOutgoing.ForeColor = System.Drawing.Color.White;
            this.btnEditOutgoing.HoverState.Parent = this.btnEditOutgoing;
            this.btnEditOutgoing.Location = new System.Drawing.Point(697, 513);
            this.btnEditOutgoing.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditOutgoing.Name = "btnEditOutgoing";
            this.btnEditOutgoing.ShadowDecoration.Parent = this.btnEditOutgoing;
            this.btnEditOutgoing.Size = new System.Drawing.Size(84, 35);
            this.btnEditOutgoing.TabIndex = 51;
            this.btnEditOutgoing.Text = "تعديل";
            this.btnEditOutgoing.Click += new System.EventHandler(this.btnEditOutgoing_Click);
            // 
            // btnSaveOutgoing
            // 
            this.btnSaveOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveOutgoing.Animated = true;
            this.btnSaveOutgoing.BorderRadius = 5;
            this.btnSaveOutgoing.CheckedState.Parent = this.btnSaveOutgoing;
            this.btnSaveOutgoing.CustomImages.Parent = this.btnSaveOutgoing;
            this.transition.SetDecoration(this.btnSaveOutgoing, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSaveOutgoing.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveOutgoing.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOutgoing.ForeColor = System.Drawing.Color.White;
            this.btnSaveOutgoing.HoverState.Parent = this.btnSaveOutgoing;
            this.btnSaveOutgoing.Location = new System.Drawing.Point(798, 513);
            this.btnSaveOutgoing.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveOutgoing.Name = "btnSaveOutgoing";
            this.btnSaveOutgoing.ShadowDecoration.Parent = this.btnSaveOutgoing;
            this.btnSaveOutgoing.Size = new System.Drawing.Size(84, 35);
            this.btnSaveOutgoing.TabIndex = 50;
            this.btnSaveOutgoing.Text = "حفظ";
            this.btnSaveOutgoing.Click += new System.EventHandler(this.btnSaveOutgoing_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(802, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "تفاصيل اخرى";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BorderRadius = 7;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtDetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtDetails.DefaultText = "";
            this.txtDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.DisabledState.Parent = this.txtDetails;
            this.txtDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.FocusedState.Parent = this.txtDetails;
            this.txtDetails.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.HoverState.Parent = this.txtDetails;
            this.txtDetails.Location = new System.Drawing.Point(564, 209);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PlaceholderText = "";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.SelectedText = "";
            this.txtDetails.ShadowDecoration.Parent = this.txtDetails;
            this.txtDetails.Size = new System.Drawing.Size(227, 120);
            this.txtDetails.TabIndex = 48;
            this.txtDetails.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panelEmpsList
            // 
            this.panelEmpsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEmpsList.BackColor = System.Drawing.Color.Transparent;
            this.panelEmpsList.Controls.Add(this.label1);
            this.panelEmpsList.Controls.Add(this.cbxEmps);
            this.transition.SetDecoration(this.panelEmpsList, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelEmpsList.FillColor = System.Drawing.Color.White;
            this.panelEmpsList.Location = new System.Drawing.Point(548, 405);
            this.panelEmpsList.Margin = new System.Windows.Forms.Padding(2);
            this.panelEmpsList.Name = "panelEmpsList";
            this.panelEmpsList.ShadowColor = System.Drawing.Color.Black;
            this.panelEmpsList.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.panelEmpsList.Size = new System.Drawing.Size(344, 81);
            this.panelEmpsList.TabIndex = 47;
            // 
            // label1
            // 
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(253, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 48;
            this.label1.Text = "الموظف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxEmps
            // 
            this.cbxEmps.BackColor = System.Drawing.Color.Transparent;
            this.cbxEmps.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxEmps, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxEmps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEmps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmps.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEmps.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEmps.FocusedState.Parent = this.cbxEmps;
            this.cbxEmps.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxEmps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxEmps.HoverState.Parent = this.cbxEmps;
            this.cbxEmps.ItemHeight = 30;
            this.cbxEmps.ItemsAppearance.Parent = this.cbxEmps;
            this.cbxEmps.Location = new System.Drawing.Point(8, 26);
            this.cbxEmps.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEmps.Name = "cbxEmps";
            this.cbxEmps.ShadowDecoration.Parent = this.cbxEmps;
            this.cbxEmps.Size = new System.Drawing.Size(228, 36);
            this.cbxEmps.TabIndex = 47;
            this.cbxEmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxEmps.SelectedIndexChanged += new System.EventHandler(this.cbxEmps_SelectedIndexChanged);
            // 
            // cbxOutgoingType
            // 
            this.cbxOutgoingType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOutgoingType.BackColor = System.Drawing.Color.Transparent;
            this.cbxOutgoingType.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxOutgoingType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxOutgoingType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxOutgoingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutgoingType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxOutgoingType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxOutgoingType.FocusedState.Parent = this.cbxOutgoingType;
            this.cbxOutgoingType.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxOutgoingType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxOutgoingType.HoverState.Parent = this.cbxOutgoingType;
            this.cbxOutgoingType.ItemHeight = 30;
            this.cbxOutgoingType.Items.AddRange(new object[] {
            "دفع راتب",
            "دفع ايجار",
            "كهربا",
            "مياة",
            "غاز",
            "صيانة",
            "أخرى"});
            this.cbxOutgoingType.ItemsAppearance.Parent = this.cbxOutgoingType;
            this.cbxOutgoingType.Location = new System.Drawing.Point(564, 70);
            this.cbxOutgoingType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOutgoingType.Name = "cbxOutgoingType";
            this.cbxOutgoingType.ShadowDecoration.Parent = this.cbxOutgoingType;
            this.cbxOutgoingType.Size = new System.Drawing.Size(228, 36);
            this.cbxOutgoingType.TabIndex = 46;
            this.cbxOutgoingType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxOutgoingType.SelectedIndexChanged += new System.EventHandler(this.cbxOutgoingType_SelectedIndexChanged);
            // 
            // txtOutgoingPrice
            // 
            this.txtOutgoingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutgoingPrice.BorderRadius = 7;
            this.txtOutgoingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtOutgoingPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtOutgoingPrice.DefaultText = "";
            this.txtOutgoingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOutgoingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOutgoingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutgoingPrice.DisabledState.Parent = this.txtOutgoingPrice;
            this.txtOutgoingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOutgoingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutgoingPrice.FocusedState.Parent = this.txtOutgoingPrice;
            this.txtOutgoingPrice.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutgoingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOutgoingPrice.HoverState.Parent = this.txtOutgoingPrice;
            this.txtOutgoingPrice.Location = new System.Drawing.Point(564, 162);
            this.txtOutgoingPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutgoingPrice.Name = "txtOutgoingPrice";
            this.txtOutgoingPrice.PasswordChar = '\0';
            this.txtOutgoingPrice.PlaceholderText = "";
            this.txtOutgoingPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOutgoingPrice.SelectedText = "";
            this.txtOutgoingPrice.ShadowDecoration.Parent = this.txtOutgoingPrice;
            this.txtOutgoingPrice.Size = new System.Drawing.Size(227, 28);
            this.txtOutgoingPrice.TabIndex = 45;
            this.txtOutgoingPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(802, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "تاريخ العملية";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtOutgoing
            // 
            this.dtOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtOutgoing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtOutgoing.BorderRadius = 7;
            this.dtOutgoing.BorderThickness = 1;
            this.dtOutgoing.CheckedState.Parent = this.dtOutgoing;
            this.transition.SetDecoration(this.dtOutgoing, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtOutgoing.FillColor = System.Drawing.Color.White;
            this.dtOutgoing.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOutgoing.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtOutgoing.HoverState.Parent = this.dtOutgoing;
            this.dtOutgoing.Location = new System.Drawing.Point(564, 116);
            this.dtOutgoing.Margin = new System.Windows.Forms.Padding(2);
            this.dtOutgoing.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutgoing.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutgoing.Name = "dtOutgoing";
            this.dtOutgoing.ShadowDecoration.Parent = this.dtOutgoing;
            this.dtOutgoing.Size = new System.Drawing.Size(227, 29);
            this.dtOutgoing.TabIndex = 43;
            this.dtOutgoing.Value = new System.DateTime(2020, 11, 18, 19, 34, 5, 470);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(802, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "المدفوع";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.transition.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(797, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 40;
            this.label8.Text = "نوع المصروف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transition
            // 
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            // 
            // UC_OutGoings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_OutGoings";
            this.Padding = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.Size = new System.Drawing.Size(956, 622);
            this.Load += new System.EventHandler(this.UC_OutGoings_Load);
            this.panel1.ResumeLayout(false);
            this.panelWaletEdit.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillInfo)).EndInit();
            this.panelEmpsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtOutgoingPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtOutgoing;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelEmpsList;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEmps;
        private Guna.UI2.WinForms.Guna2ComboBox cbxOutgoingType;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
        private Guna.UI2.WinForms.Guna2Button btnDelelteOutgoing;
        private Guna.UI2.WinForms.Guna2Button btnEditOutgoing;
        private Guna.UI2.WinForms.Guna2Button btnSaveOutgoing;
        private System.Windows.Forms.Label txtTotalOutgoings;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTypeFilter;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillInfo;
        private Guna.UI2.WinForms.Guna2Button btnShowPanelWaletEdit;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelWaletEdit;
        private Guna.UI2.WinForms.Guna2Button btnSaveWalet;
        private Guna.UI2.WinForms.Guna2TextBox txtWaletBalance;
        private System.Windows.Forms.Label lblCurrentWalet;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAccounts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
    }
}
