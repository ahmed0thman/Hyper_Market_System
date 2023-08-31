namespace MarketSystem.Windows.UserControls
{
    partial class UC_BillCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BillCard));
            this.btnShowBill = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDeleteBill = new Guna.UI2.WinForms.Guna2Button();
            this.txtBillNum = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.txtBillTime = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.txtBillId = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnDebtArchieve = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnShowBill
            // 
            this.btnShowBill.Animated = true;
            this.btnShowBill.BorderRadius = 5;
            this.btnShowBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowBill.Font = new System.Drawing.Font("Simplified Arabic", 10.2F);
            this.btnShowBill.ForeColor = System.Drawing.Color.White;
            this.btnShowBill.Image = ((System.Drawing.Image)(resources.GetObject("btnShowBill.Image")));
            this.btnShowBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowBill.ImageOffset = new System.Drawing.Point(0, 10);
            this.btnShowBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnShowBill.Location = new System.Drawing.Point(3, 2);
            this.btnShowBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(290, 82);
            this.btnShowBill.TabIndex = 1;
            this.btnShowBill.Text = "كود 1354135";
            this.btnShowBill.TextOffset = new System.Drawing.Point(0, -25);
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Animated = true;
            this.btnDeleteBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeleteBill.BorderRadius = 7;
            this.btnDeleteBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteBill.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBill.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBill.Image")));
            this.btnDeleteBill.Location = new System.Drawing.Point(51, 4);
            this.btnDeleteBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteBill.PressedDepth = 10;
            this.btnDeleteBill.Size = new System.Drawing.Size(35, 34);
            this.btnDeleteBill.TabIndex = 25;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // txtBillNum
            // 
            this.txtBillNum.FillColor = System.Drawing.Color.Transparent;
            this.txtBillNum.Location = new System.Drawing.Point(185, 45);
            this.txtBillNum.Size = new System.Drawing.Size(25, 18);
            this.txtBillNum.TargetControl = this.btnShowBill;
            // 
            // txtBillTime
            // 
            this.txtBillTime.BorderThickness = 0;
            this.txtBillTime.FillColor = System.Drawing.Color.Transparent;
            this.txtBillTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillTime.Location = new System.Drawing.Point(5, 45);
            this.txtBillTime.Size = new System.Drawing.Size(60, 18);
            this.txtBillTime.TargetControl = this.btnShowBill;
            // 
            // txtBillId
            // 
            this.txtBillId.FillColor = System.Drawing.Color.Transparent;
            this.txtBillId.Location = new System.Drawing.Point(150, 45);
            this.txtBillId.Size = new System.Drawing.Size(30, 18);
            this.txtBillId.TargetControl = this.btnShowBill;
            // 
            // btnDebtArchieve
            // 
            this.btnDebtArchieve.Animated = true;
            this.btnDebtArchieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDebtArchieve.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDebtArchieve.BorderRadius = 7;
            this.btnDebtArchieve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDebtArchieve.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDebtArchieve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDebtArchieve.ForeColor = System.Drawing.Color.White;
            this.btnDebtArchieve.Image = ((System.Drawing.Image)(resources.GetObject("btnDebtArchieve.Image")));
            this.btnDebtArchieve.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDebtArchieve.Location = new System.Drawing.Point(6, 4);
            this.btnDebtArchieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDebtArchieve.Name = "btnDebtArchieve";
            this.btnDebtArchieve.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDebtArchieve.PressedDepth = 10;
            this.btnDebtArchieve.Size = new System.Drawing.Size(43, 34);
            this.btnDebtArchieve.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnDebtArchieve, "ارشيف حسابات الفاتورة");
            this.btnDebtArchieve.Click += new System.EventHandler(this.btnDebtArchieve_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UC_BillCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDebtArchieve);
            this.Controls.Add(this.btnDeleteBill);
            this.Controls.Add(this.btnShowBill);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_BillCard";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(296, 86);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnShowBill;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBill;
        private Guna.UI2.WinForms.Guna2NotificationPaint txtBillNum;
        private Guna.UI2.WinForms.Guna2NotificationPaint txtBillTime;
        private Guna.UI2.WinForms.Guna2NotificationPaint txtBillId;
        private Guna.UI2.WinForms.Guna2Button btnDebtArchieve;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
