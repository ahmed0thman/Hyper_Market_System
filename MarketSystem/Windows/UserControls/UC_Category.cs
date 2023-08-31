using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Enitiies;

namespace MarketSystem.Windows.UserControls
{
    
    public partial class UC_Category : UserControl
    {
        public delegate void ClickBtnCategory(Category category);
        public event ClickBtnCategory CategoryClicked;
        Category category;
        public UC_Category(Category category)
        {
            InitializeComponent();
            this.category = category;
            btnGetCategoryItems.Text = category.Name;
        }

        private void btnGetCategoryItems_Click(object sender, EventArgs e)
        {
            CategoryClicked.Invoke(this.category);
        }
    }
}
