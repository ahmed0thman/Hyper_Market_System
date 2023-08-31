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
    public partial class UC_MachineOperationCard : UserControl
    {
        public UC_MachineOperationCard(int num)
        {
            InitializeComponent();
            lblBillCode.Text = num.ToString();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            using (var msg = new CustomeMessageDialogue("تأكيد حذف العملية؟", MessageType.Warning))
            {
                var result = msg.ShowDialog();
            }
        }
    }
}
