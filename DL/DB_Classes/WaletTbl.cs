using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class WaletTbl
    {
        public static double GeteWaletAMount()
        {
            DBCon.DB.Open();
            string query = $"select amount from {Walet.WALETTABLE} limit 1";
            var tbl = DBCon.DB.GetData(query);
            double amount = double.Parse(tbl.Rows[0]["amount"].ToString());
            if (tbl.Rows.Count == 0)
            {
                DBCon.DB.Close();
                return 0;
            }
            DBCon.DB.Close();
            return amount;
        }

        public static void Plus(double amount)
        {
            UpdateWalet(amount);
        }

        public static void Minus(double amount)
        {
            UpdateWalet(amount, -1);
        }

        /// <summary>
        /// Update current walet amount
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        static void UpdateWalet(double amount, double op = 1)
        {
            DBCon.DB.Open();
            string query = $"update {Walet.WALETTABLE} set {Walet.AMOUNTC} =  {amount * op} + {Walet.AMOUNTC}";
            DBCon.DB.Run(query);
            DBCon.DB.Close();
        }
        public static void UpdateWaletAMount(double amount)
        {
            DBCon.DB.Open();
            string query = $"update {Walet.WALETTABLE} set {Walet.AMOUNTC} =  {amount }";
            DBCon.DB.Run(query);
            DBCon.DB.Close();
        }
    }
}
