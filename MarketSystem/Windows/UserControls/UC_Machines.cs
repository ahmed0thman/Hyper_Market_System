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
    public partial class UC_Machines : UserControl
    {
        public delegate void HandleOperation();
        public static event HandleOperation OperationHandeled;
        public delegate void HandleMachine();
        public static event HandleMachine MachineHandeled;
        private BalanceMachine CurrentAccount;
        private MachineOperation CurrentOperation;
        private Dictionary<string, string> dictAccounts;
        private List<BalanceMachine> AllAcounts = new List<BalanceMachine>();
        bool windowLoaded = false;
        bool editMachineFlag = false;
        bool editOperationFlag = false;
        public UC_Machines()
        {
            InitializeComponent();
            GetAllAcounts();
            dtOperation.Value = DateTime.Now;
        }

        private void GetAllAcounts(bool stop = false)
        {
            AllAcounts.Clear();
            var accounts = MachineTbl.GetMachines();
            if (accounts.Rows.Count == 0)
                return;
            dictAccounts = new Dictionary<string, string>();
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
            cbxAccountTo.DataSource = new BindingSource(dictAccounts, null);
            cbxAccountTo.DisplayMember = "Value";
            cbxAccountTo.ValueMember = "Key";
        }

        private void UC_Machines_Load(object sender, EventArgs e)
        {
            panelMachineInfo.Hide();
            windowLoaded = true;


        }


        private void btnDeleteMachine_Click(object sender, EventArgs e)
        {
            using (var msg = new CustomeMessageDialogue("تأكيد حذف جميع بيانات الحساب؟", MessageType.Warning))
            {
                var result = msg.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    MachineTbl.DeleteMachine(AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id);
                    GetAllAcounts();
                    MachineHandeled?.Invoke();
                }
            }
        }

        private void btnNewMachine_Click(object sender, EventArgs e)
        {
            ShowPanelMachineInfo();
        }

        private void ShowPanelMachineInfo(bool flag = false)
        {
            if (panelMachineInfo.Visible)
                transition.HideSync(panelMachineInfo); 
            else
                transition.ShowSync(panelMachineInfo);
            //if (flag)
            //    txtMachineName.Enabled = false;
            //else
            //    txtMachineName.Enabled = true;
        }

        private void btnEditMachine_Click(object sender, EventArgs e)
        {
            ShowPanelMachineInfo(true);
            editMachineFlag = true;
            txtMachineName.Text = cbxAccounts.Text;
        }

        private void btnSaveMachineInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMachineName.Text.Trim() == "")
                {
                    txtMachineName.Focus();
                    new CustomeMessageDialogue("أدخل اسم الحساب");
                    return;
                }
                bool vailidBalance = double.TryParse(txtCurrentBalance.Text.Trim(), out double balance);
                if (!vailidBalance)
                {
                    txtCurrentBalance.SelectAll();
                    txtCurrentBalance.Focus();
                    new CustomeMessageDialogue("أدخل قيمة صحيحة");
                    return;
                }
                if (editMachineFlag)
                {
                    MachineTbl.EditMachine(
                        new BalanceMachine()
                        {
                            Id = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id,
                            Name = txtMachineName.Text.Trim(),
                            Balance = balance
                        }
                    );
                    editMachineFlag = false;
                }
                else
                {
                    MachineTbl.SaveMachine(
                        new BalanceMachine()
                        {
                            Name = txtMachineName.Text.Trim(),
                            Balance = balance
                        }
                    );
                    editMachineFlag = false;
                }
                GetAllAcounts();
                MyTools.ClearUCWidget(this);
                OperationHandeled?.Invoke();
            }
            catch (Exception)
            {
            }
            MachineHandeled?.Invoke();
            transition.HideSync(panelMachineInfo);
        }

        private void UC_Machines_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if (panelMachineInfo.Visible)
                    btnSaveMachineInfo.PerformClick();
                else
                    btnSaveMachineOperation.PerformClick();
            }
        }

        private void cbxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!windowLoaded) return;
                if (AllAcounts.Count == 0) return;
                var account = AllAcounts.Find(x => x.Name == cbxAccounts.Text);
                if (account is null) return;
                lblCurrentBalance.Text = account.Balance.ToString();
                GetAllOperations();
            }
            catch (Exception)
            {
            }
        }

        private void GetAllOperations()
        {
            dgvOperationInfo.DataSource = MachineArchiveTbl.GetMachineOperations(cbxAccounts.SelectedValue.ToString());
        }

        private void btnSaveMachineOperation_Click(object sender, EventArgs e)
        {
            bool validPrice = double.TryParse(txtPrice.Text.Trim(), out double price);
            if (!validPrice || price == 0)
            {
                txtPrice.SelectAll();
                txtPrice.Focus();
                new CustomeMessageDialogue("أدخل قيمة صحيحة");
                return;
            }
            int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
            MachineArchiveTbl.SaveMachineOperation(new MachineOperation()
                {
                    Date = dtOperation.Value,
                    Machine = new BalanceMachine(machineId),
                    Price = price,
                    Type = cbxType.Text.ToOperationTypee(),
                    Details = txtDetails.Text.Trim()
                }
            );
            MyTools.ClearUCWidget(this, cbxAccounts);
            if(cbxType.SelectedIndex == 0)
                MachineTbl.Minus(price, machineId);
            else if(cbxType.SelectedIndex == 1)
                MachineTbl.Plus(price, machineId);
            else if(cbxType.SelectedIndex == 2)
            {
                int machineId2PutInto = AllAcounts.Find(x => x.Name == cbxAccountTo.Text).Id;
                MachineTbl.Minus(price, machineId);
                MachineTbl.Plus(price, machineId2PutInto);
            }
            GetAllOperations();
            GetAllAcounts(true);
            lblCurrentBalance.Text = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Balance.ToString();
            OperationHandeled?.Invoke();
        }

        private void dgvOperationInfo_KeyDown(object sender, KeyEventArgs e)
        {
            return;
            if (dgvOperationInfo.RowCount == 0)
                return;
            if(e.KeyData == Keys.Delete)
            {
                using(var msg = new CustomeMessageDialogue("تأكيد حذف العلمية", MessageType.Warning))
                {
                    var res = msg.ShowDialog();
                    if (res != DialogResult.Yes)
                        return;
                    int machineId = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Id;
                    double price = double.Parse(dgvOperationInfo.CurrentRow.Cells["colPrice"].Value.ToString());
                    int operationId = int.Parse(dgvOperationInfo.CurrentRow.Cells["colId"].Value.ToString());
                    OperationType operation = dgvOperationInfo.CurrentRow.Cells["colOperationType"].Value.ToString().ToOperationTypee();
                    MachineArchiveTbl.DeleteMachineOperation(operationId);
                    if(operation == OperationType.Transaction)
                    MachineTbl.Plus(price, machineId);
                    else if (operation == OperationType.Deposit)
                        MachineTbl.Minus(price, machineId);
                    GetAllAcounts(true);
                    GetAllOperations();
                    lblCurrentBalance.Text = AllAcounts.Find(x => x.Name == cbxAccounts.Text).Balance.ToString();
                    OperationHandeled?.Invoke();
                }
            }
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex == 2)
                transition.ShowSync(pnlToAccount);
            else
                transition.HideSync(pnlToAccount);
        }

        private void dgvOperationInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetails.Text = dgvOperationInfo.CurrentRow.Cells["colDetails"].Value.ToString();
        }
    }
}
