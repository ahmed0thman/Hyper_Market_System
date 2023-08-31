namespace MarketSystem.Windows.UserControls
{
    partial class UC_Machines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Machines));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOperationInfo = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGeneralInfo = new System.Windows.Forms.Panel();
            this.panelOperationInfo = new System.Windows.Forms.Panel();
            this.pnlToAccount = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAccountTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveMachineOperation = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtOperation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelMachine = new System.Windows.Forms.Panel();
            this.btnDeleteMachine = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewMachine = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditMachine = new Guna.UI2.WinForms.Guna2Button();
            this.cbxAccounts = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSaveMachineInfo = new Guna.UI2.WinForms.Guna2Button();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.panelMachineInfo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMachineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationInfo)).BeginInit();
            this.panelGeneralInfo.SuspendLayout();
            this.panelOperationInfo.SuspendLayout();
            this.pnlToAccount.SuspendLayout();
            this.panelMachine.SuspendLayout();
            this.panelMachineInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvOperationInfo);
            this.panel1.Controls.Add(this.panelGeneralInfo);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(29, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Size = new System.Drawing.Size(1441, 645);
            this.panel1.TabIndex = 0;
            // 
            // dgvOperationInfo
            // 
            this.dgvOperationInfo.AllowUserToAddRows = false;
            this.dgvOperationInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOperationInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(124)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperationInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperationInfo.ColumnHeadersHeight = 34;
            this.dgvOperationInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOperationInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDate,
            this.colPrice,
            this.colOperationType,
            this.colDetails});
            this.transition.SetDecoration(this.dgvOperationInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperationInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOperationInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvOperationInfo.Location = new System.Drawing.Point(3, 2);
            this.dgvOperationInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOperationInfo.Name = "dgvOperationInfo";
            this.dgvOperationInfo.ReadOnly = true;
            this.dgvOperationInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOperationInfo.RowHeadersVisible = false;
            this.dgvOperationInfo.RowHeadersWidth = 51;
            this.dgvOperationInfo.RowTemplate.Height = 24;
            this.dgvOperationInfo.Size = new System.Drawing.Size(752, 641);
            this.dgvOperationInfo.TabIndex = 22;
            this.dgvOperationInfo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvOperationInfo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvOperationInfo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOperationInfo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOperationInfo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvOperationInfo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvOperationInfo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOperationInfo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvOperationInfo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(124)))), ((int)(((byte)(202)))));
            this.dgvOperationInfo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOperationInfo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOperationInfo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvOperationInfo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOperationInfo.ThemeStyle.HeaderStyle.Height = 34;
            this.dgvOperationInfo.ThemeStyle.ReadOnly = true;
            this.dgvOperationInfo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvOperationInfo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOperationInfo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvOperationInfo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOperationInfo.ThemeStyle.RowsStyle.Height = 24;
            this.dgvOperationInfo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvOperationInfo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOperationInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperationInfo_CellDoubleClick);
            this.dgvOperationInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvOperationInfo_KeyDown);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "كود";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "_date";
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "المبلغ";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colOperationType
            // 
            this.colOperationType.DataPropertyName = "type";
            this.colOperationType.HeaderText = "نوع العملية";
            this.colOperationType.MinimumWidth = 6;
            this.colOperationType.Name = "colOperationType";
            this.colOperationType.ReadOnly = true;
            // 
            // colDetails
            // 
            this.colDetails.DataPropertyName = "details";
            this.colDetails.HeaderText = "تفاصيل اخري";
            this.colDetails.MinimumWidth = 6;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            // 
            // panelGeneralInfo
            // 
            this.panelGeneralInfo.Controls.Add(this.panelOperationInfo);
            this.panelGeneralInfo.Controls.Add(this.panelMachine);
            this.transition.SetDecoration(this.panelGeneralInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelGeneralInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGeneralInfo.Location = new System.Drawing.Point(755, 2);
            this.panelGeneralInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGeneralInfo.Name = "panelGeneralInfo";
            this.panelGeneralInfo.Size = new System.Drawing.Size(683, 641);
            this.panelGeneralInfo.TabIndex = 1;
            // 
            // panelOperationInfo
            // 
            this.panelOperationInfo.Controls.Add(this.pnlToAccount);
            this.panelOperationInfo.Controls.Add(this.label5);
            this.panelOperationInfo.Controls.Add(this.txtDetails);
            this.panelOperationInfo.Controls.Add(this.panel2);
            this.panelOperationInfo.Controls.Add(this.btnSaveMachineOperation);
            this.panelOperationInfo.Controls.Add(this.label6);
            this.panelOperationInfo.Controls.Add(this.dtOperation);
            this.panelOperationInfo.Controls.Add(this.label4);
            this.panelOperationInfo.Controls.Add(this.cbxType);
            this.panelOperationInfo.Controls.Add(this.label3);
            this.panelOperationInfo.Controls.Add(this.txtPrice);
            this.transition.SetDecoration(this.panelOperationInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelOperationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperationInfo.Location = new System.Drawing.Point(0, 114);
            this.panelOperationInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOperationInfo.Name = "panelOperationInfo";
            this.panelOperationInfo.Size = new System.Drawing.Size(683, 527);
            this.panelOperationInfo.TabIndex = 1;
            // 
            // pnlToAccount
            // 
            this.pnlToAccount.Controls.Add(this.label9);
            this.pnlToAccount.Controls.Add(this.cbxAccountTo);
            this.transition.SetDecoration(this.pnlToAccount, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlToAccount.Location = new System.Drawing.Point(17, 220);
            this.pnlToAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlToAccount.Name = "pnlToAccount";
            this.pnlToAccount.Size = new System.Drawing.Size(305, 123);
            this.pnlToAccount.TabIndex = 71;
            this.pnlToAccount.Visible = false;
            // 
            // label9
            // 
            this.transition.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label9.Location = new System.Drawing.Point(117, 26);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(172, 36);
            this.label9.TabIndex = 69;
            this.label9.Text = "الحساب المحول الية";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxAccountTo
            // 
            this.cbxAccountTo.BackColor = System.Drawing.Color.Transparent;
            this.cbxAccountTo.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxAccountTo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxAccountTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAccountTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccountTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAccountTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAccountTo.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxAccountTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxAccountTo.ItemHeight = 30;
            this.cbxAccountTo.Location = new System.Drawing.Point(12, 66);
            this.cbxAccountTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAccountTo.Name = "cbxAccountTo";
            this.cbxAccountTo.Size = new System.Drawing.Size(269, 36);
            this.cbxAccountTo.TabIndex = 70;
            this.cbxAccountTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.transition.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(543, 347);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(127, 36);
            this.label5.TabIndex = 68;
            this.label5.Text = "تفاصيل اخرى";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetails
            // 
            this.txtDetails.BorderRadius = 7;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtDetails, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtDetails.DefaultText = "";
            this.txtDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.Location = new System.Drawing.Point(33, 388);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PlaceholderText = "";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.SelectedText = "";
            this.txtDetails.Size = new System.Drawing.Size(599, 118);
            this.txtDetails.TabIndex = 67;
            this.txtDetails.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transition.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(15, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 2);
            this.panel2.TabIndex = 66;
            // 
            // btnSaveMachineOperation
            // 
            this.btnSaveMachineOperation.Animated = true;
            this.btnSaveMachineOperation.BorderRadius = 5;
            this.transition.SetDecoration(this.btnSaveMachineOperation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSaveMachineOperation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveMachineOperation.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMachineOperation.ForeColor = System.Drawing.Color.White;
            this.btnSaveMachineOperation.Location = new System.Drawing.Point(33, 22);
            this.btnSaveMachineOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveMachineOperation.Name = "btnSaveMachineOperation";
            this.btnSaveMachineOperation.Size = new System.Drawing.Size(83, 34);
            this.btnSaveMachineOperation.TabIndex = 31;
            this.btnSaveMachineOperation.Text = "حفظ";
            this.toolTip1.SetToolTip(this.btnSaveMachineOperation, "اضغط enter");
            this.btnSaveMachineOperation.Click += new System.EventHandler(this.btnSaveMachineOperation_Click);
            // 
            // label6
            // 
            this.transition.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(544, 149);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(127, 36);
            this.label6.TabIndex = 30;
            this.label6.Text = "تاريخ العملية";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtOperation
            // 
            this.dtOperation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtOperation.BorderRadius = 7;
            this.dtOperation.BorderThickness = 1;
            this.dtOperation.Checked = true;
            this.transition.SetDecoration(this.dtOperation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtOperation.FillColor = System.Drawing.Color.White;
            this.dtOperation.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtOperation.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtOperation.Location = new System.Drawing.Point(331, 198);
            this.dtOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtOperation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOperation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOperation.Name = "dtOperation";
            this.dtOperation.Size = new System.Drawing.Size(303, 36);
            this.dtOperation.TabIndex = 29;
            this.dtOperation.Value = new System.DateTime(2020, 11, 18, 19, 34, 5, 470);
            // 
            // label4
            // 
            this.transition.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(544, 249);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "المبلغ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxType
            // 
            this.cbxType.BackColor = System.Drawing.Color.Transparent;
            this.cbxType.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxType.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxType.ItemHeight = 30;
            this.cbxType.Items.AddRange(new object[] {
            "سحب",
            "ايداع",
            "تحويل"});
            this.cbxType.Location = new System.Drawing.Point(331, 94);
            this.cbxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(303, 36);
            this.cbxType.StartIndex = 0;
            this.cbxType.TabIndex = 25;
            this.cbxType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.transition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(544, 39);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 24;
            this.label3.Text = "نوع العملية";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderRadius = 7;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(331, 289);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(303, 43);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panelMachine
            // 
            this.panelMachine.Controls.Add(this.btnDeleteMachine);
            this.panelMachine.Controls.Add(this.btnNewMachine);
            this.panelMachine.Controls.Add(this.btnEditMachine);
            this.panelMachine.Controls.Add(this.cbxAccounts);
            this.panelMachine.Controls.Add(this.lblCurrentBalance);
            this.panelMachine.Controls.Add(this.label1);
            this.panelMachine.Controls.Add(this.label2);
            this.transition.SetDecoration(this.panelMachine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMachine.Location = new System.Drawing.Point(0, 0);
            this.panelMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMachine.Name = "panelMachine";
            this.panelMachine.Size = new System.Drawing.Size(683, 114);
            this.panelMachine.TabIndex = 0;
            // 
            // btnDeleteMachine
            // 
            this.btnDeleteMachine.Animated = true;
            this.btnDeleteMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeleteMachine.BorderRadius = 7;
            this.btnDeleteMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnDeleteMachine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDeleteMachine.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteMachine.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMachine.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMachine.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMachine.Image")));
            this.btnDeleteMachine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteMachine.Location = new System.Drawing.Point(109, 12);
            this.btnDeleteMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteMachine.Name = "btnDeleteMachine";
            this.btnDeleteMachine.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteMachine.PressedDepth = 10;
            this.btnDeleteMachine.Size = new System.Drawing.Size(40, 39);
            this.btnDeleteMachine.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnDeleteMachine, "حذف البيانات");
            this.btnDeleteMachine.Click += new System.EventHandler(this.btnDeleteMachine_Click);
            // 
            // btnNewMachine
            // 
            this.btnNewMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnNewMachine.BorderRadius = 7;
            this.btnNewMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnNewMachine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNewMachine.FillColor = System.Drawing.Color.Transparent;
            this.btnNewMachine.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMachine.ForeColor = System.Drawing.Color.White;
            this.btnNewMachine.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMachine.Image")));
            this.btnNewMachine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNewMachine.Location = new System.Drawing.Point(19, 12);
            this.btnNewMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewMachine.Name = "btnNewMachine";
            this.btnNewMachine.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnNewMachine.PressedDepth = 10;
            this.btnNewMachine.Size = new System.Drawing.Size(40, 39);
            this.btnNewMachine.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnNewMachine, "حساب جديد");
            this.btnNewMachine.Click += new System.EventHandler(this.btnNewMachine_Click);
            // 
            // btnEditMachine
            // 
            this.btnEditMachine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnEditMachine.BorderRadius = 7;
            this.btnEditMachine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnEditMachine, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEditMachine.FillColor = System.Drawing.Color.Transparent;
            this.btnEditMachine.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMachine.ForeColor = System.Drawing.Color.White;
            this.btnEditMachine.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMachine.Image")));
            this.btnEditMachine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnEditMachine.Location = new System.Drawing.Point(64, 12);
            this.btnEditMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMachine.Name = "btnEditMachine";
            this.btnEditMachine.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnEditMachine.PressedDepth = 10;
            this.btnEditMachine.Size = new System.Drawing.Size(40, 39);
            this.btnEditMachine.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnEditMachine, "تعديل بيانات ");
            this.btnEditMachine.Click += new System.EventHandler(this.btnEditMachine_Click);
            // 
            // cbxAccounts
            // 
            this.cbxAccounts.BackColor = System.Drawing.Color.Transparent;
            this.cbxAccounts.BorderRadius = 7;
            this.transition.SetDecoration(this.cbxAccounts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxAccounts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAccounts.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAccounts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAccounts.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxAccounts.ItemHeight = 30;
            this.cbxAccounts.Location = new System.Drawing.Point(344, 62);
            this.cbxAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxAccounts.Name = "cbxAccounts";
            this.cbxAccounts.Size = new System.Drawing.Size(193, 36);
            this.cbxAccounts.TabIndex = 23;
            this.cbxAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxAccounts_SelectedIndexChanged);
            // 
            // lblCurrentBalance
            // 
            this.transition.SetDecoration(this.lblCurrentBalance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCurrentBalance.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblCurrentBalance.Location = new System.Drawing.Point(19, 62);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblCurrentBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCurrentBalance.Size = new System.Drawing.Size(153, 36);
            this.lblCurrentBalance.TabIndex = 22;
            this.lblCurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(190, 62);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "الرصيد الحالى:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(544, 62);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "اسم الحساب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnSaveMachineInfo
            // 
            this.btnSaveMachineInfo.BorderRadius = 5;
            this.transition.SetDecoration(this.btnSaveMachineInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSaveMachineInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveMachineInfo.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMachineInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveMachineInfo.Location = new System.Drawing.Point(19, 14);
            this.btnSaveMachineInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveMachineInfo.Name = "btnSaveMachineInfo";
            this.btnSaveMachineInfo.Size = new System.Drawing.Size(64, 34);
            this.btnSaveMachineInfo.TabIndex = 32;
            this.btnSaveMachineInfo.Text = "حفظ";
            this.toolTip1.SetToolTip(this.btnSaveMachineInfo, "اضغط enter");
            this.btnSaveMachineInfo.Click += new System.EventHandler(this.btnSaveMachineInfo_Click);
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
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
            animation1.TransparencyCoeff = 1F;
            this.transition.DefaultAnimation = animation1;
            // 
            // panelMachineInfo
            // 
            this.panelMachineInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMachineInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelMachineInfo.Controls.Add(this.label8);
            this.panelMachineInfo.Controls.Add(this.txtMachineName);
            this.panelMachineInfo.Controls.Add(this.label7);
            this.panelMachineInfo.Controls.Add(this.txtCurrentBalance);
            this.panelMachineInfo.Controls.Add(this.btnSaveMachineInfo);
            this.transition.SetDecoration(this.panelMachineInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMachineInfo.FillColor = System.Drawing.Color.White;
            this.panelMachineInfo.Location = new System.Drawing.Point(852, 89);
            this.panelMachineInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMachineInfo.Name = "panelMachineInfo";
            this.panelMachineInfo.ShadowColor = System.Drawing.Color.Black;
            this.panelMachineInfo.ShadowShift = 3;
            this.panelMachineInfo.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.panelMachineInfo.Size = new System.Drawing.Size(332, 185);
            this.panelMachineInfo.TabIndex = 1;
            // 
            // label8
            // 
            this.transition.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(179, 25);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(133, 36);
            this.label8.TabIndex = 36;
            this.label8.Text = "اسم الحساب";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMachineName
            // 
            this.txtMachineName.BorderRadius = 7;
            this.txtMachineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtMachineName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtMachineName.DefaultText = "";
            this.txtMachineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMachineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMachineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMachineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMachineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMachineName.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMachineName.Location = new System.Drawing.Point(19, 74);
            this.txtMachineName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.PasswordChar = '\0';
            this.txtMachineName.PlaceholderText = "";
            this.txtMachineName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMachineName.SelectedText = "";
            this.txtMachineName.Size = new System.Drawing.Size(280, 34);
            this.txtMachineName.TabIndex = 35;
            this.txtMachineName.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label7
            // 
            this.transition.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(179, 130);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(133, 36);
            this.label7.TabIndex = 34;
            this.label7.Text = "الرصيد الحالى";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.BorderRadius = 7;
            this.txtCurrentBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtCurrentBalance, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCurrentBalance.DefaultText = "";
            this.txtCurrentBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentBalance.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentBalance.Location = new System.Drawing.Point(19, 130);
            this.txtCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.PasswordChar = '\0';
            this.txtCurrentBalance.PlaceholderText = "";
            this.txtCurrentBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrentBalance.SelectedText = "";
            this.txtCurrentBalance.Size = new System.Drawing.Size(148, 34);
            this.txtCurrentBalance.TabIndex = 33;
            this.txtCurrentBalance.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // UC_Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panelMachineInfo);
            this.Controls.Add(this.panel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Machines";
            this.Padding = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.Size = new System.Drawing.Size(1499, 705);
            this.Load += new System.EventHandler(this.UC_Machines_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UC_Machines_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperationInfo)).EndInit();
            this.panelGeneralInfo.ResumeLayout(false);
            this.panelOperationInfo.ResumeLayout(false);
            this.pnlToAccount.ResumeLayout(false);
            this.panelMachine.ResumeLayout(false);
            this.panelMachineInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGeneralInfo;
        private System.Windows.Forms.Panel panelMachine;
        private System.Windows.Forms.Panel panelOperationInfo;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAccounts;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtOperation;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbxType;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMachine;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnNewMachine;
        private Guna.UI2.WinForms.Guna2Button btnEditMachine;
        private Guna.UI2.WinForms.Guna2Button btnSaveMachineOperation;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelMachineInfo;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMachineName;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentBalance;
        private Guna.UI2.WinForms.Guna2Button btnSaveMachineInfo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
        private Guna.UI2.WinForms.Guna2DataGridView dgvOperationInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
        private System.Windows.Forms.Panel pnlToAccount;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAccountTo;
    }
}
