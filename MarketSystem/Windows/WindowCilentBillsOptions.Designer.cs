namespace MarketSystem.Windows
{
    partial class WindowCilentBillsOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowCilentBillsOptions));
            this.btnShowBill = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnPayDebts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowBill.Animated = true;
            this.btnShowBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnShowBill.BorderRadius = 7;
            this.btnShowBill.CheckedState.Parent = this.btnShowBill;
            this.btnShowBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowBill.CustomImages.Parent = this.btnShowBill;
            this.btnShowBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnShowBill.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBill.ForeColor = System.Drawing.Color.White;
            this.btnShowBill.HoverState.Parent = this.btnShowBill;
            this.btnShowBill.Location = new System.Drawing.Point(183, 45);
            this.btnShowBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.PressedColor = System.Drawing.Color.White;
            this.btnShowBill.PressedDepth = 10;
            this.btnShowBill.ShadowDecoration.Parent = this.btnShowBill;
            this.btnShowBill.Size = new System.Drawing.Size(143, 39);
            this.btnShowBill.TabIndex = 77;
            this.btnShowBill.Text = "عرض الفاتورة";
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(341, 30);
            this.panelHeader.TabIndex = 76;
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
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(305, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnClose.PressedDepth = 10;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(36, 30);
            this.btnClose.TabIndex = 29;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // btnPayDebts
            // 
            this.btnPayDebts.Animated = true;
            this.btnPayDebts.BorderRadius = 5;
            this.btnPayDebts.CheckedState.Parent = this.btnPayDebts;
            this.btnPayDebts.CustomImages.Parent = this.btnPayDebts;
            this.btnPayDebts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnPayDebts.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayDebts.ForeColor = System.Drawing.Color.White;
            this.btnPayDebts.HoverState.Parent = this.btnPayDebts;
            this.btnPayDebts.Location = new System.Drawing.Point(13, 45);
            this.btnPayDebts.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayDebts.Name = "btnPayDebts";
            this.btnPayDebts.ShadowDecoration.Parent = this.btnPayDebts;
            this.btnPayDebts.Size = new System.Drawing.Size(143, 39);
            this.btnPayDebts.TabIndex = 78;
            this.btnPayDebts.Text = "دفع الديون";
            this.btnPayDebts.Click += new System.EventHandler(this.btnPayDebts_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panelHeader;
            // 
            // WindowCilentBillsOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 95);
            this.Controls.Add(this.btnPayDebts);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowCilentBillsOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WindowCilentBillsOptions";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShowBill;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btnPayDebts;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}