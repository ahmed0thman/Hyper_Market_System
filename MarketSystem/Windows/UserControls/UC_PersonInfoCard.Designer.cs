namespace MarketSystem.Windows.UserControls
{
    partial class UC_PersonInfoCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PersonInfoCard));
            this.card = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPayAllDebts = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblPersonDept = new System.Windows.Forms.Label();
            this.btnEditPerson = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeletePerson = new Guna.UI2.WinForms.Guna2Button();
            this.lblPersonPhone = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.picEmployee = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.card.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.Color.Transparent;
            this.card.Controls.Add(this.panel1);
            this.card.Controls.Add(this.picEmployee);
            this.card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card.FillColor = System.Drawing.Color.White;
            this.card.Location = new System.Drawing.Point(2, 2);
            this.card.Margin = new System.Windows.Forms.Padding(2);
            this.card.Name = "card";
            this.card.Padding = new System.Windows.Forms.Padding(2);
            this.card.Radius = 7;
            this.card.ShadowColor = System.Drawing.Color.Black;
            this.card.ShadowShift = 3;
            this.card.Size = new System.Drawing.Size(367, 89);
            this.card.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPayAllDebts);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.lblPersonDept);
            this.panel1.Controls.Add(this.btnEditPerson);
            this.panel1.Controls.Add(this.btnDeletePerson);
            this.panel1.Controls.Add(this.lblPersonPhone);
            this.panel1.Controls.Add(this.lblPersonName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 85);
            this.panel1.TabIndex = 1;
            // 
            // btnPayAllDebts
            // 
            this.btnPayAllDebts.Animated = true;
            this.btnPayAllDebts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnPayAllDebts.BorderRadius = 7;
            this.btnPayAllDebts.BorderThickness = 1;
            this.btnPayAllDebts.CheckedState.Parent = this.btnPayAllDebts;
            this.btnPayAllDebts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayAllDebts.CustomImages.Parent = this.btnPayAllDebts;
            this.btnPayAllDebts.FillColor = System.Drawing.Color.Transparent;
            this.btnPayAllDebts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPayAllDebts.ForeColor = System.Drawing.Color.White;
            this.btnPayAllDebts.HoverState.Parent = this.btnPayAllDebts;
            this.btnPayAllDebts.Image = ((System.Drawing.Image)(resources.GetObject("btnPayAllDebts.Image")));
            this.btnPayAllDebts.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPayAllDebts.Location = new System.Drawing.Point(10, 17);
            this.btnPayAllDebts.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayAllDebts.Name = "btnPayAllDebts";
            this.btnPayAllDebts.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnPayAllDebts.PressedDepth = 10;
            this.btnPayAllDebts.ShadowDecoration.Parent = this.btnPayAllDebts;
            this.btnPayAllDebts.Size = new System.Drawing.Size(26, 28);
            this.btnPayAllDebts.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnPayAllDebts, "دفع كل الديون");
            this.btnPayAllDebts.Click += new System.EventHandler(this.btnPayAllDebts_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(80, 51);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // lblPersonDept
            // 
            this.lblPersonDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPersonDept.AutoSize = true;
            this.lblPersonDept.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.lblPersonDept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPersonDept.Location = new System.Drawing.Point(106, 51);
            this.lblPersonDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonDept.Name = "lblPersonDept";
            this.lblPersonDept.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblPersonDept.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPersonDept.Size = new System.Drawing.Size(43, 28);
            this.lblPersonDept.TabIndex = 33;
            this.lblPersonDept.Text = "250";
            this.lblPersonDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblPersonDept, "الديون");
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Animated = true;
            this.btnEditPerson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnEditPerson.BorderRadius = 7;
            this.btnEditPerson.CheckedState.Parent = this.btnEditPerson;
            this.btnEditPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPerson.CustomImages.Parent = this.btnEditPerson;
            this.btnEditPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(250)))));
            this.btnEditPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditPerson.ForeColor = System.Drawing.Color.White;
            this.btnEditPerson.HoverState.Parent = this.btnEditPerson;
            this.btnEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPerson.Image")));
            this.btnEditPerson.Location = new System.Drawing.Point(40, 49);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnEditPerson.PressedDepth = 10;
            this.btnEditPerson.ShadowDecoration.Parent = this.btnEditPerson;
            this.btnEditPerson.Size = new System.Drawing.Size(26, 28);
            this.btnEditPerson.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnEditPerson, "تعديل البيانات");
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Animated = true;
            this.btnDeletePerson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnDeletePerson.BorderRadius = 7;
            this.btnDeletePerson.CheckedState.Parent = this.btnDeletePerson;
            this.btnDeletePerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePerson.CustomImages.Parent = this.btnDeletePerson;
            this.btnDeletePerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(81)))));
            this.btnDeletePerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeletePerson.ForeColor = System.Drawing.Color.White;
            this.btnDeletePerson.HoverState.Parent = this.btnDeletePerson;
            this.btnDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePerson.Image")));
            this.btnDeletePerson.Location = new System.Drawing.Point(10, 49);
            this.btnDeletePerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnDeletePerson.PressedDepth = 10;
            this.btnDeletePerson.ShadowDecoration.Parent = this.btnDeletePerson;
            this.btnDeletePerson.Size = new System.Drawing.Size(26, 28);
            this.btnDeletePerson.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnDeletePerson, "حذف البيانات");
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblPersonPhone
            // 
            this.lblPersonPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPersonPhone.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblPersonPhone.Location = new System.Drawing.Point(167, 46);
            this.lblPersonPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonPhone.Name = "lblPersonPhone";
            this.lblPersonPhone.Padding = new System.Windows.Forms.Padding(2);
            this.lblPersonPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersonPhone.Size = new System.Drawing.Size(112, 39);
            this.lblPersonPhone.TabIndex = 12;
            this.lblPersonPhone.Text = "01286615732";
            this.lblPersonPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPersonName
            // 
            this.lblPersonName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPersonName.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.lblPersonName.Location = new System.Drawing.Point(0, 0);
            this.lblPersonName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Padding = new System.Windows.Forms.Padding(2);
            this.lblPersonName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPersonName.Size = new System.Drawing.Size(279, 46);
            this.lblPersonName.TabIndex = 11;
            this.lblPersonName.Text = "ابراهيم احمد يوسف";
            this.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picEmployee
            // 
            this.picEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmployee.Dock = System.Windows.Forms.DockStyle.Right;
            this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
            this.picEmployee.Location = new System.Drawing.Point(281, 2);
            this.picEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picEmployee.ShadowDecoration.Parent = this.picEmployee;
            this.picEmployee.Size = new System.Drawing.Size(84, 85);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployee.TabIndex = 0;
            this.picEmployee.TabStop = false;
            this.picEmployee.Click += new System.EventHandler(this.picEmployee_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // UC_PersonInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.card);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_PersonInfoCard";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(371, 93);
            this.card.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnEditPerson;
        private Guna.UI2.WinForms.Guna2Button btnDeletePerson;
        private System.Windows.Forms.Label lblPersonPhone;
        private System.Windows.Forms.Label lblPersonName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picEmployee;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblPersonDept;
        public Guna.UI2.WinForms.Guna2ShadowPanel card;
        private Guna.UI2.WinForms.Guna2Button btnPayAllDebts;
    }
}
