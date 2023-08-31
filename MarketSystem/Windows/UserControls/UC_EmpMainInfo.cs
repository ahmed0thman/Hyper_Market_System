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
using DL.DB_Classes;
using BL;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_EmpMainInfo : UserControl
    {
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        private bool EditFlag = false;
        private Employee currentEmployee;
        public UC_EmpMainInfo()
        {
            InitializeComponent();
            UC_PersonInfoCard.ButtonEditPersonClicked += UC_PersonInfoCard_ButtonEditPersonClicked;
            UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;
            this.Disposed += UC_EmpMainInfo_Disposed;

        }

        private void UC_EmpMainInfo_Disposed(object sender, EventArgs e)
        {
            UC_PersonInfoCard.ButtonEditPersonClicked -= UC_PersonInfoCard_ButtonEditPersonClicked;
            UC_PersonInfoCard.PersonCardClicked -= UC_PersonInfoCard_PersonCardClicked;
        }

        private void UC_PersonInfoCard_PersonCardClicked(Person employee)
        {
            try
            {
                currentEmployee = (Employee)employee;
                ShowEmployeeInfo();
                EditFlag = true;
            }
            catch (Exception)
            {

            }
            
        }

        private void ShowEmployeeInfo()
        {
            txtEmpName.Text = currentEmployee.Name;
            txtEmpPhone.Text = currentEmployee.Phone;
            txtEmpSalary.Text = currentEmployee.Salary.ToString();
            txtCurrentDebt.Text = currentEmployee.Debt.ToString();
            cbxEmpPermissions.Text = currentEmployee.Permission.ToStr();
        }

        private void UC_PersonInfoCard_ButtonEditPersonClicked(Person employee)
        {
            currentEmployee = (Employee)employee;
            ShowEmployeeInfo();
            EditFlag = true;
        }

        private void btnSaveEmpInfo_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                if (currentEmployee is null) return;
                EditCurrnetEmployee();
            }
            else
                SaveNewEmployee();
            GetAllEmployees();
            MyTools.ClearUCWidget(this);
        }

        private void GetAllEmployees()
        {
            DataRefreshed?.Invoke();
        }

        private void SaveNewEmployee()
        {
            if (txtEmpName.Text == "")
                return;
            string ID = GenerateId();
            Person Employee = new Person()
            {
                Id = int.Parse(ID),
                Name = txtEmpName.Text.Trim(),
                Phone = txtEmpPhone.Text.Trim(),
                Type = PersonType.Employee
            };
            PersonTbl.SavePerson(Employee);

            Employee NewEmployee = new Employee()
            {
                Id = int.Parse(ID),
                Permission = cbxEmpPermissions.Text.ToEmpPermission(),
                Salary = txtEmpSalary.Text.Trim() == "" ? 0 : int.Parse(txtEmpSalary.Text),
                Username = txtEmpUserName.Text.Trim(),
                Password = txtEmpPassWord.Text.Trim()
            };
            EmployeeTbl.SaveEmployee(NewEmployee);
            Activitiy activitiy = new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Add,
                Description = NewEmployee.Name
            };
            ActivityTbl.SaveActivity(activitiy);
        }

        private string GenerateId()
        {
            string ID;
            while (true)
            {
                ID = GlobalFunc.RandomCode(5);
                if (!PersonTbl.FindPersonCode(ID))
                    return ID;
            }
        }

        private void EditCurrnetEmployee()
        {
            Person Employee = new Person()
            {
                Id = currentEmployee.Id,
                Name = txtEmpName.Text.Trim(),
                Phone = txtEmpPhone.Text.Trim(),
                Type = PersonType.Employee
            };
            PersonTbl.EditPerson(Employee);
            Employee EditedEmployee = new Employee()
            {
                Id = currentEmployee.Id,
                Permission = cbxEmpPermissions.Text.ToEmpPermission(),
                Salary = int.Parse(txtEmpSalary.Text.Trim()),
                Debt = currentEmployee.Debt
            };
            EmployeeTbl.EditEmployee(EditedEmployee);
            Activitiy activitiy = new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Edit,
                Description = currentEmployee.Name
            };
            ActivityTbl.SaveActivity(activitiy);
            EditFlag = false;
        }

        private void btnSaveEmpLoginInfo_Click(object sender, EventArgs e)
        {
            if (currentEmployee is null) return;
            using(var msg = new CustomeMessageDialogue("تأكيد تعديل بيانات الدخول للموظف", MessageType.Warning))
            {
                var res = msg.ShowDialog();
                if (res == DialogResult.No)
                    return;
            }
            if (txtEmpUserName.Text.Trim() == "" && txtEmpPassWord.Text.Trim() == "")
            {
                new CustomeMessageDialogue(" يجب ادخال كل من اسم المستخدم وكلمة المرور ");
                return;
            }
                
            Employee EditedEmployee = new Employee()
            {
                Id = currentEmployee.Id,
                Username = txtEmpUserName.Text.Trim(),
                Password = txtEmpPassWord.Text.Trim()
            };
            EmployeeTbl.EditEmployeeLoginInfo(EditedEmployee);
            Activitiy activitiy = new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Edit,
                Description = currentEmployee.Name
            };
            ActivityTbl.SaveActivity(activitiy);
            EditFlag = false;
            MyTools.ClearUCWidget(this);
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            if (currentEmployee is null)
                return;
            MyTools.ClearUCWidget(this);
            EditFlag = false;
        }
    }
}
