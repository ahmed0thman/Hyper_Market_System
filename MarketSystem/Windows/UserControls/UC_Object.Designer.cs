namespace MarketSystem.Windows.UserControls
{
    partial class UC_Object
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
            this.btnObject = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnObject
            // 
            this.btnObject.Animated = true;
            this.btnObject.BorderRadius = 7;
            this.btnObject.CheckedState.Parent = this.btnObject;
            this.btnObject.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.btnObject.CustomImages.Parent = this.btnObject;
            this.btnObject.CustomizableEdges.TopRight = false;
            this.btnObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnObject.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(161)))), ((int)(((byte)(218)))));
            this.btnObject.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObject.ForeColor = System.Drawing.Color.White;
            this.btnObject.HoverState.Parent = this.btnObject;
            this.btnObject.Location = new System.Drawing.Point(2, 2);
            this.btnObject.Name = "btnObject";
            this.btnObject.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnObject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnObject.ShadowDecoration.Parent = this.btnObject;
            this.btnObject.Size = new System.Drawing.Size(254, 36);
            this.btnObject.TabIndex = 0;
            this.btnObject.Text = "احمد هشام سعد عبد العزيز عثمان";
            this.btnObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // UC_ObjectRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnObject);
            this.Name = "UC_ObjectRadio";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(258, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnObject;
    }
}
