namespace MarketSystem.Windows.UserControls
{
    partial class UC_ItemInfoCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ItemInfoCard));
            this.btnEditItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.card = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.picItemState = new System.Windows.Forms.PictureBox();
            this.card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditItem
            // 
            this.btnEditItem.Animated = true;
            this.btnEditItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnEditItem.BorderRadius = 7;
            this.btnEditItem.CheckedState.Parent = this.btnEditItem;
            this.btnEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditItem.CustomImages.Parent = this.btnEditItem;
            this.btnEditItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnEditItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditItem.ForeColor = System.Drawing.Color.White;
            this.btnEditItem.HoverState.Parent = this.btnEditItem;
            this.btnEditItem.Image = ((System.Drawing.Image)(resources.GetObject("btnEditItem.Image")));
            this.btnEditItem.Location = new System.Drawing.Point(47, 9);
            this.btnEditItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnEditItem.PressedDepth = 10;
            this.btnEditItem.ShadowDecoration.Parent = this.btnEditItem;
            this.btnEditItem.Size = new System.Drawing.Size(26, 28);
            this.btnEditItem.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnEditItem, "اضغط لتعديل المنتج");
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Animated = true;
            this.btnDeleteItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeleteItem.BorderRadius = 7;
            this.btnDeleteItem.CheckedState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteItem.CustomImages.Parent = this.btnDeleteItem;
            this.btnDeleteItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.HoverState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Image")));
            this.btnDeleteItem.Location = new System.Drawing.Point(16, 9);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteItem.PressedDepth = 10;
            this.btnDeleteItem.ShadowDecoration.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Size = new System.Drawing.Size(26, 28);
            this.btnDeleteItem.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnDeleteItem, "اضغط لمسح المنتج");
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblItemName.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemName.Location = new System.Drawing.Point(98, 0);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblItemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItemName.Size = new System.Drawing.Size(194, 45);
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
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.Controls.Add(this.picItemState);
            this.card.Controls.Add(this.btnEditItem);
            this.card.Controls.Add(this.btnDeleteItem);
            this.card.Controls.Add(this.lblItemName);
            this.card.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card.FillColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(2, 2);
            this.card.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.card.Name = "card";
            this.card.Radius = 3;
            this.card.ShadowColor = System.Drawing.Color.Gray;
            this.card.ShadowShift = 2;
            this.card.Size = new System.Drawing.Size(292, 45);
            this.card.TabIndex = 1;
            this.card.Click += new System.EventHandler(this.guna2ShadowPanel2_Click);
            // 
            // picItemState
            // 
            this.picItemState.Dock = System.Windows.Forms.DockStyle.Left;
            this.picItemState.Location = new System.Drawing.Point(0, 0);
            this.picItemState.Name = "picItemState";
            this.picItemState.Size = new System.Drawing.Size(5, 45);
            this.picItemState.TabIndex = 29;
            this.picItemState.TabStop = false;
            // 
            // UC_ItemInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.card);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_ItemInfoCard";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(296, 49);
            this.card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItemState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnEditItem;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ToolTip toolTip1;
        public Guna.UI2.WinForms.Guna2ShadowPanel card;
        private System.Windows.Forms.PictureBox picItemState;
    }
}
