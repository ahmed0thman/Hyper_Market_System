namespace MarketSystem.Windows.UserControls
{
    partial class UC_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Items));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelItemsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowMore = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelNavigator = new System.Windows.Forms.Panel();
            this.dtExpDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxItemState = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnShowFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnHandleItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowUCStoreswzItem = new Guna.UI2.WinForms.Guna2Button();
            this.txtItemSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowUCMainInfo = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.panelNavigator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelItemsCards);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(448, 643);
            this.panel2.TabIndex = 61;
            // 
            // panelItemsCards
            // 
            this.panelItemsCards.AutoScroll = true;
            this.panelItemsCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItemsCards.Location = new System.Drawing.Point(5, 5);
            this.panelItemsCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelItemsCards.Name = "panelItemsCards";
            this.panelItemsCards.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.panelItemsCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelItemsCards.Size = new System.Drawing.Size(438, 592);
            this.panelItemsCards.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowMore);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 597);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 41);
            this.panel3.TabIndex = 63;
            // 
            // btnShowMore
            // 
            this.btnShowMore.Animated = true;
            this.btnShowMore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowMore.Checked = true;
            this.btnShowMore.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowMore.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowMore.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowMore.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowMore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowMore.FillColor = System.Drawing.Color.Transparent;
            this.btnShowMore.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowMore.Location = new System.Drawing.Point(268, 0);
            this.btnShowMore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowMore.Size = new System.Drawing.Size(170, 41);
            this.btnShowMore.TabIndex = 4;
            this.btnShowMore.Text = "أظهر المزيد";
            this.btnShowMore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnShowMore.Click += new System.EventHandler(this.btnShowMore_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(448, 57);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(787, 643);
            this.panelContainer.TabIndex = 60;
            // 
            // panelNavigator
            // 
            this.panelNavigator.Controls.Add(this.dtExpDate);
            this.panelNavigator.Controls.Add(this.cbxItemState);
            this.panelNavigator.Controls.Add(this.btnShowFilter);
            this.panelNavigator.Controls.Add(this.btnRefreshItems);
            this.panelNavigator.Controls.Add(this.btnHandleItems);
            this.panelNavigator.Controls.Add(this.btnShowUCStoreswzItem);
            this.panelNavigator.Controls.Add(this.txtItemSearch);
            this.panelNavigator.Controls.Add(this.btnShowUCMainInfo);
            this.panelNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigator.Location = new System.Drawing.Point(0, 0);
            this.panelNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNavigator.Name = "panelNavigator";
            this.panelNavigator.Padding = new System.Windows.Forms.Padding(11, 12, 29, 12);
            this.panelNavigator.Size = new System.Drawing.Size(1235, 57);
            this.panelNavigator.TabIndex = 59;
            // 
            // dtExpDate
            // 
            this.dtExpDate.BackColor = System.Drawing.Color.Transparent;
            this.dtExpDate.BorderRadius = 5;
            this.dtExpDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dtExpDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dtExpDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtExpDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtExpDate.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.dtExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dtExpDate.ItemHeight = 30;
            this.dtExpDate.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.dtExpDate.Location = new System.Drawing.Point(453, 7);
            this.dtExpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtExpDate.Name = "dtExpDate";
            this.dtExpDate.Size = new System.Drawing.Size(164, 36);
            this.dtExpDate.StartIndex = 0;
            this.dtExpDate.TabIndex = 101;
            this.dtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dtExpDate.TextOffset = new System.Drawing.Point(-5, 0);
            this.dtExpDate.SelectedIndexChanged += new System.EventHandler(this.dtExpDate_SelectedIndexChanged);
            // 
            // cbxItemState
            // 
            this.cbxItemState.BackColor = System.Drawing.Color.Transparent;
            this.cbxItemState.BorderRadius = 5;
            this.cbxItemState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxItemState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemState.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxItemState.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxItemState.Font = new System.Drawing.Font("Simplified Arabic", 10.8F);
            this.cbxItemState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxItemState.ItemHeight = 30;
            this.cbxItemState.Items.AddRange(new object[] {
            "الكل",
            "تحت الاحتياج",
            "غير متاح",
            "منتهى الصلاحية",
            "اوشكت صلاحيتة على الانتهاء"});
            this.cbxItemState.Location = new System.Drawing.Point(53, 7);
            this.cbxItemState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxItemState.Name = "cbxItemState";
            this.cbxItemState.Size = new System.Drawing.Size(337, 36);
            this.cbxItemState.StartIndex = 0;
            this.cbxItemState.TabIndex = 100;
            this.cbxItemState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cbxItemState.TextOffset = new System.Drawing.Point(-5, 0);
            this.cbxItemState.SelectedIndexChanged += new System.EventHandler(this.cbxItemState_SelectedIndexChanged);
            // 
            // btnShowFilter
            // 
            this.btnShowFilter.Animated = true;
            this.btnShowFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.btnShowFilter.BorderRadius = 5;
            this.btnShowFilter.FillColor = System.Drawing.Color.Transparent;
            this.btnShowFilter.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFilter.ForeColor = System.Drawing.Color.White;
            this.btnShowFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnShowFilter.Image")));
            this.btnShowFilter.Location = new System.Drawing.Point(13, 12);
            this.btnShowFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFilter.Name = "btnShowFilter";
            this.btnShowFilter.Size = new System.Drawing.Size(35, 32);
            this.btnShowFilter.TabIndex = 99;
            this.toolTip1.SetToolTip(this.btnShowFilter, "فلترة");
            this.btnShowFilter.Click += new System.EventHandler(this.btnShowFilter_Click);
            // 
            // btnRefreshItems
            // 
            this.btnRefreshItems.Animated = true;
            this.btnRefreshItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.btnRefreshItems.BorderRadius = 5;
            this.btnRefreshItems.BorderThickness = 1;
            this.btnRefreshItems.FillColor = System.Drawing.Color.Transparent;
            this.btnRefreshItems.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshItems.ForeColor = System.Drawing.Color.White;
            this.btnRefreshItems.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshItems.Image")));
            this.btnRefreshItems.Location = new System.Drawing.Point(413, 12);
            this.btnRefreshItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshItems.Name = "btnRefreshItems";
            this.btnRefreshItems.Size = new System.Drawing.Size(35, 32);
            this.btnRefreshItems.TabIndex = 98;
            this.toolTip1.SetToolTip(this.btnRefreshItems, "تحديث البيانات");
            this.btnRefreshItems.Click += new System.EventHandler(this.btnRefreshItems_Click);
            // 
            // btnHandleItems
            // 
            this.btnHandleItems.Animated = true;
            this.btnHandleItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHandleItems.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnHandleItems.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnHandleItems.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnHandleItems.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnHandleItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHandleItems.FillColor = System.Drawing.Color.Transparent;
            this.btnHandleItems.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandleItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnHandleItems.Location = new System.Drawing.Point(627, 12);
            this.btnHandleItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHandleItems.Name = "btnHandleItems";
            this.btnHandleItems.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnHandleItems.Size = new System.Drawing.Size(183, 33);
            this.btnHandleItems.TabIndex = 3;
            this.btnHandleItems.Text = "تسوية الاصناف";
            this.btnHandleItems.Click += new System.EventHandler(this.btnHandleItems_Click);
            // 
            // btnShowUCStoreswzItem
            // 
            this.btnShowUCStoreswzItem.Animated = true;
            this.btnShowUCStoreswzItem.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowUCStoreswzItem.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCStoreswzItem.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCStoreswzItem.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowUCStoreswzItem.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowUCStoreswzItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowUCStoreswzItem.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCStoreswzItem.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUCStoreswzItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCStoreswzItem.Location = new System.Drawing.Point(810, 12);
            this.btnShowUCStoreswzItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowUCStoreswzItem.Name = "btnShowUCStoreswzItem";
            this.btnShowUCStoreswzItem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowUCStoreswzItem.Size = new System.Drawing.Size(202, 33);
            this.btnShowUCStoreswzItem.TabIndex = 1;
            this.btnShowUCStoreswzItem.Text = "اماكن التواجد";
            this.btnShowUCStoreswzItem.Click += new System.EventHandler(this.btnShowUCStoreswzItem_Click);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.BorderRadius = 10;
            this.txtItemSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemSearch.DefaultText = "";
            this.txtItemSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemSearch.Font = new System.Drawing.Font("Simplified Arabic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(71)))), ((int)(((byte)(78)))));
            this.txtItemSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtItemSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtItemSearch.IconRight")));
            this.txtItemSearch.IconRightOffset = new System.Drawing.Point(5, 0);
            this.txtItemSearch.Location = new System.Drawing.Point(53, 12);
            this.txtItemSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.PasswordChar = '\0';
            this.txtItemSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(122)))));
            this.txtItemSearch.PlaceholderText = "بحث بإسم الصنف او الكود";
            this.txtItemSearch.SelectedText = "";
            this.txtItemSearch.Size = new System.Drawing.Size(339, 32);
            this.txtItemSearch.TabIndex = 2;
            this.txtItemSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemSearch.TextChanged += new System.EventHandler(this.txtItemSearch_TextChanged);
            this.txtItemSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemSearch_KeyDown);
            // 
            // btnShowUCMainInfo
            // 
            this.btnShowUCMainInfo.Animated = true;
            this.btnShowUCMainInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowUCMainInfo.Checked = true;
            this.btnShowUCMainInfo.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCMainInfo.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnShowUCMainInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowUCMainInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUCMainInfo.Font = new System.Drawing.Font("Simplified Arabic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUCMainInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(88)))), ((int)(((byte)(140)))));
            this.btnShowUCMainInfo.Location = new System.Drawing.Point(1012, 12);
            this.btnShowUCMainInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowUCMainInfo.Name = "btnShowUCMainInfo";
            this.btnShowUCMainInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.btnShowUCMainInfo.Size = new System.Drawing.Size(194, 33);
            this.btnShowUCMainInfo.TabIndex = 0;
            this.btnShowUCMainInfo.Text = "البيانات الاساسية";
            this.btnShowUCMainInfo.Click += new System.EventHandler(this.btnShowUCMainInfo_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UC_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Items";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.Size = new System.Drawing.Size(1275, 740);
            this.Load += new System.EventHandler(this.UC_Items_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelNavigator;
        private Guna.UI2.WinForms.Guna2Button btnShowUCStoreswzItem;
        private Guna.UI2.WinForms.Guna2Button btnShowUCMainInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtItemSearch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelItemsCards;
        private Guna.UI2.WinForms.Guna2Button btnHandleItems;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnShowMore;
        private Guna.UI2.WinForms.Guna2Button btnRefreshItems;
        private Guna.UI2.WinForms.Guna2Button btnShowFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbxItemState;
        private Guna.UI2.WinForms.Guna2ComboBox dtExpDate;
    }
}
