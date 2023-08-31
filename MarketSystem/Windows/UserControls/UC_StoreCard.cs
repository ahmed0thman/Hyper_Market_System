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
using DL.DB_Classes;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_StoreCard : UserControl
    {
        Store currentStore;
        public delegate void ClickStoreCard(Store store);
        public static event ClickStoreCard StoreCardClicked;
        public delegate void EditStore(Store store);
        public static event EditStore StoreEditClicked;
        public delegate void RefershData();
        public static event RefershData DataRefreshed;
        public UC_StoreCard(Store store)
        {
            InitializeComponent();
            currentStore = store;
            btnStore.Text = store.Name;
        }


        private void btnStore_Click(object sender, EventArgs e)
        {
            StoreCardClicked?.Invoke(currentStore);
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            var msg = new CustomeMessageDialogue( "تأكيد حذف جميع البيانات الخاصة بالمخزن", MessageType.Warning);
            var result = msg.ShowDialog();
            if (result == DialogResult.Yes)
            {
                StoreTbl.DeleteStore(currentStore);
                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.Delete,
                    Description = currentStore.Name
                });
                ActivityTbl.SaveActivity(new Activitiy()
                {
                    Employee = Program.EmpLogedin,
                    Date = DateTime.Now,
                    ActivityType = ActivityType.Delete,
                    Description = currentStore.Name
                });
                DataRefreshed?.Invoke();
            }
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            StoreEditClicked?.Invoke(currentStore);
        }
    }
}
