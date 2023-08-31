using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    #region ActivityType Enumration 
    public enum ActivityType
    {
        Add = 0,
        Edit = 1,
        Delete = 2,
        CashOut = 3,
        CashIn = 4,
        NewBill = 5,
        NewCharge = 6,
        EditBill = 7,
        EditCharge = 8,
        DeleteBill = 9,
        DeleteCharge = 10
    }

    public static class ActivityTypeExtention
    {
        #region Friendly PersonType string
        public static string ToStr(this ActivityType activityType)
        {
            switch (activityType)
            {
                case ActivityType.Add:
                    return "اضافة";
                case ActivityType.Edit:
                    return "تعديل";
                case ActivityType.Delete:
                    return "حذف";
                case ActivityType.CashOut:
                    return "سحب دين";
                case ActivityType.CashIn:
                    return "دفع دين";
                case ActivityType.NewBill:
                    return "فاتورة جديدة";
                case ActivityType.NewCharge:
                    return "فاتورة شحن";
                case ActivityType.EditBill:
                    return "تعديل فاتورة";
                case ActivityType.EditCharge:
                    return "تعديل فاتورة شحن";
                case ActivityType.DeleteBill:
                    return "حذف فاتورة";
                case ActivityType.DeleteCharge:
                    return "حذف فاتورة شحن";
                default:
                    throw new ArgumentException("not a vaild Activity Type");
            }
        }

        public static ActivityType ToActivityType(this string activityType)
        {
            switch (activityType)
            {
                case "اضافة":
                    return ActivityType.Add;
                case "تعديل":
                    return ActivityType.Edit;
                case "حذف":
                    return ActivityType.Delete;
                case "سحب دين":
                    return ActivityType.CashOut;
                case "دفع دين":
                    return ActivityType.CashIn;
                case "فاتورة جديدة":
                    return ActivityType.NewBill;
                case "فاتورة شحن":
                    return ActivityType.NewCharge;
                case "تعديل فاتورة":
                    return ActivityType.EditBill;
                case "تعديل فاتورة شحن":
                    return ActivityType.EditCharge;
                case "حذف فاتورة":
                    return ActivityType.DeleteBill;
                case "حذف فاتورة شحن":
                    return ActivityType.DeleteCharge;
                default:
                    throw new ArgumentException("not a vaild Activity String");
            }
        }
        #endregion


    }
    #endregion
    public class Activitiy
    {
        #region Fields
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ActivityType ActivityType { get; set; }
        public Employee Employee { get; set; }
        public string Description { get; set; }
        #endregion

        #region Constructor
        public Activitiy()
        {

        }
        public Activitiy(int id)
        {

        }
        #endregion

        #region Database Info
        // Table Name
        public static string ACTIVITYTABLE = "activities";

        // Fields Names
        public static string IDC = "id";
        public static string TYPEC = "type";
        public static string DATEC = "_date";
        public static string EMPLOYEEC = "username";
        public static string DESCRIPTION = "description";
        #endregion

        #region Database Handling
        public bool Add()
        {
            return true;
        }
        public bool Edit(Activitiy activitiy)
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static Activitiy Get(int id)
        {
            return new Activitiy(id);
        }
        #endregion
    }
}
