using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_Clients : UserControl
    {
        UC_ClientMainInfo UC_ClientMainInfo = new UC_ClientMainInfo();
        UC_ClientActs UC_ClientActs = new UC_ClientActs();
        public UC_Clients()
        {
            InitializeComponent();
        }

        private void UC_Clients_Load(object sender, EventArgs e)
        {
            ShowPanelMainInfo();
            GetClientsCards();
        }

        private void GetClientsCards()
        {
            panelClientsCards.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                //panelClientsCards.Controls.Add(new UC_PersonInfoCard());
            }
        }

        private void ShowPanelMainInfo()
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_ClientMainInfo);
        }

        private void btnShowUCMainInfo_Click(object sender, EventArgs e)
        {
            ShowPanelMainInfo();
        }

        private void btnShowUCActs_Click(object sender, EventArgs e)
        {
            ShowActs();
        }

        private void ShowActs()
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_ClientActs);
        }
    }
}
