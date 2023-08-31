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
    #region MessageType Enumeation
    public enum MessageType
    {
        Normal, Warning, WarningCancel
    }
    #endregion

    #region ButtonType Enumeation
    public enum MsgResult
    {
        Yes, No, Ok
    }
    #endregion
    public partial class CustomeMessageDialogue : Form
    {

        MessageType MessageType;
        public CustomeMessageDialogue(string msg, MessageType msgType = MessageType.Normal)
        {
            InitializeComponent();
            btnYes.Hide();
            txtMessageInfo.Text = msg;
            MessageType = msgType;
            if (MessageType == MessageType.Warning)
            {
                btnYes.Show();
                btnNo.Text = "لا";
                btnClose.Hide();
            }
            else if (MessageType == MessageType.WarningCancel)
            {
                btnYes.Show();
                btnNo.Text = "لا";
            }
            if (msgType == 0)
                this.ShowDialog();
        }


        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
