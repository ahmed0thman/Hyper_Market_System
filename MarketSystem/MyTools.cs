using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MarketSystem.Windows;

namespace MarketSystem
{
    public static class MyTools
    {

        public static void ClearWidget(Panel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is Guna2TextBox txt)
                    txt.Text = "";
                else if (control is Panel pnl)
                    ClearWidget(pnl);
            }
        }
        public static void ClearUCWidget(UserControl parent, params Control[] except)
        {
            foreach (var control in parent.Controls)
            {
                if (except.Contains(control))
                    continue;
                if (control is Guna2TextBox txt)
                    txt.Text = "";
                else if (control is Panel pnl)
                    ClearWidget(pnl);
            }
        }

        public static bool checkItemValidData(UserControl parent, params Control[] except)
        {
            foreach (Control control in parent.Controls)
            {
                if (except.Contains(control))
                    continue;
                if (control is Guna2TextBox txt)
                    if (txt.Text.Trim() == "" || txt.Text.Trim() == "0")
                    {
                        new CustomeMessageDialogue("تأكد من صحة البيانات");
                        txt.Focus();
                        return false;
                    }
                if (control is Guna2ComboBox cbx)
                    if (cbx.SelectedIndex == -1)
                    {
                        new CustomeMessageDialogue("تأكد من صحة البيانات");
                        cbx.Focus();
                        return false;
                    }
            }
            return true;
        }
    }
}
