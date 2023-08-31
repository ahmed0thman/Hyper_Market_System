using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class EmpOutgoingsTbl
    {

        public static bool SaveEmpOutgoing(EmpOutgoings empOutgoings)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {EmpOutgoings.EMPOUTGIONGSTABLE} ({EmpOutgoings.EMPLOYEEC}, {EmpOutgoings.DATEC}, {EmpOutgoings.TYPEC}, " +
                $"{EmpOutgoings.PRICEC}, {EmpOutgoings.ALARMC}, {EmpOutgoings.DETAILSC}) values" +
                $" ('{empOutgoings.Employee.Id}', '{empOutgoings.Date.ToString("d")}', '{empOutgoings.Type}'" +
                $", '{empOutgoings.Price}', '{empOutgoings.Alarm}', '{empOutgoings.Details}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                throw;
            }
            
            DBCon.DB.Close();
            return done;
        }

        public static DataTable GetAllEmpOutgoings(Person person, string dtfrm = "", string dt2 = "", string actType = "")
        {
            DBCon.DB.Open();
            try
            {
                string subquery = "";
                if (dtfrm != "" && dt2 != "")
                    subquery = $" and {EmpOutgoings.DATEC} between '{dtfrm}' and '{dt2}'";
                if (actType != "")
                    subquery += $" and {EmpOutgoings.TYPEC} = '{actType}'";
                string query = $"select {EmpOutgoings.DATEC}, {EmpOutgoings.TYPEC}, {EmpOutgoings.PRICEC}, {EmpOutgoings.DETAILSC} from {EmpOutgoings.EMPOUTGIONGSTABLE} where {EmpOutgoings.EMPLOYEEC} = '{person.Id}' {subquery}";
                var tbl = DBCon.DB.GetData(query);
                return tbl;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new DataTable();
        }
        public static double GetAllEmpOutgoingsInDate(string dt = "", string actType = "")
        {
            DBCon.DB.Open();
            try
            {
                string subquery = "";
                if (dt != "")
                    subquery = $" where {EmpOutgoings.DATEC} like '%{dt}%' ";
                if (actType != "")
                    subquery += $" and {EmpOutgoings.TYPEC} = '{actType}'";
                string query = $"select sum({EmpOutgoings.PRICEC}) from {EmpOutgoings.EMPOUTGIONGSTABLE}" +
                    $" {subquery}";
                var tbl = DBCon.DB.GetData(query);
                if(tbl.Rows.Count ==0 || tbl.Rows[0][0].ToString().Trim() == "")
                    return 0;
                return double.Parse(tbl.Rows[0][0].ToString().Trim());
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return 0;
        }
    }
}
