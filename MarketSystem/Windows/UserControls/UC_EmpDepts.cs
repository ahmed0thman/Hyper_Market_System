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
    public partial class UC_EmpDepts : UserControl
    {
        private Employee currentEmployee;
        
        public UC_EmpDepts()
        {
            InitializeComponent();
            UC_PersonInfoCard.ButtonEditPersonClicked += UC_PersonInfoCard_ButtonEditPersonClicked;
            UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;
            this.Disposed += UC_EmpDepts_Disposed;

        }

        private void UC_EmpDepts_Disposed(object sender, EventArgs e)
        {
            UC_PersonInfoCard.ButtonEditPersonClicked -= UC_PersonInfoCard_ButtonEditPersonClicked;
            UC_PersonInfoCard.PersonCardClicked -= UC_PersonInfoCard_PersonCardClicked;
        }

        private void UC_PersonInfoCard_PersonCardClicked(Person employee)
        {
            try
            {
                currentEmployee = (Employee)employee;
                GetAllDepts();
            }
            catch (Exception)
            {
            }
            
        }

       
        private void btnShowDeptWindow_Click(object sender, EventArgs e)
        {
            if(currentEmployee is null)
            {
                new CustomeMessageDialogue("رجاء قم باختيار الموظف");
                return;
            }
            using(WindowHandleDepts WindowDept = new WindowHandleDepts(currentEmployee))
            {
                var res = WindowDept.ShowDialog();
                if(res == DialogResult.OK)
                {
                    GetAllDepts();
                }                
            }
        }
        private void UC_PersonInfoCard_ButtonEditPersonClicked(Person employee)
        {
            currentEmployee = (Employee)employee;
            GetAllDepts();
        }
        private void GetAllDepts(string dtfrm = "", string dtTo = "", string type = "")
        {
            dgvDebts.DataSource = EmpOutgoingsTbl.GetAllEmpOutgoings(currentEmployee, dtfrm, dtTo, type);
            dgvDebts.Refresh();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            GetAllDepts(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"));
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            GetAllDepts(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"));
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxType.SelectedIndex == 0)
                GetAllDepts(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"));
            else
                GetAllDepts(dtFrom.Value.ToString("d"), dtTo.Value.ToString("d"), cbxType.Text);
        }
    }
}
