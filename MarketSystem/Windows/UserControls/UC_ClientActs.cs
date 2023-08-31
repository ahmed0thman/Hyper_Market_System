using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL.DB_Classes;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_ClientActs : UserControl
    {
        public UC_ClientActs()
        {
            InitializeComponent();
            UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;
        }

        private void UC_PersonInfoCard_PersonCardClicked(BL.Enitiies.Person person)
        {
        }
    }
}
