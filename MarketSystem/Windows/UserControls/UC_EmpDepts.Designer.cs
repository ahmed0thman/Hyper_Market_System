namespace MarketSystem.Windows.UserControls
{
    partial class UC_EmpDepts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EmpDepts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowDeptWindow = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDebts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperationype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowDeptWindow
            // 
            this.btnShowDeptWindow.Animated = true;
            this.btnShowDeptWindow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(108)))));
            this.btnShowDeptWindow.BorderRadius = 7;
            this.btnShowDeptWindow.CheckedState.Parent = this.btnShowDeptWindow;
            this.btnShowDeptWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDeptWindow.CustomImages.Parent = this.btnShowDeptWindow;
            this.btnShowDeptWindow.FillColor = System.Drawing.Color.White;
            this.btnShowDeptWindow.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDeptWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.btnShowDeptWindow.HoverState.Parent = this.btnShowDeptWindow;
            this.btnShowDeptWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnShowDeptWindow.Image")));
            this.btnShowDeptWindow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowDeptWindow.ImageSize = new System.Drawing.Size(25, 25);
            this.btnShowDeptWindow.Location = new System.Drawing.Point(12, 10);
            this.btnShowDeptWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDeptWindow.Name = "btnShowDeptWindow";
            this.btnShowDeptWindow.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowDeptWindow.PressedDepth = 10;
            this.btnShowDeptWindow.ShadowDecoration.Parent = this.btnShowDeptWindow;
            this.btnShowDeptWindow.Size = new System.Drawing.Size(117, 38);
            this.btnShowDeptWindow.TabIndex = 74;
            this.btnShowDeptWindow.Text = "اضافة عملية";
            this.btnShowDeptWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.btnShowDeptWindow, "اضغط لادارة السلف");
            this.btnShowDeptWindow.Click += new System.EventHandler(this.btnShowDeptWindow_Click);
            // 
            // dgvDebts
            // 
            this.dgvDebts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDebts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDebts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebts.BackgroundColor = System.Drawing.Color.White;
            this.dgvDebts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDebts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDebts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDebts.ColumnHeadersHeight = 35;
            this.dgvDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colOperationype,
            this.colPrice,
            this.colDetails});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDebts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebts.EnableHeadersVisualStyles = false;
            this.dgvDebts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvDebts.Location = new System.Drawing.Point(4, 70);
            this.dgvDebts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDebts.Name = "dgvDebts";
            this.dgvDebts.ReadOnly = true;
            this.dgvDebts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDebts.RowHeadersVisible = false;
            this.dgvDebts.RowHeadersWidth = 51;
            this.dgvDebts.RowTemplate.Height = 30;
            this.dgvDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDebts.Size = new System.Drawing.Size(812, 359);
            this.dgvDebts.TabIndex = 73;
            this.dgvDebts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDebts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDebts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDebts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvDebts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDebts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(167)))));
            this.dgvDebts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvDebts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDebts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDebts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDebts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDebts.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDebts.ThemeStyle.ReadOnly = true;
            this.dgvDebts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDebts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDebts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDebts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.dgvDebts.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDebts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.dgvDebts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDate.DataPropertyName = "_date";
            this.colDate.FillWeight = 3F;
            this.colDate.HeaderText = "التاريخ";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 64;
            // 
            // colOperationype
            // 
            this.colOperationype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colOperationype.DataPropertyName = "type";
            this.colOperationype.HeaderText = "نوع العلمية";
            this.colOperationype.MinimumWidth = 6;
            this.colOperationype.Name = "colOperationype";
            this.colOperationype.ReadOnly = true;
            this.colOperationype.Width = 84;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "المبلغ";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 61;
            // 
            // colDetails
            // 
            this.colDetails.DataPropertyName = "details";
            this.colDetails.FillWeight = 5.67366F;
            this.colDetails.HeaderText = "تفاصيل";
            this.colDetails.Name = "colDetails";
            this.colDetails.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(725, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "الفترة من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(532, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "الى";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(349, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 70;
            this.label11.Text = "نوع النشاط";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxType
            // 
            this.cbxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxType.Animated = true;
            this.cbxType.BackColor = System.Drawing.Color.Transparent;
            this.cbxType.BorderRadius = 5;
            this.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxType.FocusedState.Parent = this.cbxType;
            this.cbxType.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxType.HoverState.Parent = this.cbxType;
            this.cbxType.ItemHeight = 30;
            this.cbxType.Items.AddRange(new object[] {
            "الكل",
            "اضافة سلفة",
            "تسديد سلفة",
            "خصم"});
            this.cbxType.ItemsAppearance.Parent = this.cbxType;
            this.cbxType.Location = new System.Drawing.Point(315, 9);
            this.cbxType.Margin = new System.Windows.Forms.Padding(2);
            this.cbxType.Name = "cbxType";
            this.cbxType.ShadowDecoration.Parent = this.cbxType;
            this.cbxType.Size = new System.Drawing.Size(94, 36);
            this.cbxType.StartIndex = 0;
            this.cbxType.TabIndex = 69;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.BorderColor = System.Drawing.Color.LightGray;
            this.dtTo.BorderRadius = 5;
            this.dtTo.BorderThickness = 1;
            this.dtTo.CheckedState.Parent = this.dtTo;
            this.dtTo.FillColor = System.Drawing.Color.White;
            this.dtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtTo.HoverState.Parent = this.dtTo;
            this.dtTo.Location = new System.Drawing.Point(427, 12);
            this.dtTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShadowDecoration.Parent = this.dtTo;
            this.dtTo.Size = new System.Drawing.Size(180, 29);
            this.dtTo.TabIndex = 68;
            this.dtTo.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.BorderColor = System.Drawing.Color.LightGray;
            this.dtFrom.BorderRadius = 5;
            this.dtFrom.BorderThickness = 1;
            this.dtFrom.CheckedState.Parent = this.dtFrom;
            this.dtFrom.FillColor = System.Drawing.Color.White;
            this.dtFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFrom.HoverState.Parent = this.dtFrom;
            this.dtFrom.Location = new System.Drawing.Point(618, 12);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShadowDecoration.Parent = this.dtFrom;
            this.dtFrom.Size = new System.Drawing.Size(180, 29);
            this.dtFrom.TabIndex = 67;
            this.dtFrom.Value = new System.DateTime(2020, 11, 13, 14, 45, 29, 1);
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.btnShowDeptWindow);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 66);
            this.panel1.TabIndex = 75;
            // 
            // UC_EmpDepts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvDebts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_EmpDepts";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(820, 433);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShowDeptWindow;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDebts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cbxType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtFrom;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperationype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
        private System.Windows.Forms.Panel panel1;
    }
}
