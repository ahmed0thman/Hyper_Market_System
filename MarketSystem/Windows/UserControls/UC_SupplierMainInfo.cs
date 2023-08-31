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
using BL;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_SupplierMainInfo : UserControl
    {
        Person CurrentSupplier;
        PersonType personType;
        bool EditFlag = false;
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        public UC_SupplierMainInfo(PersonType Ptype)
        {
            InitializeComponent();
            personType = Ptype;
            UC_PersonInfoCard.PersonCardClicked += UC_PersonInfoCard_PersonCardClicked;
            UC_PersonInfoCard.ButtonEditPersonClicked += UC_PersonInfoCard_ButtonEditPersonClicked;
            this.Disposed += UC_SupplierMainInfo_Disposed;
        }

        private void UC_SupplierMainInfo_Disposed(object sender, EventArgs e)
        {
            UC_PersonInfoCard.PersonCardClicked -= UC_PersonInfoCard_PersonCardClicked;
            UC_PersonInfoCard.ButtonEditPersonClicked -= UC_PersonInfoCard_ButtonEditPersonClicked;
        }

        private void UC_PersonInfoCard_ButtonEditPersonClicked(Person person)
        {
            CurrentSupplier = person;
            EditFlag = true;
            GetSupplierInfo();
        }

        private void UC_PersonInfoCard_PersonCardClicked(Person person)
        {
            CurrentSupplier = person;
            EditFlag = true;
            GetSupplierInfo();
        }

        private void GetSupplierInfo()
        {
            try
            {
                txtSupplierName.Text = CurrentSupplier.Name;
                txtSupplierPhone.Text = CurrentSupplier.Phone;
                txtSupplierPhone2.Text = CurrentSupplier.Phone2;
                txtSupplierDebt.Text = CurrentSupplier.Debt.ToString();
            }
            catch (Exception)
            {
            }
            
        }


        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            if (!MyTools.checkItemValidData(this, txtSupplierDebt, txtSupplierPhone, txtSupplierPhone2))
                return;
            if (EditFlag)
            {
                EditCurrentSupplier();
            }
            else
            {
                SaveNewSupplier();
            }
            EditFlag = false;
            DataRefreshed?.Invoke();
            MyTools.ClearUCWidget(this);
        }

        private void SaveNewSupplier()
        {
            string ID = GenerateID();
            Person Supplier = new Person()
            {
                Id = int.Parse(ID),
                Name = txtSupplierName.Text.Trim(),
                Phone = txtSupplierPhone.Text.Trim(),
                Phone2 = txtSupplierPhone2.Text.Trim(),
                Type = personType
            };
            PersonTbl.SavePerson(Supplier);
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Add,
                Description = Supplier.Name
            });
        }

        private string GenerateID()
        {
            string ID;
            while (true)
            {
                ID = GlobalFunc.RandomCode(5);
                if (!PersonTbl.FindPersonCode(ID))
                    return ID;
            }
        }

        private void EditCurrentSupplier()
        {
            Person EditedSupplier = new Person()
            {
                Id = CurrentSupplier.Id,
                Name = txtSupplierName.Text.Trim(),
                Phone = txtSupplierPhone.Text.Trim(),
                Phone2 = txtSupplierPhone2.Text.Trim(),
            };
            PersonTbl.EditPerson(EditedSupplier);
            ActivityTbl.SaveActivity(new Activitiy()
            {
                Employee = Program.EmpLogedin,
                Date = DateTime.Now,
                ActivityType = ActivityType.Edit,
                Description = EditedSupplier.Name
            });
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            if (CurrentSupplier is null)
                return;
            MyTools.ClearUCWidget(this);
            EditFlag = false;
        }
    }
}
