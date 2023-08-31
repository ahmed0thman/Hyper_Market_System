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
    public partial class panelNoInformation : UserControl
    {
        public panelNoInformation(string msg, string imgsrc)
        {
            InitializeComponent();
            lblMsgInfo.Text = msg;
            picIcon.Image = Image.FromFile(imgsrc);
        }
    }
}
