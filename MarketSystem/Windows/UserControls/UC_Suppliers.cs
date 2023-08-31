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
    public partial class UC_Suppliers : UserControl
    {
        UC_PersonInfoCard Currentcard;
        UC_SupplierMainInfo UC_SupplierMainInfo;
        UC_SupplierActs UC_SupplierActs = new UC_SupplierActs() {Dock = DockStyle.Fill };
        List<Person> people;
        PersonType personType;
        public UC_Suppliers(PersonType Ptype)
        {
            InitializeComponent();
            personType = Ptype;
            UC_SupplierMainInfo = new UC_SupplierMainInfo(personType);
            UC_PersonInfoCard.PersonClicked += UC_PersonInfoCard_PersonClicked;
            UC_SupplierMainInfo.DataRefreshed += UC_SupplierMainInfo_DataRefreshed;
            UC_PersonInfoCard.DataRefreshed += UC_PersonInfoCard_DataRefreshed;
            UC_SupplierActs.waletRefreshed += UC_SupplierActs_waletRefreshed;
            this.Disposed += (s, a) =>
            {
                if (components != null)
                {
                    components.Dispose();
                }
                UC_PersonInfoCard.PersonClicked -= UC_PersonInfoCard_PersonClicked;
                UC_SupplierMainInfo.DataRefreshed -= UC_SupplierMainInfo_DataRefreshed;
                UC_PersonInfoCard.DataRefreshed -= UC_PersonInfoCard_DataRefreshed;
                UC_SupplierActs.waletRefreshed -= UC_SupplierActs_waletRefreshed;

                base.Dispose();
            };
        }

        private void UC_SupplierActs_waletRefreshed()
        {
            GetAllSuppliers();
        }

        private void UC_PersonInfoCard_DataRefreshed()
        {
            GetAllSuppliers();
        }

        private void UC_SupplierMainInfo_DataRefreshed()
        {
            GetAllSuppliers();
        }

        private void UC_PersonInfoCard_PersonClicked(UC_PersonInfoCard personCard)
        {
            try
            {
                if (Currentcard is null)
                {
                    Currentcard = personCard;
                    Currentcard.card.FillColor = Color.PaleGoldenrod;
                }
                else
                {
                    Currentcard.card.FillColor = Color.White;
                    Currentcard = personCard;
                    Currentcard.card.FillColor = Color.PaleGoldenrod;
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void btnShowUCMainInfo_Click(object sender, EventArgs e)
        {
            ShowPanelMainInfo();
        }

        private void ShowPanelMainInfo()
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_SupplierMainInfo);
        }

        private void ShowPanelActs()
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(UC_SupplierActs);
        }

        private void UC_Suppliers_Load(object sender, EventArgs e)
        {
            ShowPanelMainInfo();
            GetAllSuppliers();
        }

        private void GetAllSuppliers(string info = "", bool hasdebt = false)
        {
            
            panelSuppliersCards.Controls.Clear();
            if(personType == PersonType.Supplier)
            {
                if (hasdebt)
                    people = PersonTbl.GetPersonsWithDept(true, personType);
                else if (info == "")
                    people = PersonTbl.GetAllPersons(personType);
                else
                    people = PersonTbl.GetPerson(info, personType);
                if (people.Count == 0)
                    return;
            }
            else
            {
                if (hasdebt)
                    people = PersonTbl.GetPersonsButSupplier(true);
                else if (info == "")
                    people = PersonTbl.GetPersonsButSupplier();
                else
                    people = PersonTbl.GetPersonsButSupplier(info: info);
                if (people.Count == 0)
                    return;
            }
            
            foreach (var p in people)
            {
                panelSuppliersCards.Controls.Add(new UC_PersonInfoCard(p));
            }

            //if (panelSuppliersCards.Controls.Count > 5)
            //    panelSuppliersCards.Width += 15;
        }

        private void btnShowUCActs_Click(object sender, EventArgs e)
        {
            ShowPanelActs();
        }

        private void tglHasdept_CheckedChanged(object sender, EventArgs e)
        {
            panelSuppliersCards.Controls.Clear();
            if (tglHasdept.Checked)
            {
                foreach (var p in people.FindAll(x => x.DebtBill + x.Debt > 0))
                {
                    panelSuppliersCards.Controls.Add(new UC_PersonInfoCard(p));
                }
            }
            else
                GetAllSuppliers();
        }

        private void txtClientSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                GetAllSuppliers(txtClientSearch.Text.Trim());
        }

    }
}
