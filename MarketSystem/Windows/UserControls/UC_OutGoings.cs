using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL.DB_Classes;
using BL.Enitiies;
using DL;

namespace MarketSystem.Windows.UserControls
{
    public partial class UC_OutGoings : UserControl
    {
        public delegate void RefreshWalet();
        public static event  RefreshWalet WaletRefreshed;
        string CurrentId;
        OutGoings CurrentOut;
        List<Employee> employees;
        bool windowLoaded = false;
        private Dictionary<string, string> dictAccounts;
        private List<BalanceMachine> AllAcounts = new List<BalanceMachine>();
        double billsDebts;
        public UC_OutGoings()
        {
            InitializeComponent();
            panelEmpsList.Hide();
            panelWaletEdit.Hide();
            dtOutgoing.Value = DateTime.Now;
            guna2DateTimePicker1.Value = DateTime.Now;
            getAllOutGoings();
            FillCbxEmps();
            GetAllAcounts();
            CalcAll();
            UC_Machines.MachineHandeled += UC_Machines_MachineHandeled;
        }

        private void UC_Machines_MachineHandeled()
        {
            GetAllAcounts();
        }

        private void GetAllAcounts(bool stop = false)
        {
            AllAcounts.Clear();
            dictAccounts = new Dictionary<string, string>();
            dictAccounts.Add("0", "الدرج");
            var accounts = MachineTbl.GetMachines();
            for (int i = 0; i < accounts.Rows.Count; i++)
            {
                BalanceMachine account = new BalanceMachine()
                {
                    Id = int.Parse(accounts.Rows[i][BalanceMachine.IDC].ToString()),
                    Name = accounts.Rows[i][BalanceMachine.NAMEC].ToString(),
                    Balance = double.Parse(accounts.Rows[i][BalanceMachine.BALANCEC].ToString())
                };
                dictAccounts.Add(accounts.Rows[i][BalanceMachine.IDC].ToString(), accounts.Rows[i][BalanceMachine.NAMEC].ToString());
                AllAcounts.Add(account);
            }
            if (stop)
                return;
            cbxAccounts.DataSource = new BindingSource(dictAccounts, null);
            cbxAccounts.DisplayMember = "Value";
            cbxAccounts.ValueMember = "Key";
            cbxAccounts.SelectedIndex = -1;
        }

        private void CalcAll()
        {
            double total = 0;
            for (int i = 0; i < dgvBillInfo.Rows.Count; i++)
            {
                total += double.Parse(dgvBillInfo.Rows[i].Cells["colPrice"].Value.ToString());
            }
            txtTotalOutgoings.Text = total.ToString();
        }

        private void FillCbxEmps()
        {
            Dictionary<int, string> dictEmps = new Dictionary<int, string>();
            employees = EmployeeTbl.GetEAllmployees();
            foreach (var emp in employees)
            {
                dictEmps.Add(emp.Id, emp.Name);
            }
            cbxEmps.DataSource = new BindingSource(dictEmps, null);
            cbxEmps.DisplayMember = "Value";
            cbxEmps.ValueMember = "Key";
        }

        private void getAllOutGoings(string type = "", string dt = "")
        {
            dgvBillInfo.DataSource = OutGoingsTbl.GetOutGoings(type, dt);
        }

        private void cbxOutgoingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOutgoingType.SelectedIndex != 0)
            {
                transition.HideSync(panelEmpsList);
                return;
            }
            if (!panelEmpsList.Visible)
                transition.ShowSync(panelEmpsList);
                
        }

        private void btnEditOutgoing_Click(object sender, EventArgs e)
        {
            if (CurrentId == "")
            {
                new CustomeMessageDialogue("اختر من الجدول العملية التى تريج تعديلها");
                return;
            }
            MyTools.checkItemValidData(this, txtWaletBalance);
            
            using (var msg = new CustomeMessageDialogue("تأكيد تعديل بيانات المصروف الحالى ؟ ", MessageType.Warning))
            {
                DialogResult result = msg.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    OutGoings outGoings = new OutGoings
                    {
                        Id = int.Parse(CurrentId),
                        Date = dtOutgoing.Value,
                        Type = cbxOutgoingType.Text,

                    };
                    bool done = double.TryParse(txtOutgoingPrice.Text.Trim(), out double price);
                    if (!done)
                    {
                        new CustomeMessageDialogue("أدخل قيمة صحيحة");
                        txtOutgoingPrice.SelectAll();
                        txtOutgoingPrice.Focus();
                        return;
                    }
                    if (cbxAccounts.SelectedIndex == 0)
                    {
                        WaletTbl.Minus(price - CurrentOut.Price);
                    }
                    else
                    {
                        int machineId = AllAcounts.Find(x => x.Name == CurrentOut.Account).Id;
                        MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                        {
                            Date = dtOutgoing.Value,
                            Machine = new BalanceMachine(machineId),
                            Price = price,
                            Type = price > CurrentOut.Price? OperationType.Transaction : OperationType.Deposit,
                            Details = "تعديل مصروف " + cbxOutgoingType.Text + "\n" + txtDetails.Text.Trim()
                        }
                        );
                        MachineTbl.Minus(price - CurrentOut.Price, machineId);
                        GetAllAcounts();
                    }
                    
                    
                    outGoings.Price = price;
                    if (cbxOutgoingType.SelectedIndex == 0)
                        outGoings.Description = cbxEmps.Text + " : " + txtDetails.Text;
                    else
                        outGoings.Description = txtDetails.Text;
                    OutGoingsTbl.EditOutGoing(outGoings);
                   
                    CurrentId = "";
                    MyTools.ClearUCWidget(this);
                    getAllOutGoings();
                    CalcAll();
                    WaletRefreshed?.Invoke();
                    GetCurrentWaletBalance();
                }
            }
        }

        private void btnDelelteOutgoing_Click(object sender, EventArgs e)
        {
            if (CurrentId == "")
            {
                new CustomeMessageDialogue("اختر من الجدول العملية التى تريج تعديلها");
                return;
            }
            using (var msg = new CustomeMessageDialogue("تأكيد حذف بيانات المصروف الحالى ؟ ", MessageType.Warning))
            {
                DialogResult result = msg.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    bool done = double.TryParse(txtOutgoingPrice.Text.Trim(), out double price);
                    if (done)
                    {
                        if (cbxAccounts.SelectedIndex == 0)
                        {
                            WaletTbl.Plus(price);
                        }
                        else
                        {
                            int machineId = AllAcounts.Find(x => x.Name == CurrentOut.Account).Id;
                            MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                            {
                                Date = dtOutgoing.Value,
                                Machine = new BalanceMachine(machineId),
                                Price = price,
                                Type = OperationType.Deposit,
                                Details = "حذف مصروف " + cbxOutgoingType.Text + "\n" + txtDetails.Text.Trim()
                            }
                            );
                            MachineTbl.Plus(price, machineId);
                            GetAllAcounts();
                        }
                        
                    }
                    OutGoingsTbl.DeleteOutGoing(CurrentId);
                    CurrentId = "";
                    MyTools.ClearUCWidget(this);
                    getAllOutGoings();
                    CalcAll();
                    WaletRefreshed?.Invoke();
                    GetCurrentWaletBalance();
                }
            }
        }

        private void UC_OutGoings_Load(object sender, EventArgs e)
        {
            GetCurrentWaletBalance();
            windowLoaded = true;
        }

        private void GetCurrentWaletBalance()
        {
            lblCurrentWalet.Text = WaletTbl.GeteWaletAMount().ToString();
        }

        private void btnShowPanelWaletEdit_Click(object sender, EventArgs e)
        {
            if (panelWaletEdit.Visible)
                transition.HideSync(panelWaletEdit);
            else
                transition.ShowSync(panelWaletEdit);
        }

        private void btnSaveWalet_Click(object sender, EventArgs e)
        {
            bool done = double.TryParse(txtWaletBalance.Text, out double amount);
            if (!done)
            {
                new CustomeMessageDialogue("أدخل قيمة صحيحة");
                txtWaletBalance.SelectAll();
                txtWaletBalance.Focus();
                return;
            }
            WaletTbl.UpdateWaletAMount(amount);
            txtWaletBalance.Text = "";
            transition.HideSync(panelWaletEdit);
            GetCurrentWaletBalance();
            WaletRefreshed?.Invoke();
        }

        private void btnSaveOutgoing_Click(object sender, EventArgs e)
        {
            if(cbxAccounts.SelectedIndex < 0)
            {
                new CustomeMessageDialogue("اختر الحساب");
                return;
            }
            MyTools.checkItemValidData(this, txtWaletBalance);
            OutGoings outGoings = new OutGoings
            {
                Date = dtOutgoing.Value,
                Type = cbxOutgoingType.Text,
                Account = cbxAccounts.Text
            };
            bool done = double.TryParse(txtOutgoingPrice.Text.Trim(), out double price);
            if (!done)
            {
                new CustomeMessageDialogue("أدخل قيمة صحيحة");
                txtOutgoingPrice.SelectAll();
                txtOutgoingPrice.Focus();
                return;
            }
            outGoings.Price = price;
            if (cbxOutgoingType.SelectedIndex == 0)
            {
                var emp = employees.Find(x => x.Name == cbxEmps.Text);
                if (price == emp.Salary - emp.Debt - billsDebts)
                {
                    EmployeeTbl.EditEmployeeDebt(new EmpOutgoings() { Employee = emp, Price = emp.Debt  * -1});
                    BillTbl.PayDebts(Person: emp.Id.ToString());
                    var RestBills = BillTbl.GetBill(BillType.Sell, person: emp.Id.ToString(), rest: true);
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
                    EmpOutgoings empOutgoings = new EmpOutgoings()
                    {
                        Employee = emp,
                        Date = DateTime.Now,
                        Price = emp.Debt + billsDebts,
                        Type = "تسديد سلفة",
                        Alarm = null,
                        Details = "تم خصم  " + ( emp.Debt + billsDebts ) + "من المرتب"

                    };

                    EmpOutgoingsTbl.SaveEmpOutgoing(empOutgoings);
                }
                outGoings.Description = cbxEmps.Text + " : " + txtDetails.Text;
                FillCbxEmps();
            }
            else
                outGoings.Description = txtDetails.Text;
            OutGoingsTbl.SaveOutGoing(outGoings);
            if(cbxAccounts.SelectedIndex == 0)
            {
                WaletTbl.Minus(outGoings.Price);
            }
            else
            {
                int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
                MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                {
                    Date = dtOutgoing.Value,
                    Machine = new BalanceMachine(machineId),
                    Price = price,
                    Type = OperationType.Transaction,
                    Details = "اضافة مصروف " +cbxOutgoingType.Text + "\n"+ txtDetails.Text.Trim()
                }
                );
                MachineTbl.Minus(price, machineId);
                GetAllAcounts();
            }
            WaletRefreshed?.Invoke();
            MyTools.ClearUCWidget(this);
            getAllOutGoings();
            CalcAll();
            GetCurrentWaletBalance();
        }

        private void dgvBillInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentId = dgvBillInfo.Rows[e.RowIndex].Cells["colId"].Value.ToString();
            cbxOutgoingType.Text = dgvBillInfo.Rows[e.RowIndex].Cells["colType"].Value.ToString();
            cbxAccounts.Text = dgvBillInfo.Rows[e.RowIndex].Cells["colAccount"].Value.ToString();
            txtOutgoingPrice.Text = dgvBillInfo.Rows[e.RowIndex].Cells["colPrice"].Value.ToString();
            dtOutgoing.Value = DateTime.Parse(dgvBillInfo.Rows[e.RowIndex].Cells["colDate"].Value.ToString());
            txtDetails.Text = dgvBillInfo.Rows[e.RowIndex].Cells["colDetails"].Value.ToString().Split(':')[0];
            CurrentOut = new OutGoings()
            {
                Id = int.Parse(CurrentId),
                Type = cbxOutgoingType.Text,
                Account = cbxAccounts.Text,
                Price = double.Parse(txtOutgoingPrice.Text),
                Date = dtOutgoing.Value,
                Description = txtDetails.Text
            };

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getAllOutGoings(type: cbxTypeFilter.Text);
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getAllOutGoings(dt: guna2DateTimePicker1.Value.ToString("d"));
        }

        private void cbxEmps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!windowLoaded)
                return;
            if (cbxEmps.Items.Count == 0 || cbxEmps.SelectedIndex == -1)
                return;
            try
            {
                var emp = employees.Find(x => x.Name == cbxEmps.Text);
                billsDebts = BillTbl.GetBill(BillType.Sell, person: emp.Id.ToString(), rest: true).Sum(x => x.Rest);
                txtOutgoingPrice.Text = (emp.Salary - emp.Debt - billsDebts).ToString();
            }
            catch (Exception)
            {
            }
           
        }
    }
}
