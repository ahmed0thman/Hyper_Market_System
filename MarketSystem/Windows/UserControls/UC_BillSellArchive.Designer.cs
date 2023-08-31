namespace MarketSystem.Windows.UserControls
{
    partial class UC_BillSellArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BillSellArchive));
            this.panelHandleBillSearch = new System.Windows.Forms.Panel();
            this.txtBillSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBillDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelBillsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHandleBillSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHandleBillSearch
            // 
            this.panelHandleBillSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelHandleBillSearch.Controls.Add(this.txtBillSearch);
            this.panelHandleBillSearch.Controls.Add(this.dtpBillDate);
            this.panelHandleBillSearch.Controls.Add(this.guna2Button1);
            this.panelHandleBillSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandleBillSearch.Location = new System.Drawing.Point(3, 3);
            this.panelHandleBillSearch.Margin = new System.Windows.Forms.Padding(2);
            this.panelHandleBillSearch.Name = "panelHandleBillSearch";
            this.panelHandleBillSearch.Padding = new System.Windows.Forms.Padding(6);
            this.panelHandleBillSearch.Size = new System.Drawing.Size(552, 42);
            this.panelHandleBillSearch.TabIndex = 2;
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
            this.txtBillSearch.Location = new System.Drawing.Point(285, 6);
            this.txtBillSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillSearch.Name = "txtBillSearch";
            this.txtBillSearch.PasswordChar = '\0';
            this.txtBillSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBillSearch.PlaceholderText = "ابحث برقم الفاتورة";
            this.txtBillSearch.SelectedText = "";
            this.txtBillSearch.ShadowDecoration.Parent = this.txtBillSearch;
            this.txtBillSearch.Size = new System.Drawing.Size(219, 28);
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
            this.dtpBillDate.Location = new System.Drawing.Point(8, 5);
            this.dtpBillDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBillDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBillDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.ShadowDecoration.Parent = this.dtpBillDate;
            this.dtpBillDate.Size = new System.Drawing.Size(244, 29);
            this.dtpBillDate.TabIndex = 20;
            this.dtpBillDate.Value = new System.DateTime(2020, 11, 13, 21, 44, 19, 526);
            this.dtpBillDate.ValueChanged += new System.EventHandler(this.dtpBillDate_ValueChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(509, 5);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.guna2Button1.PressedDepth = 10;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(34, 28);
            this.guna2Button1.TabIndex = 19;
            // 
            // panelBillsCards
            // 
            this.panelBillsCards.AutoScroll = true;
            this.panelBillsCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillsCards.Location = new System.Drawing.Point(3, 45);
            this.panelBillsCards.Name = "panelBillsCards";
            this.panelBillsCards.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelBillsCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelBillsCards.Size = new System.Drawing.Size(552, 484);
            this.panelBillsCards.TabIndex = 3;
            // 
            // UC_BillSellArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(107)))), ((int)(((byte)(173)))));
            this.Controls.Add(this.panelBillsCards);
            this.Controls.Add(this.panelHandleBillSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_BillSellArchive";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(558, 532);
            this.Load += new System.EventHandler(this.UC_BillSellArchive_Load);
            this.panelHandleBillSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHandleBillSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtBillSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBillDate;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel panelBillsCards;
    }
}
