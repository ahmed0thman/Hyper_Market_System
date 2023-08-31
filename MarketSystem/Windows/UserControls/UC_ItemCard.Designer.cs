namespace MarketSystem.Windows.UserControls
{
    partial class UC_ItemCard
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.picItemState = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblItemPrice);
            this.guna2ShadowPanel1.Controls.Add(this.lblItemName);
            this.guna2ShadowPanel1.Controls.Add(this.picItemState);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(2, 2);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 2;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(173, 69);
            this.guna2ShadowPanel1.TabIndex = 1;
            this.guna2ShadowPanel1.Click += new System.EventHandler(this.guna2ShadowPanel1_Click);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblItemPrice.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblItemPrice.Location = new System.Drawing.Point(3, 37);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblItemPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemPrice.Size = new System.Drawing.Size(160, 32);
            this.lblItemPrice.TabIndex = 12;
            this.lblItemPrice.Text = "157,5";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemPrice.Click += new System.EventHandler(this.lblItemPrice_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemName.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblItemName.Location = new System.Drawing.Point(0, 0);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemName.Size = new System.Drawing.Size(163, 37);
            this.lblItemName.TabIndex = 11;
            this.lblItemName.Text = "إسم المنتج";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click);
            // 
            // picItemState
            // 
            this.picItemState.Dock = System.Windows.Forms.DockStyle.Right;
            this.picItemState.Location = new System.Drawing.Point(163, 0);
            this.picItemState.Name = "picItemState";
            this.picItemState.Size = new System.Drawing.Size(10, 69);
            this.picItemState.TabIndex = 13;
            this.picItemState.TabStop = false;
            // 
            // UC_ItemCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_ItemCard";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(177, 73);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.PictureBox picItemState;
    }
}
