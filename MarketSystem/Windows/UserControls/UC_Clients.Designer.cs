namespace MarketSystem.Windows.UserControls
{
    partial class UC_Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Clients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelClientsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.txtClientSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowUCActs = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowUCMainInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomRadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.panel1.SuspendLayout();
            this.panelNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelClientsCards);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panelNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 608);
            this.panel1.TabIndex = 1;
            // 
            // panelClientsCards
            // 
            this.panelClientsCards.AutoScroll = true;
            this.panelClientsCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientsCards.Location = new System.Drawing.Point(0, 65);
            this.panelClientsCards.Name = "panelClientsCards";
            this.panelClientsCards.Padding = new System.Windows.Forms.Padding(3);
            this.panelClientsCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelClientsCards.Size = new System.Drawing.Size(532, 543);
            this.panelClientsCards.TabIndex = 6;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(532, 65);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panelContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelContainer.Size = new System.Drawing.Size(693, 543);
            this.panelContainer.TabIndex = 5;
            // 
            // panelNavigator
            // 
            this.panelNavigator.Controls.Add(this.label1);
            this.panelNavigator.Controls.Add(this.guna2CustomRadioButton1);
            this.panelNavigator.Controls.Add(this.txtClientSearch);
            this.panelNavigator.Controls.Add(this.btnShowUCActs);
            this.panelNavigator.Controls.Add(this.btnShowUCMainInfo);
            this.panelNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigator.Location = new System.Drawing.Point(0, 0);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Padding = new System.Windows.Forms.Padding(10, 12, 30, 12);
            this.panelNavigator.Size = new System.Drawing.Size(1225, 65);
            this.panelNavigator.TabIndex = 4;
            // 
            // txtClientSearch
            // 
            this.txtClientSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientSearch.BorderRadius = 10;
            this.txtClientSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientSearch.DefaultText = "";
            this.txtClientSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientSearch.DisabledState.Parent = this.txtClientSearch;
            this.txtClientSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientSearch.FocusedState.Parent = this.txtClientSearch;
            this.txtClientSearch.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientSearch.HoverState.Parent = this.txtClientSearch;
            this.txtClientSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtClientSearch.IconRight")));
            this.txtClientSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtClientSearch.Location = new System.Drawing.Point(209, 16);
            this.txtClientSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.PasswordChar = '\0';
            this.txtClientSearch.PlaceholderText = "اسم او رقم العميل";
            this.txtClientSearch.SelectedText = "";
            this.txtClientSearch.ShadowDecoration.Parent = this.txtClientSearch;
            this.txtClientSearch.Size = new System.Drawing.Size(305, 35);
            this.txtClientSearch.TabIndex = 19;
            this.txtClientSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowUCActs
            // 
            this.btnShowUCActs.Animated = true;
            this.btnShowUCActs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowUCActs.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCActs.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCActs.CheckedState.Parent = this.btnShowUCActs;
            this.btnShowUCActs.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowUCActs.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowUCActs.CustomImages.Parent = this.btnShowUCActs;
            this.btnShowUCActs.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowUCActs.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCActs.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUCActs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCActs.HoverState.Parent = this.btnShowUCActs;
            this.btnShowUCActs.Location = new System.Drawing.Point(957, 12);
            this.btnShowUCActs.Name = "btnShowUCActs";
            this.btnShowUCActs.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowUCActs.ShadowDecoration.Parent = this.btnShowUCActs;
            this.btnShowUCActs.Size = new System.Drawing.Size(98, 41);
            this.btnShowUCActs.TabIndex = 1;
            this.btnShowUCActs.Text = "الفواتير";
            this.btnShowUCActs.Click += new System.EventHandler(this.btnShowUCActs_Click);
            // 
            // btnShowUCMainInfo
            // 
            this.btnShowUCMainInfo.Animated = true;
            this.btnShowUCMainInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowUCMainInfo.Checked = true;
            this.btnShowUCMainInfo.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCMainInfo.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.CheckedState.Parent = this.btnShowUCMainInfo;
            this.btnShowUCMainInfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowUCMainInfo.CustomImages.Parent = this.btnShowUCMainInfo;
            this.btnShowUCMainInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowUCMainInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUCMainInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCMainInfo.HoverState.Parent = this.btnShowUCMainInfo;
            this.btnShowUCMainInfo.Location = new System.Drawing.Point(1055, 12);
            this.btnShowUCMainInfo.Name = "btnShowUCMainInfo";
            this.btnShowUCMainInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowUCMainInfo.ShadowDecoration.Parent = this.btnShowUCMainInfo;
            this.btnShowUCMainInfo.Size = new System.Drawing.Size(140, 41);
            this.btnShowUCMainInfo.TabIndex = 0;
            this.btnShowUCMainInfo.Text = "البيانات الاساسية";
            this.btnShowUCMainInfo.Click += new System.EventHandler(this.btnShowUCMainInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "عليهم ديون";
            // 
            // guna2CustomRadioButton1
            // 
            this.guna2CustomRadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton1.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CustomRadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton1.CheckedState.Parent = this.guna2CustomRadioButton1;
            this.guna2CustomRadioButton1.Location = new System.Drawing.Point(166, 25);
            this.guna2CustomRadioButton1.Name = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.ShadowDecoration.Parent = this.guna2CustomRadioButton1;
            this.guna2CustomRadioButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton1.TabIndex = 22;
            this.guna2CustomRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton1.UncheckedState.Parent = this.guna2CustomRadioButton1;
            // 
            // UC_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Clients";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Size = new System.Drawing.Size(1275, 658);
            this.Load += new System.EventHandler(this.UC_Clients_Load);
            this.panel1.ResumeLayout(false);
            this.panelNavigator.ResumeLayout(false);
            this.panelNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelNavigator;
        private Guna.UI2.WinForms.Guna2Button btnShowUCActs;
        private Guna.UI2.WinForms.Guna2Button btnShowUCMainInfo;
        private System.Windows.Forms.FlowLayoutPanel panelClientsCards;
        private Guna.UI2.WinForms.Guna2TextBox txtClientSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton1;
    }
}
