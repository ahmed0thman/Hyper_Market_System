namespace MarketSystem.Windows.UserControls
{
    partial class UC_BILLDebts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBillDateTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRest = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPayment = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSavePayment = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBillPayments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(280, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 59;
            this.label2.Text = "المبلغ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayment.BorderRadius = 5;
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayment.DefaultText = "";
            this.txtPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.DisabledState.Parent = this.txtPayment;
            this.txtPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.FocusedState.Parent = this.txtPayment;
            this.txtPayment.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPayment.HoverState.Parent = this.txtPayment;
            this.txtPayment.Location = new System.Drawing.Point(34, 364);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.PlaceholderText = "";
            this.txtPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPayment.SelectedText = "";
            this.txtPayment.ShadowDecoration.Parent = this.txtPayment;
            this.txtPayment.Size = new System.Drawing.Size(236, 34);
            this.txtPayment.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblPaid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblBillDateTime);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDetails);
            this.panel1.Controls.Add(this.lblRest);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblBillID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtPayment);
            this.panel1.Controls.Add(this.btnSavePayment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 621);
            this.panel1.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Location = new System.Drawing.Point(38, 251);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 2);
            this.panel4.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(5, 60);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 500);
            this.panel5.TabIndex = 76;
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaid.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPaid.Location = new System.Drawing.Point(85, 84);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPaid.Size = new System.Drawing.Size(191, 31);
            this.lblPaid.TabIndex = 75;
            this.lblPaid.Text = "0";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(280, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(89, 31);
            this.label5.TabIndex = 74;
            this.label5.Text = "ألمدفوع";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBillDateTime
            // 
            this.lblBillDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillDateTime.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBillDateTime.Location = new System.Drawing.Point(85, 170);
            this.lblBillDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillDateTime.Name = "lblBillDateTime";
            this.lblBillDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBillDateTime.Size = new System.Drawing.Size(284, 31);
            this.lblBillDateTime.TabIndex = 73;
            this.lblBillDateTime.Text = "0";
            this.lblBillDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(280, 423);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(89, 31);
            this.label9.TabIndex = 71;
            this.label9.Text = "تفاصيل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.BorderRadius = 5;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.DefaultText = "";
            this.txtDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.DisabledState.Parent = this.txtDetails;
            this.txtDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.FocusedState.Parent = this.txtDetails;
            this.txtDetails.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.HoverState.Parent = this.txtDetails;
            this.txtDetails.Location = new System.Drawing.Point(34, 423);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PlaceholderText = "";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.SelectedText = "";
            this.txtDetails.ShadowDecoration.Parent = this.txtDetails;
            this.txtDetails.Size = new System.Drawing.Size(236, 137);
            this.txtDetails.TabIndex = 70;
            // 
            // lblRest
            // 
            this.lblRest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRest.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRest.Location = new System.Drawing.Point(85, 126);
            this.lblRest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRest.Name = "lblRest";
            this.lblRest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRest.Size = new System.Drawing.Size(191, 31);
            this.lblRest.TabIndex = 69;
            this.lblRest.Text = "0";
            this.lblRest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(280, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(89, 31);
            this.label8.TabIndex = 68;
            this.label8.Text = "الباقى";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(85, 43);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(191, 31);
            this.lblTotal.TabIndex = 67;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(280, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(89, 31);
            this.label6.TabIndex = 66;
            this.label6.Text = "الاجمالى";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBillID
            // 
            this.lblBillID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillID.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBillID.Location = new System.Drawing.Point(85, 12);
            this.lblBillID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBillID.Size = new System.Drawing.Size(191, 31);
            this.lblBillID.TabIndex = 65;
            this.lblBillID.Text = "0";
            this.lblBillID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(280, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "رقم الفاتورة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(280, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 63;
            this.label4.Text = "التاريخ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPayment
            // 
            this.dtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPayment.BorderColor = System.Drawing.Color.LightGray;
            this.dtPayment.BorderRadius = 5;
            this.dtPayment.BorderThickness = 1;
            this.dtPayment.CheckedState.Parent = this.dtPayment;
            this.dtPayment.FillColor = System.Drawing.Color.White;
            this.dtPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPayment.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPayment.HoverState.Parent = this.dtPayment;
            this.dtPayment.Location = new System.Drawing.Point(34, 307);
            this.dtPayment.Margin = new System.Windows.Forms.Padding(2);
            this.dtPayment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPayment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.ShadowDecoration.Parent = this.dtPayment;
            this.dtPayment.Size = new System.Drawing.Size(236, 29);
            this.dtPayment.TabIndex = 52;
            this.dtPayment.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePayment.Animated = true;
            this.btnSavePayment.BorderRadius = 5;
            this.btnSavePayment.CheckedState.Parent = this.btnSavePayment;
            this.btnSavePayment.CustomImages.Parent = this.btnSavePayment;
            this.btnSavePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(173)))), ((int)(((byte)(21)))));
            this.btnSavePayment.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePayment.ForeColor = System.Drawing.Color.White;
            this.btnSavePayment.HoverState.Parent = this.btnSavePayment;
            this.btnSavePayment.Location = new System.Drawing.Point(279, 574);
            this.btnSavePayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.ShadowDecoration.Parent = this.btnSavePayment;
            this.btnSavePayment.Size = new System.Drawing.Size(84, 35);
            this.btnSavePayment.TabIndex = 60;
            this.btnSavePayment.Text = "حفظ";
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBillPayments);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 621);
            this.panel2.TabIndex = 61;
            // 
            // dgvBillPayments
            // 
            this.dgvBillPayments.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillPayments.ColumnHeadersHeight = 35;
            this.dgvBillPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colId,
            this.colBill,
            this.colPrice,
            this.colDetails});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillPayments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillPayments.EnableHeadersVisualStyles = false;
            this.dgvBillPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvBillPayments.Location = new System.Drawing.Point(0, 12);
            this.dgvBillPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBillPayments.Name = "dgvBillPayments";
            this.dgvBillPayments.ReadOnly = true;
            this.dgvBillPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvBillPayments.RowHeadersVisible = false;
            this.dgvBillPayments.RowHeadersWidth = 51;
            this.dgvBillPayments.RowTemplate.Height = 30;
            this.dgvBillPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillPayments.Size = new System.Drawing.Size(629, 609);
            this.dgvBillPayments.TabIndex = 60;
            this.dgvBillPayments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvBillPayments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillPayments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillPayments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillPayments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvBillPayments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillPayments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillPayments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvBillPayments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvBillPayments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillPayments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillPayments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillPayments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBillPayments.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvBillPayments.ThemeStyle.ReadOnly = true;
            this.dgvBillPayments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillPayments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillPayments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillPayments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.dgvBillPayments.ThemeStyle.RowsStyle.Height = 30;
            this.dgvBillPayments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvBillPayments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillPayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillPayments_CellClick);
            this.dgvBillPayments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillPayments_CellDoubleClick);
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "_date";
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colBill
            // 
            this.colBill.DataPropertyName = "bill";
            this.colBill.HeaderText = "الفاتورة";
            this.colBill.Name = "colBill";
            this.colBill.ReadOnly = true;
            this.colBill.Visible = false;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "المبلغ";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDetails
            // 
            this.colDetails.DataPropertyName = "details";
            this.colDetails.HeaderText = "الوصف";
            this.colDetails.MinimumWidth = 6;
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 12);
            this.panel3.TabIndex = 61;
            // 
            // UC_BILLDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_BILLDebts";
            this.Size = new System.Drawing.Size(1009, 621);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPayment;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSavePayment;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBillPayments;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPayment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblBillDateTime;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
    }
}
