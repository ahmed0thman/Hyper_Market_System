namespace MarketSystem.Windows.UserControls
{
    partial class UC_StoreItemInInfoCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StoreItemInInfoCard));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblDateExpire = new System.Windows.Forms.Label();
            this.lblItemState = new System.Windows.Forms.Label();
            this.btnEditItemInStore = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItemInStore = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnTrasfer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picItemState = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblQuantity.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(159)))), ((int)(((byte)(97)))));
            this.lblQuantity.Location = new System.Drawing.Point(88, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity.Size = new System.Drawing.Size(68, 43);
            this.lblQuantity.TabIndex = 65;
            this.lblQuantity.Text = "60";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblQuantity, "الكمية");
            // 
            // lblBill
            // 
            this.lblBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBill.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.lblBill.Location = new System.Drawing.Point(156, 0);
            this.lblBill.Name = "lblBill";
            this.lblBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBill.Size = new System.Drawing.Size(96, 43);
            this.lblBill.TabIndex = 64;
            this.lblBill.Text = "18";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblBill, "الفاتورة الملحقة");
            // 
            // lblDateExpire
            // 
            this.lblDateExpire.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDateExpire.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDateExpire.Location = new System.Drawing.Point(252, 0);
            this.lblDateExpire.Name = "lblDateExpire";
            this.lblDateExpire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDateExpire.Size = new System.Drawing.Size(159, 43);
            this.lblDateExpire.TabIndex = 63;
            this.lblDateExpire.Text = "20-12-2020";
            this.lblDateExpire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblDateExpire, "تاريخ انتهاء الصلاحية");
            // 
            // lblItemState
            // 
            this.lblItemState.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblItemState.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(211)))), ((int)(((byte)(33)))));
            this.lblItemState.Location = new System.Drawing.Point(0, 0);
            this.lblItemState.Name = "lblItemState";
            this.lblItemState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemState.Size = new System.Drawing.Size(127, 43);
            this.lblItemState.TabIndex = 56;
            this.lblItemState.Text = "متاح";
            this.lblItemState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblItemState, "حالة المنتج");
            // 
            // btnEditItemInStore
            // 
            this.btnEditItemInStore.Animated = true;
            this.btnEditItemInStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnEditItemInStore.BorderRadius = 7;
            this.btnEditItemInStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditItemInStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnEditItemInStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditItemInStore.ForeColor = System.Drawing.Color.White;
            this.btnEditItemInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItemInStore.Image")));
            this.btnEditItemInStore.Location = new System.Drawing.Point(47, 5);
            this.btnEditItemInStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditItemInStore.Name = "btnEditItemInStore";
            this.btnEditItemInStore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnEditItemInStore.PressedDepth = 10;
            this.btnEditItemInStore.Size = new System.Drawing.Size(35, 34);
            this.btnEditItemInStore.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnEditItemInStore, "اضغط للتعديل");
            this.btnEditItemInStore.Click += new System.EventHandler(this.btnEditItemInStore_Click);
            // 
            // btnDeleteItemInStore
            // 
            this.btnDeleteItemInStore.Animated = true;
            this.btnDeleteItemInStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeleteItemInStore.BorderRadius = 7;
            this.btnDeleteItemInStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItemInStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnDeleteItemInStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteItemInStore.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItemInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItemInStore.Image")));
            this.btnDeleteItemInStore.Location = new System.Drawing.Point(5, 5);
            this.btnDeleteItemInStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteItemInStore.Name = "btnDeleteItemInStore";
            this.btnDeleteItemInStore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteItemInStore.PressedDepth = 10;
            this.btnDeleteItemInStore.Size = new System.Drawing.Size(35, 34);
            this.btnDeleteItemInStore.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnDeleteItemInStore, "اضغط للحذف");
            this.btnDeleteItemInStore.Click += new System.EventHandler(this.btnDeleteItemInStore_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(64, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(53, 34);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "250";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblPrice, "سعر المنتج");
            // 
            // lblUnit
            // 
            this.lblUnit.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.lblUnit.Location = new System.Drawing.Point(235, 11);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUnit.Size = new System.Drawing.Size(163, 37);
            this.lblUnit.TabIndex = 31;
            this.lblUnit.Text = "وحدة التخزين";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblUnit, "وحدة التخزين");
            // 
            // btnTrasfer
            // 
            this.btnTrasfer.Animated = true;
            this.btnTrasfer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnTrasfer.BorderRadius = 7;
            this.btnTrasfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrasfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrasfer.FillColor = System.Drawing.Color.Transparent;
            this.btnTrasfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTrasfer.ForeColor = System.Drawing.Color.White;
            this.btnTrasfer.Image = ((System.Drawing.Image)(resources.GetObject("btnTrasfer.Image")));
            this.btnTrasfer.ImageSize = new System.Drawing.Size(27, 27);
            this.btnTrasfer.Location = new System.Drawing.Point(0, 0);
            this.btnTrasfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrasfer.Name = "btnTrasfer";
            this.btnTrasfer.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnTrasfer.PressedDepth = 10;
            this.btnTrasfer.Size = new System.Drawing.Size(35, 36);
            this.btnTrasfer.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnTrasfer, "تحويل الصنف");
            this.btnTrasfer.Click += new System.EventHandler(this.btnTrasfer_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.lblUnit);
            this.guna2ShadowPanel1.Controls.Add(this.panel2);
            this.guna2ShadowPanel1.Controls.Add(this.lblStoreName);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 2);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(703, 106);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnTrasfer);
            this.panel1.Location = new System.Drawing.Point(17, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 36);
            this.panel1.TabIndex = 63;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblBill);
            this.panel2.Controls.Add(this.lblDateExpire);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnEditItemInStore);
            this.panel2.Controls.Add(this.btnDeleteItemInStore);
            this.panel2.Location = new System.Drawing.Point(17, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 43);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblItemState);
            this.panel3.Controls.Add(this.picItemState);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(411, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 43);
            this.panel3.TabIndex = 62;
            // 
            // picItemState
            // 
            this.picItemState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picItemState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(211)))), ((int)(((byte)(33)))));
            this.picItemState.ImageRotate = 0F;
            this.picItemState.Location = new System.Drawing.Point(136, 16);
            this.picItemState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picItemState.Name = "picItemState";
            this.picItemState.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picItemState.Size = new System.Drawing.Size(11, 10);
            this.picItemState.TabIndex = 0;
            this.picItemState.TabStop = false;
            // 
            // lblStoreName
            // 
            this.lblStoreName.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStoreName.Location = new System.Drawing.Point(427, 12);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblStoreName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStoreName.Size = new System.Drawing.Size(173, 37);
            this.lblStoreName.TabIndex = 22;
            this.lblStoreName.Text = "إسم المخزن";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UC_StoreItemInInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_StoreItemInInfoCard";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(709, 110);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblDateExpire;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblItemState;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picItemState;
        private Guna.UI2.WinForms.Guna2Button btnEditItemInStore;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItemInStore;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUnit;
        private Guna.UI2.WinForms.Guna2Button btnTrasfer;
        private System.Windows.Forms.Panel panel1;
    }
}
