using BL.Enitiies;
using Guna.UI2.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketSystem.Windows.UserControls;

namespace MarketSystem.Windows
{
    public partial class FormWindowContainer : Form
    {
        public delegate void CloseForm(UserControl userControl);
        public static event CloseForm FormClosed;
        UserControl Child;
        public FormWindowContainer(UserControl window, string title, bool canBeMaxmized = false)
        {
            InitializeComponent();
            Child = window;
            if (Program.EmpLogedin.Permission == EmpPermission.Cashier)
            {
                if (!(window is UC_Bill || window is UC_Suppliers))
                {
                    new CustomeMessageDialogue("ليس لديك صلاحية لفتح هذة الشاشة");
                    return;
                }
            }
            this.Size = new Size(window.Width, window.Height + BarHeader.Height);
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadChildWindow(window, title);
            btnMaximize.Enabled = true;
            this.Show();
            this.Location = new Point(0, 0);
            Form1.LogoedOut += Form1_LogoedOut;
            

        }

        private void Form1_LogoedOut()
        {
            this.Close();
        }

        private void LoadChildWindow(UserControl window, string title)
        {
            panelContainer.Controls.Add(window);
            window.Dock = DockStyle.Fill;
            lblHeader.Text = title;
            this.Text = title;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (Child is UC_Bill)
            {
                using (var msg = new CustomeMessageDialogue("اغلاق شاشة الفاتورة", MessageType.Warning))
                {
                    var res = msg.ShowDialog();
                    if (res == DialogResult.Yes)
                    {
                        FormClosed?.Invoke(Child);
                    }
                    else return;
                }
            }
            
            
            this.Close();
        }
    }
}
