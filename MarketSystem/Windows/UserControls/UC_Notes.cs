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
    public partial class UC_Notes : UserControl
    {
        public UC_Notes()
        {
            InitializeComponent();
        }

        private void tglDtAlarm_Click(object sender, EventArgs e)
        {
            if (!tglDtAlarm.IsOn)
                transition.HideSync(dtNoteAlarm);
            else
                transition.ShowSync(dtNoteAlarm);
        }

        private void UC_Notes_Load(object sender, EventArgs e)
        {
            dtNoteAlarm.Hide();
            GetAllNotes();
        }

        private void GetAllNotes()
        {
            panelNotesContainer.Controls.Clear();
            for (int i = 0; i < 30; i++)
            {
                panelNotesContainer.Controls.Add(new UC_NoteCard());
            }
        }
    }
}
