using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class BillPayment
    {
        public int BillId { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
        public string Details { get; set; }

        #region DataBase Info
        // Table namein database
        public static string BILLPAYMENT = "bill_payment";

        // Fields in database
        public static string IDC = "id";
        public static string BILLC = "bill";
        public static string PRICEC = "price";
        public static string DATEC = "_date";
        public static  string DETAILSC = "details";
        #endregion
    }
}
