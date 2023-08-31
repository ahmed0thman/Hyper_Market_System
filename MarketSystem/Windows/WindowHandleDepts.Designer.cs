namespace MarketSystem.Windows
{
    partial class WindowHandleDepts
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowHandleDepts));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblPersonName = new Guna.UI2.WinForms.Guna2TileButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbxOperationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelAlarmInfo = new System.Windows.Forms.Panel();
            this.dtDeptAlarm = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tglAlarm = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.trPanelAlarmInfo = new Guna.UI2.WinForms.Guna2Transition();
            this.btnSaveDeptInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelHeader.SuspendLayout();
            this.panelAlarmInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // lblPersonName
            // 
            this.lblPersonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonName.Animated = true;
            this.lblPersonName.CheckedState.Parent = this.lblPersonName;
            this.lblPersonName.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.lblPersonName.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.lblPersonName.CustomImages.Parent = this.lblPersonName;
            this.trPanelAlarmInfo.SetDecoration(this.lblPersonName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPersonName.Enabled = false;
            this.lblPersonName.FillColor = System.Drawing.Color.Transparent;
            this.lblPersonName.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.lblPersonName.HoverState.Parent = this.lblPersonName;
            this.lblPersonName.Location = new System.Drawing.Point(425, 35);
            this.lblPersonName.Margin = new System.Windows.Forms.Padding(2);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.PressedColor = System.Drawing.Color.White;
            this.lblPersonName.PressedDepth = 10;
            this.lblPersonName.ShadowDecoration.Parent = this.lblPersonName;
            this.lblPersonName.Size = new System.Drawing.Size(220, 39);
            this.lblPersonName.TabIndex = 2;
            this.lblPersonName.Text = "مصطفى احمد سعيد";
            this.lblPersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.panelHeader.Controls.Add(this.guna2ControlBox1);
            this.panelHeader.Controls.Add(this.btnClose);
            this.trPanelAlarmInfo.SetDecoration(this.panelHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(649, 30);
            this.panelHeader.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.trPanelAlarmInfo.SetDecoration(this.guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(579, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(34, 30);
            this.guna2ControlBox1.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnClose.BorderRadius = 7;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.trPanelAlarmInfo.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(613, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnClose.PressedDepth = 10;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.TabIndex = 29;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxOperationType
            // 
            this.cbxOperationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOperationType.BackColor = System.Drawing.Color.Transparent;
            this.cbxOperationType.BorderRadius = 5;
            this.trPanelAlarmInfo.SetDecoration(this.cbxOperationType, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cbxOperationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOperationType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxOperationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxOperationType.FocusedState.Parent = this.cbxOperationType;
            this.cbxOperationType.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxOperationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxOperationType.HoverState.Parent = this.cbxOperationType;
            this.cbxOperationType.ItemHeight = 30;
            this.cbxOperationType.Items.AddRange(new object[] {
            "اضافة سلفة",
            "تسديد سلفة",
            "خصم"});
            this.cbxOperationType.ItemsAppearance.Parent = this.cbxOperationType;
            this.cbxOperationType.Location = new System.Drawing.Point(330, 124);
            this.cbxOperationType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOperationType.Name = "cbxOperationType";
            this.cbxOperationType.ShadowDecoration.Parent = this.cbxOperationType;
            this.cbxOperationType.Size = new System.Drawing.Size(172, 36);
            this.cbxOperationType.StartIndex = 0;
            this.cbxOperationType.TabIndex = 76;
            this.cbxOperationType.SelectedIndexChanged += new System.EventHandler(this.cbxOperationType_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trPanelAlarmInfo.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label17.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(380, 97);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(120, 24);
            this.label17.TabIndex = 75;
            this.label17.Text = "نوع العملية";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trPanelAlarmInfo.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(518, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "المبلغ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BorderRadius = 5;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelAlarmInfo.SetDecoration(this.txtPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(518, 124);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(119, 36);
            this.txtPrice.TabIndex = 73;
            // 
            // panelAlarmInfo
            // 
            this.panelAlarmInfo.Controls.Add(this.dtDeptAlarm);
            this.panelAlarmInfo.Controls.Add(this.label1);
            this.panelAlarmInfo.Controls.Add(this.tglAlarm);
            this.trPanelAlarmInfo.SetDecoration(this.panelAlarmInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAlarmInfo.Location = new System.Drawing.Point(11, 79);
            this.panelAlarmInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlarmInfo.Name = "panelAlarmInfo";
            this.panelAlarmInfo.Size = new System.Drawing.Size(308, 101);
            this.panelAlarmInfo.TabIndex = 77;
            // 
            // dtDeptAlarm
            // 
            this.dtDeptAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDeptAlarm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(136)))), ((int)(((byte)(215)))));
            this.dtDeptAlarm.BorderRadius = 10;
            this.dtDeptAlarm.BorderThickness = 2;
            this.dtDeptAlarm.CheckedState.Parent = this.dtDeptAlarm;
            this.trPanelAlarmInfo.SetDecoration(this.dtDeptAlarm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtDeptAlarm.FillColor = System.Drawing.Color.Transparent;
            this.dtDeptAlarm.Font = new System.Drawing.Font("Verdana", 9F);
            this.dtDeptAlarm.ForeColor = System.Drawing.Color.Black;
            this.dtDeptAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDeptAlarm.HoverState.Parent = this.dtDeptAlarm;
            this.dtDeptAlarm.Location = new System.Drawing.Point(14, 64);
            this.dtDeptAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.dtDeptAlarm.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDeptAlarm.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDeptAlarm.Name = "dtDeptAlarm";
            this.dtDeptAlarm.ShadowDecoration.Parent = this.dtDeptAlarm;
            this.dtDeptAlarm.Size = new System.Drawing.Size(258, 25);
            this.dtDeptAlarm.TabIndex = 77;
            this.dtDeptAlarm.Value = new System.DateTime(2020, 11, 11, 20, 42, 51, 176);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trPanelAlarmInfo.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(205, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "اضافة تنبية";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tglAlarm
            // 
            this.tglAlarm.Animated = true;
            this.tglAlarm.Checked = true;
            this.tglAlarm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglAlarm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglAlarm.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglAlarm.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tglAlarm.CheckedState.Parent = this.tglAlarm;
            this.trPanelAlarmInfo.SetDecoration(this.tglAlarm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tglAlarm.Location = new System.Drawing.Point(163, 40);
            this.tglAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.tglAlarm.Name = "tglAlarm";
            this.tglAlarm.ShadowDecoration.Parent = this.tglAlarm;
            this.tglAlarm.Size = new System.Drawing.Size(38, 20);
            this.tglAlarm.TabIndex = 0;
            this.tglAlarm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglAlarm.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglAlarm.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tglAlarm.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tglAlarm.UncheckedState.Parent = this.tglAlarm;
            this.tglAlarm.CheckedChanged += new System.EventHandler(this.tglAlarm_CheckedChanged);
            // 
            // trPanelAlarmInfo
            // 
            this.trPanelAlarmInfo.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.trPanelAlarmInfo.DefaultAnimation = animation2;
            // 
            // btnSaveDeptInfo
            // 
            this.btnSaveDeptInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveDeptInfo.Animated = true;
            this.btnSaveDeptInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnSaveDeptInfo.BorderRadius = 7;
            this.btnSaveDeptInfo.CheckedState.Parent = this.btnSaveDeptInfo;
            this.btnSaveDeptInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDeptInfo.CustomImages.Parent = this.btnSaveDeptInfo;
            this.trPanelAlarmInfo.SetDecoration(this.btnSaveDeptInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSaveDeptInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSaveDeptInfo.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDeptInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveDeptInfo.HoverState.Parent = this.btnSaveDeptInfo;
            this.btnSaveDeptInfo.Location = new System.Drawing.Point(11, 267);
            this.btnSaveDeptInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDeptInfo.Name = "btnSaveDeptInfo";
            this.btnSaveDeptInfo.PressedColor = System.Drawing.Color.White;
            this.btnSaveDeptInfo.PressedDepth = 10;
            this.btnSaveDeptInfo.ShadowDecoration.Parent = this.btnSaveDeptInfo;
            this.btnSaveDeptInfo.Size = new System.Drawing.Size(92, 33);
            this.btnSaveDeptInfo.TabIndex = 78;
            this.btnSaveDeptInfo.Text = "حفظ";
            this.btnSaveDeptInfo.Click += new System.EventHandler(this.btnSaveDeptInfo_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelHeader;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BorderRadius = 7;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trPanelAlarmInfo.SetDecoration(this.txtDetails, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.txtDetails.Location = new System.Drawing.Point(132, 186);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PlaceholderText = "";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.SelectedText = "";
            this.txtDetails.ShadowDecoration.Parent = this.txtDetails;
            this.txtDetails.Size = new System.Drawing.Size(505, 112);
            this.txtDetails.TabIndex = 79;
            this.txtDetails.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // WindowHandleDepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 311);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnSaveDeptInfo);
            this.Controls.Add(this.panelAlarmInfo);
            this.Controls.Add(this.cbxOperationType);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPersonName);
            this.Controls.Add(this.panelHeader);
            this.trPanelAlarmInfo.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WindowHandleDepts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WindowHandleDepts";
            this.Load += new System.EventHandler(this.WindowHandleDepts_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelAlarmInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TileButton lblPersonName;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbxOperationType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Panel panelAlarmInfo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tglAlarm;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDeptAlarm;
        private Guna.UI2.WinForms.Guna2Transition trPanelAlarmInfo;
        private Guna.UI2.WinForms.Guna2Button btnSaveDeptInfo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
    }
}