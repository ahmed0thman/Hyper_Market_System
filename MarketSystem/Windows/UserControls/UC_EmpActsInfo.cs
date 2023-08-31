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
using DL.DB_Classes;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_EmpActsInfo : UserControl
    {
        Employee currentEmployee;
        public UC_EmpActsInfo()
        {
            InitializeComponent();
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
            UC_PersonInfoCard.ButtonEditPersonClicked += UC_PersonInfoCard_ButtonEditPersonClicked;
            UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;
            this.Disposed += UC_EmpActsInfo_Disposed;

        }

        private void UC_EmpActsInfo_Disposed(object sender, EventArgs e)
        {
            UC_PersonInfoCard.ButtonEditPersonClicked -= UC_PersonInfoCard_ButtonEditPersonClicked;
            UC_PersonInfoCard.PersonCardClicked -= UC_PersonInfoCard_PersonCardClicked;
        }

        private void UC_PersonInfoCard_PersonCardClicked(Person employee)
        {
            try
            {
                currentEmployee = (Employee)employee;
                GetEmpActs();
            }
            catch (Exception)
            {
            }
            
        }

        private void UC_PersonInfoCard_ButtonEditPersonClicked(Person employee)
        {
            currentEmployee = (Employee)employee;
            GetEmpActs();
        }

        private void UC_EmpActsInfo_Load(object sender, EventArgs e)
        {
            
            GetEmpActs();
        }

        private void GetEmpActs(string dtfrom = "", string dt2 = "", string actType = "")
        {
            if (currentEmployee is null)
            {
                return;
            }
                
            dgvEmpActs.DataSource =  ActivityTbl.GetActivities(currentEmployee, dtfrom, dt2, actType);
            dgvEmpActs.Refresh();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            GetEmpActs(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"));
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            GetEmpActs(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"));
        }

        private void cbxActType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxActType.SelectedIndex == 0)
                GetEmpActs(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"));
            else
                GetEmpActs(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"), cbxActType.Text);
        }
    }
}
