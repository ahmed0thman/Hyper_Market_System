using BL.Enitiies;
using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketSystem.Windows;

namespace MarketSystem
{
    public partial class FormLgn : Form
    {
        public FormLgn()
        {
            InitializeComponent();
            //this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            LogIN();
        }

        private void LogIN()
        {
            try
            {
                List<Employee> Emps = EmployeeTbl.CheckEmployee(txtUserName.Text.Trim());
                if (Emps.Count == 0)
                {

                    new CustomeMessageDialogue("اسم المستخدم خطأ");
                    txtUserName.SelectAll();
                    txtUserName.Focus();
                    return;
                }
                string password = txtPassword.Text.Trim();
                if (!Emps.Any(x => x.Password == password))
                {
                    new CustomeMessageDialogue("كلمة السر خطأ");
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                    return;
                }
                Program.EmpLogedin = Emps.Find(x => x.Password == password);
                Program.frm = new Form1();
                Program.frm.Show();
                this.Hide();
            }
            catch (Exception)
            {

                new CustomeMessageDialogue("فشل الاتصال بالسيرفر");
            }
            
           
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LogIN();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LogIN();
        }

        private void FormLgn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LogIN();
        }
    }
}
