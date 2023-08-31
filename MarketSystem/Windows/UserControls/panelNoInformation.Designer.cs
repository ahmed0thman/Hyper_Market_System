namespace MarketSystem.Windows.UserControls
{
    partial class panelNoInformation
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
            this.picIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picIcon
            // 
            this.picIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.picIcon.Location = new System.Drawing.Point(121, 11);
            this.picIcon.Name = "picIcon";
            this.picIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picIcon.ShadowDecoration.Parent = this.picIcon;
            this.picIcon.Size = new System.Drawing.Size(250, 250);
            this.picIcon.TabIndex = 0;
            this.picIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsgInfo);
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 1;
            // 
            // lblMsgInfo
            // 
            this.lblMsgInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsgInfo.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblMsgInfo.Location = new System.Drawing.Point(0, 264);
            this.lblMsgInfo.Name = "lblMsgInfo";
            this.lblMsgInfo.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblMsgInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMsgInfo.Size = new System.Drawing.Size(500, 36);
            this.lblMsgInfo.TabIndex = 23;
            this.lblMsgInfo.Text = "إضغط على المنتجات لإضافتها للفاتورة";
            this.lblMsgInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNoInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "panelNoInformation";
            this.Size = new System.Drawing.Size(500, 300);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsgInfo;
    }
}
