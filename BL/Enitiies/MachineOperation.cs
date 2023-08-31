using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    #region OperationType Enumration 
    public enum OperationType
    {
        Deposit = 0,
        Transaction = 1,
        Transefer = 2,
        TranseferIn = 3

    }

    public static class OperationTypeExtention
    {
        #region Friendly PersonType string
        public static string ToStr(this OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Deposit:
                    return "ايداع";
                case OperationType.Transaction:
                    return "سحب";
                case OperationType.Transefer:
                    return "تحويل";
                case OperationType.TranseferIn:
                    return "استقبال";
                default:
                    throw new ArgumentException("not a vaild Operation Type");
            }
        }

        public static OperationType ToOperationTypee(this string operationType)
        {
            switch (operationType)
            {
                case "ايداع":
                    return OperationType.Deposit;
                case "سحب":
                    return OperationType.Transaction;
                case "تحويل":
                    return OperationType.Transefer;
                case "استقبال":
                    return OperationType.TranseferIn;

                default:
                    throw new ArgumentException("not a vaild OperationType string");
            }
        }
        #endregion


    }
    #endregion
    public class MachineOperation
    {
        #region Fields
        public int Id { get; set; }
        public OperationType Type { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public BalanceMachine Machine { get; set; }
        public string Details { get; set; }
        #endregion

        #region Constructor
        public MachineOperation()
        {

        }
        public MachineOperation(int id) => Id = id;
        #endregion

        #region Database Info
        // Table Name
        public static string MACHINEOPERATIONTABLE = "machine_archive";
        // Fields Names
        public static string IDC = "id";
        public static string TYPEC = "type";
        public static string PRICEC = "price";
        public static string DATEC = "_date";
        public static string MACHINEC = "account";
        public static string DETAILSC = "details";
        #endregion

        #region Database Handling
        public bool Add()
        {
            if (!Machine.IsAvailable(this.Price)) return false;
            return true;
        }
        public bool Edit(MachineOperation machineOperation)
        {
            if (this.Price == machineOperation.Price)
                return true;
            if (this.Price > machineOperation.Price)
                if (!this.Machine.IsAvailable(this.Price - machineOperation.Price)) return false;
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static MachineOperation Get(int id)
        {
            return new MachineOperation(id);
        }
        #endregion

    }
}
