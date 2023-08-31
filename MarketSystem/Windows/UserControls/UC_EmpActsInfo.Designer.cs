namespace MarketSystem.Windows.UserControls
{
    partial class UC_EmpActsInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmpActs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxActType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpActs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmpActs
            // 
            this.dgvEmpActs.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpActs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEmpActs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpActs.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpActs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpActs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpActs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpActs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEmpActs.ColumnHeadersHeight = 35;
            this.dgvEmpActs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colActType,
            this.colDescription});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpActs.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmpActs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpActs.EnableHeadersVisualStyles = false;
            this.dgvEmpActs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvEmpActs.Location = new System.Drawing.Point(4, 84);
            this.dgvEmpActs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpActs.Name = "dgvEmpActs";
            this.dgvEmpActs.ReadOnly = true;
            this.dgvEmpActs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvEmpActs.RowHeadersVisible = false;
            this.dgvEmpActs.RowHeadersWidth = 51;
            this.dgvEmpActs.RowTemplate.Height = 30;
            this.dgvEmpActs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpActs.Size = new System.Drawing.Size(522, 345);
            this.dgvEmpActs.TabIndex = 58;
            this.dgvEmpActs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvEmpActs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpActs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpActs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpActs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvEmpActs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmpActs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpActs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvEmpActs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvEmpActs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpActs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpActs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpActs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmpActs.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvEmpActs.ThemeStyle.ReadOnly = true;
            this.dgvEmpActs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpActs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpActs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpActs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.dgvEmpActs.ThemeStyle.RowsStyle.Height = 30;
            this.dgvEmpActs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvEmpActs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "_date";
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colActType
            // 
            this.colActType.DataPropertyName = "type";
            this.colActType.HeaderText = "نوع النشاط";
            this.colActType.MinimumWidth = 6;
            this.colActType.Name = "colActType";
            this.colActType.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "description";
            this.colDescription.HeaderText = "الوصف";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 57;
            this.label2.Text = "الفترة من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "الى";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(20, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "نوع النشاط";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxActType
            // 
            this.cbxActType.Animated = true;
            this.cbxActType.BackColor = System.Drawing.Color.Transparent;
            this.cbxActType.BorderRadius = 5;
            this.cbxActType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxActType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxActType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxActType.FocusedState.Parent = this.cbxActType;
            this.cbxActType.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxActType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxActType.HoverState.Parent = this.cbxActType;
            this.cbxActType.ItemHeight = 30;
            this.cbxActType.Items.AddRange(new object[] {
            "الكل",
            "اضافة",
            "تعديل",
            "حذف",
            "سحب دين",
            "دفع دين",
            "فاتورة جديدة",
            "فاتورة شحن",
            "تعديل فاتورة",
            "تعديل فاتورة شحن",
            "حذف فاتورة",
            "حذف فاتورة شحن"});
            this.cbxActType.ItemsAppearance.Parent = this.cbxActType;
            this.cbxActType.Location = new System.Drawing.Point(11, 36);
            this.cbxActType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxActType.Name = "cbxActType";
            this.cbxActType.ShadowDecoration.Parent = this.cbxActType;
            this.cbxActType.Size = new System.Drawing.Size(87, 36);
            this.cbxActType.StartIndex = 0;
            this.cbxActType.TabIndex = 54;
            this.cbxActType.SelectedIndexChanged += new System.EventHandler(this.cbxActType_SelectedIndexChanged);
            // 
            // dtTo
            // 
            this.dtTo.BorderColor = System.Drawing.Color.LightGray;
            this.dtTo.BorderRadius = 5;
            this.dtTo.BorderThickness = 1;
            this.dtTo.CheckedState.Parent = this.dtTo;
            this.dtTo.FillColor = System.Drawing.Color.White;
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTo.HoverState.Parent = this.dtTo;
            this.dtTo.Location = new System.Drawing.Point(102, 40);
            this.dtTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShadowDecoration.Parent = this.dtTo;
            this.dtTo.Size = new System.Drawing.Size(207, 29);
            this.dtTo.TabIndex = 53;
            this.dtTo.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.BorderColor = System.Drawing.Color.LightGray;
            this.dtFrom.BorderRadius = 5;
            this.dtFrom.BorderThickness = 1;
            this.dtFrom.CheckedState.Parent = this.dtFrom;
            this.dtFrom.FillColor = System.Drawing.Color.White;
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFrom.HoverState.Parent = this.dtFrom;
            this.dtFrom.Location = new System.Drawing.Point(318, 40);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShadowDecoration.Parent = this.dtFrom;
            this.dtFrom.Size = new System.Drawing.Size(200, 29);
            this.dtFrom.TabIndex = 52;
            this.dtFrom.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxActType);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 80);
            this.panel1.TabIndex = 59;
            // 
            // UC_EmpActsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvEmpActs);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_EmpActsInfo";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(530, 433);
            this.Load += new System.EventHandler(this.UC_EmpActsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpActs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpActs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cbxActType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Panel panel1;
    }
}
