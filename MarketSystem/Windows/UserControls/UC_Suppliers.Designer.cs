namespace MarketSystem.Windows.UserControls
{
    partial class UC_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Suppliers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSuppliersCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.tglHasdept = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowUCActs = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowUCMainInfo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panelNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelSuppliersCards);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panelNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1470, 608);
            this.panel1.TabIndex = 2;
            // 
            // panelSuppliersCards
            // 
            this.panelSuppliersCards.AutoScroll = true;
            this.panelSuppliersCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSuppliersCards.Location = new System.Drawing.Point(0, 65);
            this.panelSuppliersCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuppliersCards.Name = "panelSuppliersCards";
            this.panelSuppliersCards.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSuppliersCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelSuppliersCards.Size = new System.Drawing.Size(530, 543);
            this.panelSuppliersCards.TabIndex = 6;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(530, 65);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelContainer.Size = new System.Drawing.Size(940, 543);
            this.panelContainer.TabIndex = 5;
            // 
            // panelNavigator
            // 
            this.panelNavigator.Controls.Add(this.tglHasdept);
            this.panelNavigator.Controls.Add(this.label1);
            this.panelNavigator.Controls.Add(this.txtClientSearch);
            this.panelNavigator.Controls.Add(this.btnShowUCActs);
            this.panelNavigator.Controls.Add(this.btnShowUCMainInfo);
            this.panelNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigator.Location = new System.Drawing.Point(0, 0);
            this.panelNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Padding = new System.Windows.Forms.Padding(11, 12, 29, 12);
            this.panelNavigator.Size = new System.Drawing.Size(1470, 65);
            this.panelNavigator.TabIndex = 4;
            // 
            // tglHasdept
            // 
            this.tglHasdept.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglHasdept.CheckedState.BorderRadius = 2;
            this.tglHasdept.CheckedState.BorderThickness = 0;
            this.tglHasdept.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tglHasdept.Location = new System.Drawing.Point(83, 25);
            this.tglHasdept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tglHasdept.Name = "tglHasdept";
            this.tglHasdept.Size = new System.Drawing.Size(20, 20);
            this.tglHasdept.TabIndex = 27;
            this.tglHasdept.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglHasdept.UncheckedState.BorderRadius = 2;
            this.tglHasdept.UncheckedState.BorderThickness = 0;
            this.tglHasdept.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tglHasdept.CheckedChanged += new System.EventHandler(this.tglHasdept_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = " ديون";
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
            this.txtClientSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientSearch.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtClientSearch.IconRight")));
            this.txtClientSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtClientSearch.Location = new System.Drawing.Point(386, 18);
            this.txtClientSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClientSearch.Name = "txtClientSearch";
            this.txtClientSearch.PasswordChar = '\0';
            this.txtClientSearch.PlaceholderText = "اسم او رقم المورد";
            this.txtClientSearch.SelectedText = "";
            this.txtClientSearch.Size = new System.Drawing.Size(335, 34);
            this.txtClientSearch.TabIndex = 19;
            this.txtClientSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClientSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClientSearch_KeyDown);
            // 
            // btnShowUCActs
            // 
            this.btnShowUCActs.Animated = true;
            this.btnShowUCActs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowUCActs.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCActs.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCActs.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowUCActs.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowUCActs.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowUCActs.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCActs.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUCActs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCActs.Location = new System.Drawing.Point(1114, 12);
            this.btnShowUCActs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowUCActs.Name = "btnShowUCActs";
            this.btnShowUCActs.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowUCActs.Size = new System.Drawing.Size(141, 41);
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
            this.btnShowUCMainInfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowUCMainInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowUCMainInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUCMainInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCMainInfo.Location = new System.Drawing.Point(1255, 12);
            this.btnShowUCMainInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowUCMainInfo.Name = "btnShowUCMainInfo";
            this.btnShowUCMainInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowUCMainInfo.Size = new System.Drawing.Size(186, 41);
            this.btnShowUCMainInfo.TabIndex = 0;
            this.btnShowUCMainInfo.Text = "البيانات الاساسية";
            this.btnShowUCMainInfo.Click += new System.EventHandler(this.btnShowUCMainInfo_Click);
            // 
            // UC_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Suppliers";
            this.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1520, 658);
            this.Load += new System.EventHandler(this.UC_Suppliers_Load);
            this.panel1.ResumeLayout(false);
            this.panelNavigator.ResumeLayout(false);
            this.panelNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelSuppliersCards;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelNavigator;
        private Guna.UI2.WinForms.Guna2TextBox txtClientSearch;
        private Guna.UI2.WinForms.Guna2Button btnShowUCActs;
        private Guna.UI2.WinForms.Guna2Button btnShowUCMainInfo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox tglHasdept;
    }
}
