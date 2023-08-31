using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public static class Walet
    {
        #region Fields
        public static double Amount { get; set; }
        #endregion

        #region Database Info
        // Table Name
        public static string WALETTABLE = "Walet";

        //Fields Names
        public static string AMOUNTC = "amount";
        #endregion

        #region Methods
        public static new string ToString() => $"Current amount in walet: {Amount}";
        #endregion

        #region Database Handling
        public static bool Add(double amount)
        {
            return true;
        }
        public static bool Edit(double amount)
        {
            return true;
        }
        public static bool Delete(double amount)
        {
            return true;
        }
        public static double Get()
        {
            return Double.MinValue ;
        }
        #endregion
    }
}
