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
using DL;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_Employee : UserControl
    {
        UC_PersonInfoCard Currentcard;
        UC_EmpMainInfo UC_EmpMainInfo = new UC_EmpMainInfo() { Dock = DockStyle.Fill };
        UC_EmpActsInfo UC_EmpActsInfo = new UC_EmpActsInfo() { Dock = DockStyle.Fill };
        UC_EmpDepts UC_EmpDepts = new UC_EmpDepts() { Dock = DockStyle.Fill };
        List<Employee> emps;
        public UC_Employee()
        {
            InitializeComponent();
            UC_EmpMainInfo.DataRefreshed += UC_EmpMainInfo_DataRefreshed;
            UC_PersonInfoCard.PersonClicked += UC_PersonInfoCard_PersonClicked;
            WindowHandleDepts.DataRefreshed += WindowHandleDepts_DataRefreshed;
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                UC_EmpMainInfo.DataRefreshed -= UC_EmpMainInfo_DataRefreshed;
                UC_PersonInfoCard.PersonClicked -= UC_PersonInfoCard_PersonClicked;
                WindowHandleDepts.DataRefreshed -= WindowHandleDepts_DataRefreshed;

                base.Dispose();
            };
        }

        private void WindowHandleDepts_DataRefreshed()
        {
            txtClientSearch.Text = "";
            tglHasdept.Checked = false;
            GetAllEmployee();
        }

        private void UC_PersonInfoCard_PersonClicked(UC_PersonInfoCard personCard)
        {
            if (Currentcard is null)
            {
                Currentcard = personCard;
                Currentcard.card.FillColor = Color.PaleGoldenrod;
            }
            else
            {
                Currentcard.card.FillColor = Color.White;
                Currentcard = personCard;
                Currentcard.card.FillColor = Color.PaleGoldenrod;
            }
        }


        private void UC_EmpMainInfo_DataRefreshed()
        {
            txtClientSearch.Text = "";
            tglHasdept.Checked = false;
            GetAllEmployee();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_EmpMainInfo);
            panelEmpCards.Controls.Clear();
            GetAllEmployee();
        }

        private void GetAllEmployee(string info = "", bool hasdebt = false)
        {
            
            panelEmpCards.Controls.Clear();
            if (hasdebt)
                emps = EmployeeTbl.GetEmployeesWithDept();
            else if (info == "")
                 emps = EmployeeTbl.GetEAllmployees(); 
            else
                emps = EmployeeTbl.GetEmployee(info);
            foreach (var emp in emps)
            {
                panelEmpCards.Controls.Add(new UC_PersonInfoCard(emp));
            }

            if (panelEmpCards.Controls.Count > 5)
                panelEmpCards.Width += 15;
        }

        private void btnShowUCMainInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_EmpMainInfo);
        }

        private void btnShowUCActs_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_EmpActsInfo);
        }

        private void btnShowUCDepts_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_EmpDepts);
            
        }

        private void txtClientSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
                GetAllEmployee(txtClientSearch.Text);
        }

        private void txtClientSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtClientSearch.Text == "")
                GetAllEmployee();
            else
                panelEmpCards.Controls.Clear();
        }

        private void tglHasdept_CheckedChanged(object sender, EventArgs e)
        {
            panelEmpCards.Controls.Clear();
            if (tglHasdept.Checked)
            {
                foreach (var p in emps.FindAll(x => x.DebtBill + x.Debt > 0))
                {
                    panelEmpCards.Controls.Add(new UC_PersonInfoCard(p));
                }
            }
            else
                GetAllEmployee();
        }
    }
}
