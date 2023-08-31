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
using DL;
using DL.DB_Classes;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_PersonInfoCard : UserControl
    {
        private Person person;
        public delegate void ClieckPersonCard(Person person);
        public static event ClieckPersonCard PersonCardClicked;
        public delegate void ClieckPerson(UC_PersonInfoCard personCard);
        public static event ClieckPerson PersonClicked;
        public delegate void ClickEditPersonButton(Person person);
        public static event ClickEditPersonButton ButtonEditPersonClicked;
        public delegate void RefreshData();
        public static event RefreshData DataRefreshed;
        public delegate void PayDebts();
        public static event PayDebts DebtsPaied;
        public UC_PersonInfoCard(Person employee)
        {
            InitializeComponent();
            this.person = employee;
            ShowEmployeeData();
            //if (person.Type == PersonType.Employee)
            //    btnPayAllDebts.Hide();
        }

        private void ShowEmployeeData()
        {
            if (person.Type == PersonType.Client)
                person.DebtBill = BillTbl.GetBill(BillType.Sell, person:person.Id.ToString()).Sum(x => x.Rest);
            else if (person.Type == PersonType.Supplier)
                person.DebtBill = BillTbl.GetBill(BillType.Buy, person: person.Id.ToString()).Sum(x => x.Rest);
            else if (person.Type == PersonType.Employee)
            {
                person.DebtBill = BillTbl.GetBill(BillType.Sell, person: person.Id.ToString()).Sum(x => x.Rest);
                
            }
                
            lblPersonName.Text = person.Name;
            lblPersonPhone.Text = person.Phone;
            lblPersonDept.Text = (person.Debt + person.DebtBill).ToString();
            

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            using (CustomeMessageDialogue Msg = new CustomeMessageDialogue($"حذف جميع البيانات الخاصة ب {person.Name} سيحذف ايضا جميع الفواتير الملحقة معة", MessageType.Warning))
            {
                DialogResult result = Msg.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(person.Id + " " + person.Type.ToStr());
                    if (person.Type == PersonType.Employee)
                    {
                        EmployeeTbl.DeleteEmployee((Employee)person);
                    }
                    else
                        PersonTbl.DeletePerson(person);
                    DataRefreshed?.Invoke();
                }
                    
                return;
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            ButtonEditPersonClicked?.Invoke(person);
        }

        private void picEmployee_Click(object sender, EventArgs e)
        {
            PersonCardClicked?.Invoke(person);
            PersonClicked?.Invoke(this);
        }

        private void btnPayAllDebts_Click(object sender, EventArgs e)
        {
            if (person.Debt + person.DebtBill == 0) return;
            using (var msg = new CustomeMessageDialogue($"تأكيد دفع ديون لل{person.Type.ToStr()} {person.Name} ", MessageType.Warning))
            {
                var res = msg.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    
                    List<Bill> RestBills;
                    if(person.Type != PersonType.Supplier)
                    {
                        //WaletTbl.Plus(person.DebtBill);
                        RestBills = BillTbl.GetBill(BillType.Sell, person: person.Id.ToString(), rest: true).FindAll(x => x.Rest > 0);
                        foreach (var bill in RestBills)
                        {
                            WaletTbl.Plus(bill.Rest);
                            BillPayment billPayment = new BillPayment()
                            {
                                DateTime = DateTime.Now,
                                Price = bill.Rest,
                                BillId = bill.Id
                            };
                            BillPaymentTbl.AddPayment(billPayment);
                        }
                    }

                    else if (person.Type == PersonType.Supplier)
                    {
                        WaletTbl.Minus(person.DebtBill);
                        RestBills = BillTbl.GetBill(BillType.Buy, person: person.Id.ToString()).FindAll(x => x.Rest > 0);
                        foreach (var bill in RestBills)
                        {
                            BillPayment billPayment = new BillPayment()
                            {
                                DateTime = DateTime.Now,
                                Price = bill.Rest,
                                BillId = bill.Id
                            };
                            BillPaymentTbl.AddPayment(billPayment);
                        }
                    }
                    BillTbl.PayDebts(Person: person.Id.ToString());
                    lblPersonName.Text = person.Name;
                    person.DebtBill = 0;
                    lblPersonDept.Text = $"{person.Debt + person.DebtBill}";
                    PersonCardClicked?.Invoke(person);
                    DebtsPaied?.Invoke();
                }
            }
            
        }
    }
}
