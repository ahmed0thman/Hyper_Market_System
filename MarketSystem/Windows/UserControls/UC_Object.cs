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
    public partial class UC_Object : UserControl
    {
        private Person person;
        public delegate void ClickBtnObject(Person person);
        public static event ClickBtnObject BtnObjectClicked;
        public UC_Object(Person person)
        {
            InitializeComponent();
            this.person = person;
        }

        private void btnObject_Click(object sender, EventArgs e)
        {
            BtnObjectClicked?.Invoke(person);
        }
    }
}
