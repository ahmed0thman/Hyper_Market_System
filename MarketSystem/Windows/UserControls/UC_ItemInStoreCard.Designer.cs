namespace MarketSystem.Windows.UserControls
{
    partial class UC_ItemInStoreCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ItemInStoreCard));
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblDateExpire = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItemState = new System.Windows.Forms.Label();
            this.picItemState = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEditItemInStore = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItemInStore = new Guna.UI2.WinForms.Guna2Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2ShadowPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lblQuantity);
            this.guna2ShadowPanel2.Controls.Add(this.lblBill);
            this.guna2ShadowPanel2.Controls.Add(this.lblDateExpire);
            this.guna2ShadowPanel2.Controls.Add(this.panel1);
            this.guna2ShadowPanel2.Controls.Add(this.btnEditItemInStore);
            this.guna2ShadowPanel2.Controls.Add(this.btnDeleteItemInStore);
            this.guna2ShadowPanel2.Controls.Add(this.lblItemName);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 3;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel2.ShadowShift = 2;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(834, 54);
            this.guna2ShadowPanel2.TabIndex = 2;
            this.guna2ShadowPanel2.Click += new System.EventHandler(this.guna2ShadowPanel2_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuantity.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(159)))), ((int)(((byte)(97)))));
            this.lblQuantity.Location = new System.Drawing.Point(91, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity.Size = new System.Drawing.Size(55, 54);
            this.lblQuantity.TabIndex = 59;
            this.lblQuantity.Text = "60";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblQuantity, "الكمية");
            this.lblQuantity.Click += new System.EventHandler(this.lblQuantity_Click);
            // 
            // lblBill
            // 
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBill.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.lblBill.Location = new System.Drawing.Point(146, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBill.Size = new System.Drawing.Size(60, 54);
            this.lblBill.TabIndex = 58;
            this.lblBill.Text = "18";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblBill, "الفاتورة الملحقة");
            this.lblBill.Click += new System.EventHandler(this.lblBill_Click);
            // 
            // lblDateExpire
            // 
            this.lblDateExpire.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDateExpire.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateExpire.Location = new System.Drawing.Point(206, 0);
            this.lblDateExpire.Name = "lblDateExpire";
            this.lblDateExpire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateExpire.Size = new System.Drawing.Size(146, 54);
            this.lblDateExpire.TabIndex = 57;
            this.lblDateExpire.Text = "20-12-2020";
            this.lblDateExpire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblDateExpire, "تاريخ انتهاء الصلاحية");
            this.lblDateExpire.Click += new System.EventHandler(this.lblDateExpire_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblItemState);
            this.panel1.Controls.Add(this.picItemState);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(352, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 54);
            this.panel1.TabIndex = 29;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblItemState
            // 
            this.lblItemState.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblItemState.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(211)))), ((int)(((byte)(33)))));
            this.lblItemState.Location = new System.Drawing.Point(0, 0);
            this.lblItemState.Name = "lblItemState";
            this.lblItemState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemState.Size = new System.Drawing.Size(238, 54);
            this.lblItemState.TabIndex = 56;
            this.lblItemState.Text = "جيد الصلاحية";
            this.lblItemState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblItemState, "حالة المنتج");
            this.lblItemState.Click += new System.EventHandler(this.lblItemState_Click);
            // 
            // picItemState
            // 
            this.picItemState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picItemState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(211)))), ((int)(((byte)(33)))));
            this.picItemState.Location = new System.Drawing.Point(244, 23);
            this.picItemState.Name = "picItemState";
            this.picItemState.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picItemState.ShadowDecoration.Parent = this.picItemState;
            this.picItemState.Size = new System.Drawing.Size(10, 10);
            this.picItemState.TabIndex = 0;
            this.picItemState.TabStop = false;
            this.picItemState.Click += new System.EventHandler(this.picItemState_Click);
            // 
            // btnEditItemInStore
            // 
            this.btnEditItemInStore.Animated = true;
            this.btnEditItemInStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnEditItemInStore.BorderRadius = 7;
            this.btnEditItemInStore.CheckedState.Parent = this.btnEditItemInStore;
            this.btnEditItemInStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditItemInStore.CustomImages.Parent = this.btnEditItemInStore;
            this.btnEditItemInStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnEditItemInStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditItemInStore.ForeColor = System.Drawing.Color.White;
            this.btnEditItemInStore.HoverState.Parent = this.btnEditItemInStore;
            this.btnEditItemInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItemInStore.Image")));
            this.btnEditItemInStore.Location = new System.Drawing.Point(53, 7);
            this.btnEditItemInStore.Name = "btnEditItemInStore";
            this.btnEditItemInStore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnEditItemInStore.PressedDepth = 10;
            this.btnEditItemInStore.ShadowDecoration.Parent = this.btnEditItemInStore;
            this.btnEditItemInStore.Size = new System.Drawing.Size(35, 35);
            this.btnEditItemInStore.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnEditItemInStore, "اضغط للتعديل");
            this.btnEditItemInStore.Click += new System.EventHandler(this.btnEditItemInStore_Click);
            // 
            // btnDeleteItemInStore
            // 
            this.btnDeleteItemInStore.Animated = true;
            this.btnDeleteItemInStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeleteItemInStore.BorderRadius = 7;
            this.btnDeleteItemInStore.CheckedState.Parent = this.btnDeleteItemInStore;
            this.btnDeleteItemInStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItemInStore.CustomImages.Parent = this.btnDeleteItemInStore;
            this.btnDeleteItemInStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnDeleteItemInStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteItemInStore.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItemInStore.HoverState.Parent = this.btnDeleteItemInStore;
            this.btnDeleteItemInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItemInStore.Image")));
            this.btnDeleteItemInStore.Location = new System.Drawing.Point(12, 7);
            this.btnDeleteItemInStore.Name = "btnDeleteItemInStore";
            this.btnDeleteItemInStore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteItemInStore.PressedDepth = 10;
            this.btnDeleteItemInStore.ShadowDecoration.Parent = this.btnDeleteItemInStore;
            this.btnDeleteItemInStore.Size = new System.Drawing.Size(35, 35);
            this.btnDeleteItemInStore.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnDeleteItemInStore, "اضغط للحذف");
            this.btnDeleteItemInStore.Click += new System.EventHandler(this.btnDeleteItemInStore_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblItemName.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(625, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemName.Size = new System.Drawing.Size(209, 54);
            this.lblItemName.TabIndex = 21;
            this.lblItemName.Text = "منتج عشان خاطر مصر";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UC_ItemInStoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Name = "UC_ItemInStoreCard";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(840, 60);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2Button btnEditItemInStore;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItemInStore;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picItemState;
        private System.Windows.Forms.Label lblItemState;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblDateExpire;
    }
}
