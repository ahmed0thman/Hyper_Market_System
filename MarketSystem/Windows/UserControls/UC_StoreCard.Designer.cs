namespace MarketSystem.Windows.UserControls
{
    partial class UC_StoreCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StoreCard));
            this.btnStore = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDeleteStore = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditStore = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnStore
            // 
            this.btnStore.Animated = true;
            this.btnStore.BorderRadius = 15;
            this.btnStore.CheckedState.Parent = this.btnStore;
            this.btnStore.CustomImages.Parent = this.btnStore;
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnStore.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.Color.White;
            this.btnStore.HoverState.Parent = this.btnStore;
            this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
            this.btnStore.ImageSize = new System.Drawing.Size(55, 55);
            this.btnStore.Location = new System.Drawing.Point(3, 3);
            this.btnStore.Name = "btnStore";
            this.btnStore.ShadowDecoration.Parent = this.btnStore;
            this.btnStore.Size = new System.Drawing.Size(204, 144);
            this.btnStore.TabIndex = 0;
            this.btnStore.Text = "إسم المخزن";
            this.toolTip1.SetToolTip(this.btnStore, "عرض محتوى المخزن");
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.Animated = true;
            this.btnDeleteStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnDeleteStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeleteStore.BorderRadius = 7;
            this.btnDeleteStore.CheckedState.Parent = this.btnDeleteStore;
            this.btnDeleteStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStore.CustomImages.Parent = this.btnDeleteStore;
            this.btnDeleteStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnDeleteStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteStore.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStore.HoverState.Parent = this.btnDeleteStore;
            this.btnDeleteStore.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStore.Image")));
            this.btnDeleteStore.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeleteStore.PressedDepth = 10;
            this.btnDeleteStore.ShadowDecoration.Parent = this.btnDeleteStore;
            this.btnDeleteStore.Size = new System.Drawing.Size(35, 35);
            this.btnDeleteStore.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnDeleteStore, "حذف المخزن");
            this.btnDeleteStore.Click += new System.EventHandler(this.btnDeleteStore_Click);
            // 
            // btnEditStore
            // 
            this.btnEditStore.Animated = true;
            this.btnEditStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnEditStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnEditStore.BorderRadius = 7;
            this.btnEditStore.CheckedState.Parent = this.btnEditStore;
            this.btnEditStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStore.CustomImages.Parent = this.btnEditStore;
            this.btnEditStore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnEditStore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditStore.ForeColor = System.Drawing.Color.White;
            this.btnEditStore.HoverState.Parent = this.btnEditStore;
            this.btnEditStore.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStore.Image")));
            this.btnEditStore.Location = new System.Drawing.Point(39, 6);
            this.btnEditStore.Name = "btnEditStore";
            this.btnEditStore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnEditStore.PressedDepth = 10;
            this.btnEditStore.ShadowDecoration.Parent = this.btnEditStore;
            this.btnEditStore.Size = new System.Drawing.Size(35, 35);
            this.btnEditStore.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnEditStore, "تعديل بيانات المخزن");
            this.btnEditStore.Click += new System.EventHandler(this.btnEditStore_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UC_StoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnEditStore);
            this.Controls.Add(this.btnDeleteStore);
            this.Controls.Add(this.btnStore);
            this.Name = "UC_StoreCard";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(210, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnStore;
        private Guna.UI2.WinForms.Guna2Button btnDeleteStore;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnEditStore;
    }
}
