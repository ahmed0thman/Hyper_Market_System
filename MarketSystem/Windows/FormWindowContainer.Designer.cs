namespace MarketSystem.Windows
{
    partial class FormWindowContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWindowContainer));
            this.BarHeader = new System.Windows.Forms.Panel();
            this.btnMinmize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.BarHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BarHeader
            // 
            this.BarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.BarHeader.Controls.Add(this.btnMinmize);
            this.BarHeader.Controls.Add(this.lblHeader);
            this.BarHeader.Controls.Add(this.btnMaximize);
            this.BarHeader.Controls.Add(this.MainLogo);
            this.BarHeader.Controls.Add(this.btnClose);
            this.BarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarHeader.Location = new System.Drawing.Point(0, 0);
            this.BarHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarHeader.Name = "BarHeader";
            this.BarHeader.Size = new System.Drawing.Size(1040, 37);
            this.BarHeader.TabIndex = 1;
            // 
            // btnMinmize
            // 
            this.btnMinmize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinmize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinmize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinmize.HoverState.Parent = this.btnMinmize;
            this.btnMinmize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.btnMinmize.Location = new System.Drawing.Point(936, 0);
            this.btnMinmize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinmize.Name = "btnMinmize";
            this.btnMinmize.ShadowDecoration.Parent = this.btnMinmize;
            this.btnMinmize.Size = new System.Drawing.Size(34, 37);
            this.btnMinmize.TabIndex = 11;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Arabic Typesetting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblHeader.Location = new System.Drawing.Point(122, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHeader.Size = new System.Drawing.Size(848, 37);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "عنوان النافذة";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximize
            // 
            this.btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.HoverState.Parent = this.btnMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.btnMaximize.Location = new System.Drawing.Point(970, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.ShadowDecoration.Parent = this.btnMaximize;
            this.btnMaximize.Size = new System.Drawing.Size(34, 37);
            this.btnMaximize.TabIndex = 2;
            // 
            // MainLogo
            // 
            this.MainLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainLogo.Image = ((System.Drawing.Image)(resources.GetObject("MainLogo.Image")));
            this.MainLogo.Location = new System.Drawing.Point(0, 0);
            this.MainLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(122, 37);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLogo.TabIndex = 0;
            this.MainLogo.TabStop = false;
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
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1004, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnClose.PressedDepth = 10;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.TabIndex = 30;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lblHeader;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 37);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContainer.Size = new System.Drawing.Size(1040, 603);
            this.panelContainer.TabIndex = 2;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FormWindowContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.BarHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormWindowContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWindowContainer";
            this.BarHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarHeader;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        protected System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinmize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}