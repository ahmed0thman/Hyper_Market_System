namespace MarketSystem.Windows.UserControls
{
    partial class UC_Category
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
            this.panelCategory = new System.Windows.Forms.Panel();
            this.btnGetCategoryItems = new Guna.UI2.WinForms.Guna2Button();
            this.panelCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.btnGetCategoryItems);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategory.Location = new System.Drawing.Point(2, 2);
            this.panelCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(82, 89);
            this.panelCategory.TabIndex = 1;
            // 
            // btnGetCategoryItems
            // 
            this.btnGetCategoryItems.Animated = true;
            this.btnGetCategoryItems.BorderRadius = 6;
            this.btnGetCategoryItems.CheckedState.Parent = this.btnGetCategoryItems;
            this.btnGetCategoryItems.CustomImages.Parent = this.btnGetCategoryItems;
            this.btnGetCategoryItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetCategoryItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnGetCategoryItems.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCategoryItems.ForeColor = System.Drawing.Color.White;
            this.btnGetCategoryItems.HoverState.Parent = this.btnGetCategoryItems;
            this.btnGetCategoryItems.Location = new System.Drawing.Point(0, 0);
            this.btnGetCategoryItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetCategoryItems.Name = "btnGetCategoryItems";
            this.btnGetCategoryItems.ShadowDecoration.Parent = this.btnGetCategoryItems;
            this.btnGetCategoryItems.Size = new System.Drawing.Size(82, 89);
            this.btnGetCategoryItems.TabIndex = 0;
            this.btnGetCategoryItems.Text = "قائمة منتجات لأى حاجة بقا";
            this.btnGetCategoryItems.Click += new System.EventHandler(this.btnGetCategoryItems_Click);
            // 
            // UC_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Category";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(86, 93);
            this.panelCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCategory;
        private Guna.UI2.WinForms.Guna2Button btnGetCategoryItems;
    }
}
