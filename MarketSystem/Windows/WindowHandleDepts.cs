using BL.Enitiies;
using DL;
using DL.DB_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSystem.Windows
{
    public partial class WindowHandleDepts : Form
    {
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        Person person;
        public WindowHandleDepts(Person person)
        {
            InitializeComponent();
            this.person = person;
            lblPersonName.Text = person.Name;
        }

        private void btnSaveDeptInfo_Click(object sender, EventArgs e)
        {
            bool done = double.TryParse(txtPrice.Text.Trim(), out double price);
            if (!done)
            {
                new CustomeMessageDialogue("أدخل قيمة صحيحة");
                txtPrice.SelectAll();
                txtPrice.Focus();
                return;
            }
            EmpOutgoings empOutgoings = new EmpOutgoings()
            {
                Employee = this.person,
                Date = DateTime.Now,
                Price = price,
                Type = cbxOperationType.Text,
                Alarm = tglAlarm.Checked ? dtDeptAlarm.Value.ToString("d") : null,
                Details = txtDetails.Text.Trim()

            };
            
            EmpOutgoingsTbl.SaveEmpOutgoing(empOutgoings);
            if (cbxOperationType.SelectedIndex == 1)
                empOutgoings.Price *= -1;
            EmployeeTbl.EditEmployeeDebt(empOutgoings);
            if (cbxOperationType.SelectedIndex == 1)
            {
                WaletTbl.Plus(price);
            }
            else if (cbxOperationType.SelectedIndex == 0)
            {
                WaletTbl.Minus(price);
            }
            DataRefreshed?.Invoke();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbxOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxOperationType.SelectedIndex == 0)
            //    trPanelAlarmInfo.ShowSync(panelAlarmInfo);
            //else
            //{
            //    trPanelAlarmInfo.HideSync(panelAlarmInfo);
            //    tglAlarm.Checked = false;
            //}
                
        }

        private void tglAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (tglAlarm.Checked)
                trPanelAlarmInfo.ShowSync(dtDeptAlarm);
            else
                trPanelAlarmInfo.HideSync(dtDeptAlarm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            using (CustomeMessageDialogue MsgBox = new CustomeMessageDialogue("لن يتم حفظ البيانات.", MessageType.Warning))
            {
                DialogResult result = MsgBox.ShowDialog();
                if (result == DialogResult.Yes)
                    this.Close();
                else return;
            }
        }

        private void WindowHandleDepts_Load(object sender, EventArgs e)
        {
            panelAlarmInfo.Hide();
        }
    }
}
