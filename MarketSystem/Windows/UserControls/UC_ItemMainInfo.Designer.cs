namespace MarketSystem.Windows.UserControls
{
    partial class UC_ItemMainInfo
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ItemMainInfo));
            this.btnSaveItem = new Guna.UI2.WinForms.Guna2Button();
            this.panelExpirationInfo = new System.Windows.Forms.Panel();
            this.panelExpirationAlarm = new System.Windows.Forms.Panel();
            this.txtAlarmDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxDurationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtItemExp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLimitNeed = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSmallNumInBig = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBigSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBigBuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBigUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSmallSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSmallBuyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSmallUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMenuName = new Guna.UI2.WinForms.Guna2TextBox();
            this.bntGenerateCode = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowPanelBillInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxItemMenu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.trPanelExpiration = new Guna.UI2.WinForms.Guna2Transition();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSmallProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBigProfit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtItemQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxStores = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClearControls = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tglAlarmExpiration = new MarketSystem.ToggleButton();
            this.tglIsExpiring = new MarketSystem.ToggleButton();
            this.tglAlarmIndeed = new MarketSystem.ToggleButton();
            this.panelExpirationInfo.SuspendLayout();
            this.panelExpirationAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Animated = true;
            this.btnSaveItem.BorderRadius = 5;
            this.btnSaveItem.CheckedState.Parent = this.btnSaveItem;
            this.btnSaveItem.CustomImages.Parent = this.btnSaveItem;
            this.trPanelExpiration.SetDecoration(this.btnSaveItem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSaveItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(211)))), ((int)(((byte)(33)))));
            this.btnSaveItem.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveItem.ForeColor = System.Drawing.Color.White;
            this.btnSaveItem.HoverState.Parent = this.btnSaveItem;
            this.btnSaveItem.Location = new System.Drawing.Point(2, 2);
            this.btnSaveItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.ShadowDecoration.Parent = this.btnSaveItem;
            this.btnSaveItem.Size = new System.Drawing.Size(61, 32);
            this.btnSaveItem.TabIndex = 18;
            this.btnSaveItem.Text = "حفظ";
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // panelExpirationInfo
            // 
            this.panelExpirationInfo.Controls.Add(this.panelExpirationAlarm);
            this.panelExpirationInfo.Controls.Add(this.tglAlarmExpiration);
            this.panelExpirationInfo.Controls.Add(this.label15);
            this.panelExpirationInfo.Controls.Add(this.label14);
            this.panelExpirationInfo.Controls.Add(this.dtItemExp);
            this.panelExpirationInfo.Controls.Add(this.panel4);
            this.trPanelExpiration.SetDecoration(this.panelExpirationInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelExpirationInfo.Location = new System.Drawing.Point(25, 418);
            this.panelExpirationInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelExpirationInfo.Name = "panelExpirationInfo";
            this.panelExpirationInfo.Size = new System.Drawing.Size(551, 81);
            this.panelExpirationInfo.TabIndex = 87;
            // 
            // panelExpirationAlarm
            // 
            this.panelExpirationAlarm.Controls.Add(this.txtAlarmDuration);
            this.panelExpirationAlarm.Controls.Add(this.cbxDurationType);
            this.panelExpirationAlarm.Controls.Add(this.label16);
            this.trPanelExpiration.SetDecoration(this.panelExpirationAlarm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelExpirationAlarm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelExpirationAlarm.Location = new System.Drawing.Point(0, 2);
            this.panelExpirationAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelExpirationAlarm.Name = "panelExpirationAlarm";
            this.panelExpirationAlarm.Size = new System.Drawing.Size(220, 79);
            this.panelExpirationAlarm.TabIndex = 52;
            // 
            // txtAlarmDuration
            // 
            this.txtAlarmDuration.BorderRadius = 5;
            this.txtAlarmDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtAlarmDuration, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtAlarmDuration.DefaultText = "10";
            this.txtAlarmDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAlarmDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAlarmDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlarmDuration.DisabledState.Parent = this.txtAlarmDuration;
            this.txtAlarmDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAlarmDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlarmDuration.FocusedState.Parent = this.txtAlarmDuration;
            this.txtAlarmDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAlarmDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAlarmDuration.HoverState.Parent = this.txtAlarmDuration;
            this.txtAlarmDuration.Location = new System.Drawing.Point(130, 41);
            this.txtAlarmDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlarmDuration.Name = "txtAlarmDuration";
            this.txtAlarmDuration.PasswordChar = '\0';
            this.txtAlarmDuration.PlaceholderText = "";
            this.txtAlarmDuration.SelectedText = "";
            this.txtAlarmDuration.SelectionStart = 2;
            this.txtAlarmDuration.ShadowDecoration.Parent = this.txtAlarmDuration;
            this.txtAlarmDuration.Size = new System.Drawing.Size(80, 26);
            this.txtAlarmDuration.TabIndex = 0;
            this.txtAlarmDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlarmDuration.Leave += new System.EventHandler(this.txtAlarmDuration_Leave);
            // 
            // cbxDurationType
            // 
            this.cbxDurationType.BackColor = System.Drawing.Color.Transparent;
            this.cbxDurationType.BorderRadius = 5;
            this.trPanelExpiration.SetDecoration(this.cbxDurationType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxDurationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDurationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurationType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDurationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDurationType.FocusedState.Parent = this.cbxDurationType;
            this.cbxDurationType.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDurationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDurationType.HoverState.Parent = this.cbxDurationType;
            this.cbxDurationType.ItemHeight = 30;
            this.cbxDurationType.Items.AddRange(new object[] {
            "يوم",
            "شهر"});
            this.cbxDurationType.ItemsAppearance.Parent = this.cbxDurationType;
            this.cbxDurationType.Location = new System.Drawing.Point(14, 37);
            this.cbxDurationType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDurationType.Name = "cbxDurationType";
            this.cbxDurationType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxDurationType.ShadowDecoration.Parent = this.cbxDurationType;
            this.cbxDurationType.Size = new System.Drawing.Size(100, 36);
            this.cbxDurationType.StartIndex = 0;
            this.cbxDurationType.TabIndex = 1;
            this.cbxDurationType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.trPanelExpiration.SetDecoration(this.label16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label16.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(140, 6);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(75, 24);
            this.label16.TabIndex = 25;
            this.label16.Text = "التنبية قبل!";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.trPanelExpiration.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(224, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(136, 24);
            this.label15.TabIndex = 50;
            this.label15.Text = "تنبية عند انتهاء الصلاحية!";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.trPanelExpiration.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(455, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 47;
            this.label14.Text = "تاريخ الانتهاء";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtItemExp
            // 
            this.dtItemExp.BorderColor = System.Drawing.Color.LightGray;
            this.dtItemExp.BorderRadius = 5;
            this.dtItemExp.BorderThickness = 1;
            this.dtItemExp.CheckedState.Parent = this.dtItemExp;
            this.trPanelExpiration.SetDecoration(this.dtItemExp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtItemExp.FillColor = System.Drawing.Color.White;
            this.dtItemExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtItemExp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtItemExp.HoverState.Parent = this.dtItemExp;
            this.dtItemExp.Location = new System.Drawing.Point(368, 40);
            this.dtItemExp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtItemExp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtItemExp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtItemExp.Name = "dtItemExp";
            this.dtItemExp.ShadowDecoration.Parent = this.dtItemExp;
            this.dtItemExp.Size = new System.Drawing.Size(178, 29);
            this.dtItemExp.TabIndex = 0;
            this.dtItemExp.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trPanelExpiration.SetDecoration(this.panel4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(551, 2);
            this.panel4.TabIndex = 43;
            // 
            // label13
            // 
            this.trPanelExpiration.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(15, 345);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 85;
            this.label13.Text = "لة تاريخ صلاحية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.trPanelExpiration.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(109, 345);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 83;
            this.label12.Text = "تنبية عند الاحتياج!";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.trPanelExpiration.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(319, 348);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 82;
            this.label11.Text = "حد الاحتياج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLimitNeed
            // 
            this.txtLimitNeed.BorderRadius = 5;
            this.txtLimitNeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtLimitNeed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLimitNeed.DefaultText = "";
            this.txtLimitNeed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLimitNeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLimitNeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLimitNeed.DisabledState.Parent = this.txtLimitNeed;
            this.txtLimitNeed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLimitNeed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLimitNeed.FocusedState.Parent = this.txtLimitNeed;
            this.txtLimitNeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLimitNeed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLimitNeed.HoverState.Parent = this.txtLimitNeed;
            this.txtLimitNeed.Location = new System.Drawing.Point(319, 378);
            this.txtLimitNeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLimitNeed.Name = "txtLimitNeed";
            this.txtLimitNeed.PasswordChar = '\0';
            this.txtLimitNeed.PlaceholderText = "";
            this.txtLimitNeed.SelectedText = "";
            this.txtLimitNeed.ShadowDecoration.Parent = this.txtLimitNeed;
            this.txtLimitNeed.Size = new System.Drawing.Size(80, 26);
            this.txtLimitNeed.TabIndex = 14;
            // 
            // label10
            // 
            this.trPanelExpiration.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(431, 273);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(142, 24);
            this.label10.TabIndex = 80;
            this.label10.Text = "محتوى الكبرى من الصغرى";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSmallNumInBig
            // 
            this.txtSmallNumInBig.BorderRadius = 5;
            this.txtSmallNumInBig.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtSmallNumInBig, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSmallNumInBig.DefaultText = "";
            this.txtSmallNumInBig.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSmallNumInBig.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSmallNumInBig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallNumInBig.DisabledState.Parent = this.txtSmallNumInBig;
            this.txtSmallNumInBig.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallNumInBig.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallNumInBig.FocusedState.Parent = this.txtSmallNumInBig;
            this.txtSmallNumInBig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSmallNumInBig.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallNumInBig.HoverState.Parent = this.txtSmallNumInBig;
            this.txtSmallNumInBig.Location = new System.Drawing.Point(409, 300);
            this.txtSmallNumInBig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSmallNumInBig.Name = "txtSmallNumInBig";
            this.txtSmallNumInBig.PasswordChar = '\0';
            this.txtSmallNumInBig.PlaceholderText = "";
            this.txtSmallNumInBig.SelectedText = "";
            this.txtSmallNumInBig.ShadowDecoration.Parent = this.txtSmallNumInBig;
            this.txtSmallNumInBig.Size = new System.Drawing.Size(160, 26);
            this.txtSmallNumInBig.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trPanelExpiration.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(25, 338);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 2);
            this.panel2.TabIndex = 78;
            // 
            // label7
            // 
            this.trPanelExpiration.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(128, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(75, 24);
            this.label7.TabIndex = 77;
            this.label7.Text = "سعر البيع";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.trPanelExpiration.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(310, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 76;
            this.label8.Text = "سعر الشراء";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBigSellPrice
            // 
            this.txtBigSellPrice.BorderRadius = 5;
            this.txtBigSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtBigSellPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBigSellPrice.DefaultText = "";
            this.txtBigSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBigSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBigSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigSellPrice.DisabledState.Parent = this.txtBigSellPrice;
            this.txtBigSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigSellPrice.FocusedState.Parent = this.txtBigSellPrice;
            this.txtBigSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBigSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigSellPrice.HoverState.Parent = this.txtBigSellPrice;
            this.txtBigSellPrice.Location = new System.Drawing.Point(44, 235);
            this.txtBigSellPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBigSellPrice.Name = "txtBigSellPrice";
            this.txtBigSellPrice.PasswordChar = '\0';
            this.txtBigSellPrice.PlaceholderText = "";
            this.txtBigSellPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBigSellPrice.SelectedText = "";
            this.txtBigSellPrice.ShadowDecoration.Parent = this.txtBigSellPrice;
            this.txtBigSellPrice.Size = new System.Drawing.Size(155, 26);
            this.txtBigSellPrice.TabIndex = 9;
            this.txtBigSellPrice.TextChanged += new System.EventHandler(this.txtBigSellPrice_TextChanged);
            // 
            // txtBigBuyPrice
            // 
            this.txtBigBuyPrice.BorderRadius = 5;
            this.txtBigBuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtBigBuyPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBigBuyPrice.DefaultText = "";
            this.txtBigBuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBigBuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBigBuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigBuyPrice.DisabledState.Parent = this.txtBigBuyPrice;
            this.txtBigBuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigBuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigBuyPrice.FocusedState.Parent = this.txtBigBuyPrice;
            this.txtBigBuyPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBigBuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigBuyPrice.HoverState.Parent = this.txtBigBuyPrice;
            this.txtBigBuyPrice.Location = new System.Drawing.Point(226, 235);
            this.txtBigBuyPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBigBuyPrice.Name = "txtBigBuyPrice";
            this.txtBigBuyPrice.PasswordChar = '\0';
            this.txtBigBuyPrice.PlaceholderText = "";
            this.txtBigBuyPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBigBuyPrice.SelectedText = "";
            this.txtBigBuyPrice.ShadowDecoration.Parent = this.txtBigBuyPrice;
            this.txtBigBuyPrice.Size = new System.Drawing.Size(154, 26);
            this.txtBigBuyPrice.TabIndex = 8;
            this.txtBigBuyPrice.TextChanged += new System.EventHandler(this.txtBigBuyPrice_TextChanged);
            // 
            // label9
            // 
            this.trPanelExpiration.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(480, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 73;
            this.label9.Text = "الوحدة الكبرى";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBigUnit
            // 
            this.txtBigUnit.BorderRadius = 5;
            this.txtBigUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtBigUnit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBigUnit.DefaultText = "";
            this.txtBigUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBigUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBigUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigUnit.DisabledState.Parent = this.txtBigUnit;
            this.txtBigUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigUnit.FocusedState.Parent = this.txtBigUnit;
            this.txtBigUnit.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBigUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigUnit.HoverState.Parent = this.txtBigUnit;
            this.txtBigUnit.Location = new System.Drawing.Point(409, 235);
            this.txtBigUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBigUnit.Name = "txtBigUnit";
            this.txtBigUnit.PasswordChar = '\0';
            this.txtBigUnit.PlaceholderText = "";
            this.txtBigUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBigUnit.SelectedText = "";
            this.txtBigUnit.ShadowDecoration.Parent = this.txtBigUnit;
            this.txtBigUnit.Size = new System.Drawing.Size(160, 26);
            this.txtBigUnit.TabIndex = 7;
            // 
            // label6
            // 
            this.trPanelExpiration.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(128, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "سعر البيع";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSmallSellPrice
            // 
            this.txtSmallSellPrice.BorderRadius = 5;
            this.txtSmallSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtSmallSellPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSmallSellPrice.DefaultText = "";
            this.txtSmallSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSmallSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSmallSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallSellPrice.DisabledState.Parent = this.txtSmallSellPrice;
            this.txtSmallSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallSellPrice.FocusedState.Parent = this.txtSmallSellPrice;
            this.txtSmallSellPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSmallSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallSellPrice.HoverState.Parent = this.txtSmallSellPrice;
            this.txtSmallSellPrice.Location = new System.Drawing.Point(44, 176);
            this.txtSmallSellPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSmallSellPrice.Name = "txtSmallSellPrice";
            this.txtSmallSellPrice.PasswordChar = '\0';
            this.txtSmallSellPrice.PlaceholderText = "";
            this.txtSmallSellPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSmallSellPrice.SelectedText = "";
            this.txtSmallSellPrice.ShadowDecoration.Parent = this.txtSmallSellPrice;
            this.txtSmallSellPrice.Size = new System.Drawing.Size(155, 26);
            this.txtSmallSellPrice.TabIndex = 6;
            this.txtSmallSellPrice.TextChanged += new System.EventHandler(this.txtSmallSellPrice_TextChanged);
            // 
            // label5
            // 
            this.trPanelExpiration.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(310, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "سعر الشراء";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSmallBuyPrice
            // 
            this.txtSmallBuyPrice.BorderRadius = 5;
            this.txtSmallBuyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtSmallBuyPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSmallBuyPrice.DefaultText = "";
            this.txtSmallBuyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSmallBuyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSmallBuyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallBuyPrice.DisabledState.Parent = this.txtSmallBuyPrice;
            this.txtSmallBuyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallBuyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallBuyPrice.FocusedState.Parent = this.txtSmallBuyPrice;
            this.txtSmallBuyPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSmallBuyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallBuyPrice.HoverState.Parent = this.txtSmallBuyPrice;
            this.txtSmallBuyPrice.Location = new System.Drawing.Point(226, 176);
            this.txtSmallBuyPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSmallBuyPrice.Name = "txtSmallBuyPrice";
            this.txtSmallBuyPrice.PasswordChar = '\0';
            this.txtSmallBuyPrice.PlaceholderText = "";
            this.txtSmallBuyPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSmallBuyPrice.SelectedText = "";
            this.txtSmallBuyPrice.ShadowDecoration.Parent = this.txtSmallBuyPrice;
            this.txtSmallBuyPrice.Size = new System.Drawing.Size(154, 26);
            this.txtSmallBuyPrice.TabIndex = 5;
            this.txtSmallBuyPrice.TextChanged += new System.EventHandler(this.txtSmallBuyPrice_TextChanged);
            // 
            // label4
            // 
            this.trPanelExpiration.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(480, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "الوحدة الصغرى";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSmallUnit
            // 
            this.txtSmallUnit.BorderRadius = 5;
            this.txtSmallUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtSmallUnit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSmallUnit.DefaultText = "";
            this.txtSmallUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSmallUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSmallUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallUnit.DisabledState.Parent = this.txtSmallUnit;
            this.txtSmallUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallUnit.FocusedState.Parent = this.txtSmallUnit;
            this.txtSmallUnit.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmallUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallUnit.HoverState.Parent = this.txtSmallUnit;
            this.txtSmallUnit.Location = new System.Drawing.Point(409, 176);
            this.txtSmallUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSmallUnit.Name = "txtSmallUnit";
            this.txtSmallUnit.PasswordChar = '\0';
            this.txtSmallUnit.PlaceholderText = "";
            this.txtSmallUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSmallUnit.SelectedText = "";
            this.txtSmallUnit.ShadowDecoration.Parent = this.txtSmallUnit;
            this.txtSmallUnit.Size = new System.Drawing.Size(160, 26);
            this.txtSmallUnit.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trPanelExpiration.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(25, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 2);
            this.panel1.TabIndex = 65;
            // 
            // txtMenuName
            // 
            this.txtMenuName.BorderRadius = 5;
            this.txtMenuName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtMenuName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtMenuName.DefaultText = "";
            this.txtMenuName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMenuName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMenuName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMenuName.DisabledState.Parent = this.txtMenuName;
            this.txtMenuName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMenuName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMenuName.FocusedState.Parent = this.txtMenuName;
            this.txtMenuName.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMenuName.HoverState.Parent = this.txtMenuName;
            this.txtMenuName.Location = new System.Drawing.Point(56, 108);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.PasswordChar = '\0';
            this.txtMenuName.PlaceholderText = "";
            this.txtMenuName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMenuName.SelectedText = "";
            this.txtMenuName.ShadowDecoration.Parent = this.txtMenuName;
            this.txtMenuName.Size = new System.Drawing.Size(230, 26);
            this.txtMenuName.TabIndex = 64;
            this.txtMenuName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMenuName_KeyDown);
            // 
            // bntGenerateCode
            // 
            this.bntGenerateCode.Animated = true;
            this.bntGenerateCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.bntGenerateCode.BorderRadius = 7;
            this.bntGenerateCode.CheckedState.Parent = this.bntGenerateCode;
            this.bntGenerateCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGenerateCode.CustomImages.Parent = this.bntGenerateCode;
            this.trPanelExpiration.SetDecoration(this.bntGenerateCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.bntGenerateCode.FillColor = System.Drawing.Color.Transparent;
            this.bntGenerateCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntGenerateCode.ForeColor = System.Drawing.Color.White;
            this.bntGenerateCode.HoverState.Parent = this.bntGenerateCode;
            this.bntGenerateCode.Image = ((System.Drawing.Image)(resources.GetObject("bntGenerateCode.Image")));
            this.bntGenerateCode.Location = new System.Drawing.Point(25, 46);
            this.bntGenerateCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntGenerateCode.Name = "bntGenerateCode";
            this.bntGenerateCode.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.bntGenerateCode.PressedDepth = 10;
            this.bntGenerateCode.ShadowDecoration.Parent = this.bntGenerateCode;
            this.bntGenerateCode.Size = new System.Drawing.Size(26, 28);
            this.bntGenerateCode.TabIndex = 0;
            this.toolTip1.SetToolTip(this.bntGenerateCode, "كود تلقائى للمنتج");
            this.bntGenerateCode.Click += new System.EventHandler(this.bntGenerateCode_Click);
            // 
            // btnShowPanelBillInfo
            // 
            this.btnShowPanelBillInfo.Animated = true;
            this.btnShowPanelBillInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnShowPanelBillInfo.BorderRadius = 7;
            this.btnShowPanelBillInfo.CheckedState.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPanelBillInfo.CustomImages.Parent = this.btnShowPanelBillInfo;
            this.trPanelExpiration.SetDecoration(this.btnShowPanelBillInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShowPanelBillInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowPanelBillInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowPanelBillInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowPanelBillInfo.HoverState.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPanelBillInfo.Image")));
            this.btnShowPanelBillInfo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowPanelBillInfo.Location = new System.Drawing.Point(310, 106);
            this.btnShowPanelBillInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowPanelBillInfo.Name = "btnShowPanelBillInfo";
            this.btnShowPanelBillInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowPanelBillInfo.PressedDepth = 10;
            this.btnShowPanelBillInfo.ShadowDecoration.Parent = this.btnShowPanelBillInfo;
            this.btnShowPanelBillInfo.Size = new System.Drawing.Size(26, 28);
            this.btnShowPanelBillInfo.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnShowPanelBillInfo, "اضافة قائمة جديدة");
            this.btnShowPanelBillInfo.Click += new System.EventHandler(this.btnShowPanelBillInfo_Click);
            // 
            // label3
            // 
            this.trPanelExpiration.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(499, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "القائمة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxItemMenu
            // 
            this.cbxItemMenu.BackColor = System.Drawing.Color.Transparent;
            this.cbxItemMenu.BorderRadius = 5;
            this.trPanelExpiration.SetDecoration(this.cbxItemMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxItemMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxItemMenu.DropDownHeight = 200;
            this.cbxItemMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemMenu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxItemMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxItemMenu.FocusedState.Parent = this.cbxItemMenu;
            this.cbxItemMenu.Font = new System.Drawing.Font("Simplified Arabic", 10.2F);
            this.cbxItemMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxItemMenu.HoverState.Parent = this.cbxItemMenu;
            this.cbxItemMenu.IntegralHeight = false;
            this.cbxItemMenu.ItemHeight = 30;
            this.cbxItemMenu.ItemsAppearance.Parent = this.cbxItemMenu;
            this.cbxItemMenu.Location = new System.Drawing.Point(340, 105);
            this.cbxItemMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxItemMenu.MaxDropDownItems = 3;
            this.cbxItemMenu.MaxLength = 8;
            this.cbxItemMenu.Name = "cbxItemMenu";
            this.cbxItemMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxItemMenu.ShadowDecoration.Parent = this.cbxItemMenu;
            this.cbxItemMenu.Size = new System.Drawing.Size(230, 36);
            this.cbxItemMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.trPanelExpiration.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(214, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "كود المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderRadius = 5;
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtItemCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtItemCode.DefaultText = "";
            this.txtItemCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.DisabledState.Parent = this.txtItemCode;
            this.txtItemCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.FocusedState.Parent = this.txtItemCode;
            this.txtItemCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemCode.HoverState.Parent = this.txtItemCode;
            this.txtItemCode.Location = new System.Drawing.Point(56, 50);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PasswordChar = '\0';
            this.txtItemCode.PlaceholderText = "";
            this.txtItemCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.ShadowDecoration.Parent = this.txtItemCode;
            this.txtItemCode.Size = new System.Drawing.Size(230, 26);
            this.txtItemCode.TabIndex = 1;
            // 
            // label2
            // 
            this.trPanelExpiration.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(499, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "إسم المنتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemName
            // 
            this.txtItemName.BorderRadius = 5;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtItemName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.Parent = this.txtItemName;
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(340, 50);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(230, 26);
            this.txtItemName.TabIndex = 2;
            // 
            // trPanelExpiration
            // 
            this.trPanelExpiration.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.trPanelExpiration.Cursor = null;
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
            this.trPanelExpiration.DefaultAnimation = animation1;
            // 
            // label18
            // 
            this.trPanelExpiration.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label18.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(220, 273);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(165, 24);
            this.label18.TabIndex = 92;
            this.label18.Text = "الربح ف الوحدة الصغرى";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSmallProfit
            // 
            this.txtSmallProfit.BorderRadius = 5;
            this.txtSmallProfit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtSmallProfit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtSmallProfit.DefaultText = "";
            this.txtSmallProfit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSmallProfit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSmallProfit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallProfit.DisabledState.Parent = this.txtSmallProfit;
            this.txtSmallProfit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSmallProfit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallProfit.FocusedState.Parent = this.txtSmallProfit;
            this.txtSmallProfit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSmallProfit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSmallProfit.HoverState.Parent = this.txtSmallProfit;
            this.txtSmallProfit.Location = new System.Drawing.Point(226, 300);
            this.txtSmallProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSmallProfit.Name = "txtSmallProfit";
            this.txtSmallProfit.PasswordChar = '\0';
            this.txtSmallProfit.PlaceholderText = "";
            this.txtSmallProfit.ReadOnly = true;
            this.txtSmallProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSmallProfit.SelectedText = "";
            this.txtSmallProfit.ShadowDecoration.Parent = this.txtSmallProfit;
            this.txtSmallProfit.Size = new System.Drawing.Size(154, 26);
            this.txtSmallProfit.TabIndex = 11;
            // 
            // label19
            // 
            this.trPanelExpiration.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label19.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(31, 273);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label19.Size = new System.Drawing.Size(165, 24);
            this.label19.TabIndex = 94;
            this.label19.Text = "الربح ف الوحدة الكبرى";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBigProfit
            // 
            this.txtBigProfit.BorderRadius = 5;
            this.txtBigProfit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtBigProfit, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBigProfit.DefaultText = "";
            this.txtBigProfit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBigProfit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBigProfit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigProfit.DisabledState.Parent = this.txtBigProfit;
            this.txtBigProfit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBigProfit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigProfit.FocusedState.Parent = this.txtBigProfit;
            this.txtBigProfit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBigProfit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBigProfit.HoverState.Parent = this.txtBigProfit;
            this.txtBigProfit.Location = new System.Drawing.Point(44, 300);
            this.txtBigProfit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBigProfit.Name = "txtBigProfit";
            this.txtBigProfit.PasswordChar = '\0';
            this.txtBigProfit.PlaceholderText = "";
            this.txtBigProfit.ReadOnly = true;
            this.txtBigProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBigProfit.SelectedText = "";
            this.txtBigProfit.ShadowDecoration.Parent = this.txtBigProfit;
            this.txtBigProfit.Size = new System.Drawing.Size(155, 26);
            this.txtBigProfit.TabIndex = 12;
            // 
            // label17
            // 
            this.trPanelExpiration.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(242, 348);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(64, 24);
            this.label17.TabIndex = 90;
            this.label17.Text = "الكمية";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.BorderRadius = 5;
            this.txtItemQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelExpiration.SetDecoration(this.txtItemQuantity, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtItemQuantity.DefaultText = "";
            this.txtItemQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemQuantity.DisabledState.Parent = this.txtItemQuantity;
            this.txtItemQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemQuantity.FocusedState.Parent = this.txtItemQuantity;
            this.txtItemQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtItemQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemQuantity.HoverState.Parent = this.txtItemQuantity;
            this.txtItemQuantity.Location = new System.Drawing.Point(221, 378);
            this.txtItemQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.PasswordChar = '\0';
            this.txtItemQuantity.PlaceholderText = "";
            this.txtItemQuantity.SelectedText = "";
            this.txtItemQuantity.ShadowDecoration.Parent = this.txtItemQuantity;
            this.txtItemQuantity.Size = new System.Drawing.Size(80, 26);
            this.txtItemQuantity.TabIndex = 15;
            // 
            // label20
            // 
            this.trPanelExpiration.SetDecoration(this.label20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(499, 348);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(75, 24);
            this.label20.TabIndex = 96;
            this.label20.Text = "مكان التخزين";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxStores
            // 
            this.cbxStores.BackColor = System.Drawing.Color.Transparent;
            this.cbxStores.BorderRadius = 5;
            this.trPanelExpiration.SetDecoration(this.cbxStores, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxStores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStores.Enabled = false;
            this.cbxStores.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStores.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxStores.FocusedState.Parent = this.cbxStores;
            this.cbxStores.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxStores.HoverState.Parent = this.cbxStores;
            this.cbxStores.ItemHeight = 30;
            this.cbxStores.ItemsAppearance.Parent = this.cbxStores;
            this.cbxStores.Location = new System.Drawing.Point(422, 376);
            this.cbxStores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxStores.Name = "cbxStores";
            this.cbxStores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxStores.ShadowDecoration.Parent = this.cbxStores;
            this.cbxStores.Size = new System.Drawing.Size(149, 36);
            this.cbxStores.TabIndex = 13;
            // 
            // btnClearControls
            // 
            this.btnClearControls.Animated = true;
            this.btnClearControls.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.btnClearControls.BorderRadius = 5;
            this.btnClearControls.BorderThickness = 1;
            this.btnClearControls.CheckedState.Parent = this.btnClearControls;
            this.btnClearControls.CustomImages.Parent = this.btnClearControls;
            this.trPanelExpiration.SetDecoration(this.btnClearControls, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClearControls.FillColor = System.Drawing.Color.Transparent;
            this.btnClearControls.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearControls.ForeColor = System.Drawing.Color.White;
            this.btnClearControls.HoverState.Parent = this.btnClearControls;
            this.btnClearControls.Image = ((System.Drawing.Image)(resources.GetObject("btnClearControls.Image")));
            this.btnClearControls.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClearControls.Location = new System.Drawing.Point(68, 2);
            this.btnClearControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.ShadowDecoration.Parent = this.btnClearControls;
            this.btnClearControls.Size = new System.Drawing.Size(30, 32);
            this.btnClearControls.TabIndex = 97;
            this.toolTip1.SetToolTip(this.btnClearControls, "اضغط لتفريغ الحقول و اضافة حقل جديد");
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            this.btnClearControls.DoubleClick += new System.EventHandler(this.btnClearControls_DoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // tglAlarmExpiration
            // 
            this.tglAlarmExpiration.BackColor = System.Drawing.Color.White;
            this.tglAlarmExpiration.BorderColor = System.Drawing.Color.LightGray;
            this.tglAlarmExpiration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelExpiration.SetDecoration(this.tglAlarmExpiration, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tglAlarmExpiration.ForeColor = System.Drawing.Color.White;
            this.tglAlarmExpiration.IsOn = true;
            this.tglAlarmExpiration.Location = new System.Drawing.Point(315, 41);
            this.tglAlarmExpiration.Margin = new System.Windows.Forms.Padding(2);
            this.tglAlarmExpiration.Name = "tglAlarmExpiration";
            this.tglAlarmExpiration.OffColor = System.Drawing.Color.DarkGray;
            this.tglAlarmExpiration.OffText = "";
            this.tglAlarmExpiration.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglAlarmExpiration.OnText = "";
            this.tglAlarmExpiration.Size = new System.Drawing.Size(44, 24);
            this.tglAlarmExpiration.TabIndex = 1;
            this.tglAlarmExpiration.Text = "toggleButton3";
            this.tglAlarmExpiration.TextEnabled = true;
            this.tglAlarmExpiration.Click += new System.EventHandler(this.tglAlarmExpiration_Click);
            // 
            // tglIsExpiring
            // 
            this.tglIsExpiring.BackColor = System.Drawing.Color.White;
            this.tglIsExpiring.BorderColor = System.Drawing.Color.LightGray;
            this.tglIsExpiring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelExpiration.SetDecoration(this.tglIsExpiring, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tglIsExpiring.ForeColor = System.Drawing.Color.White;
            this.tglIsExpiring.IsOn = true;
            this.tglIsExpiring.Location = new System.Drawing.Point(52, 378);
            this.tglIsExpiring.Margin = new System.Windows.Forms.Padding(2);
            this.tglIsExpiring.Name = "tglIsExpiring";
            this.tglIsExpiring.OffColor = System.Drawing.Color.DarkGray;
            this.tglIsExpiring.OffText = "";
            this.tglIsExpiring.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglIsExpiring.OnText = "";
            this.tglIsExpiring.Size = new System.Drawing.Size(44, 24);
            this.tglIsExpiring.TabIndex = 17;
            this.tglIsExpiring.Text = "toggleButton2";
            this.tglIsExpiring.TextEnabled = true;
            this.tglIsExpiring.Click += new System.EventHandler(this.tglIsExpiring_Click);
            // 
            // tglAlarmIndeed
            // 
            this.tglAlarmIndeed.BackColor = System.Drawing.Color.White;
            this.tglAlarmIndeed.BorderColor = System.Drawing.Color.LightGray;
            this.tglAlarmIndeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trPanelExpiration.SetDecoration(this.tglAlarmIndeed, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tglAlarmIndeed.ForeColor = System.Drawing.Color.White;
            this.tglAlarmIndeed.IsOn = true;
            this.tglAlarmIndeed.Location = new System.Drawing.Point(148, 378);
            this.tglAlarmIndeed.Margin = new System.Windows.Forms.Padding(2);
            this.tglAlarmIndeed.Name = "tglAlarmIndeed";
            this.tglAlarmIndeed.OffColor = System.Drawing.Color.DarkGray;
            this.tglAlarmIndeed.OffText = "";
            this.tglAlarmIndeed.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglAlarmIndeed.OnText = "";
            this.tglAlarmIndeed.Size = new System.Drawing.Size(44, 24);
            this.tglAlarmIndeed.TabIndex = 16;
            this.tglAlarmIndeed.Text = "toggleButton1";
            this.tglAlarmIndeed.TextEnabled = true;
            // 
            // UC_ItemMainInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClearControls);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cbxStores);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtBigProfit);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSmallProfit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.btnSaveItem);
            this.Controls.Add(this.panelExpirationInfo);
            this.Controls.Add(this.tglIsExpiring);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tglAlarmIndeed);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLimitNeed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSmallNumInBig);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBigSellPrice);
            this.Controls.Add(this.txtBigBuyPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBigUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSmallSellPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSmallBuyPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSmallUnit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.bntGenerateCode);
            this.Controls.Add(this.btnShowPanelBillInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxItemMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemName);
            this.trPanelExpiration.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_ItemMainInfo";
            this.Size = new System.Drawing.Size(592, 512);
            this.Load += new System.EventHandler(this.UC_ItemMainInfo_Load);
            this.panelExpirationInfo.ResumeLayout(false);
            this.panelExpirationAlarm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSaveItem;
        private System.Windows.Forms.Panel panelExpirationInfo;
        private System.Windows.Forms.Panel panelExpirationAlarm;
        private Guna.UI2.WinForms.Guna2TextBox txtAlarmDuration;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDurationType;
        private System.Windows.Forms.Label label16;
        private ToggleButton tglAlarmExpiration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtItemExp;
        private System.Windows.Forms.Panel panel4;
        private ToggleButton tglIsExpiring;
        private System.Windows.Forms.Label label13;
        private ToggleButton tglAlarmIndeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtLimitNeed;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtSmallNumInBig;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtBigSellPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtBigBuyPrice;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtBigUnit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtSmallSellPrice;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSmallBuyPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSmallUnit;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMenuName;
        private Guna.UI2.WinForms.Guna2Button bntGenerateCode;
        private Guna.UI2.WinForms.Guna2Button btnShowPanelBillInfo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbxItemMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtItemCode;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2Transition trPanelExpiration;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txtSmallProfit;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtBigProfit;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txtItemQuantity;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2ComboBox cbxStores;
        private Guna.UI2.WinForms.Guna2Button btnClearControls;
    }
}
