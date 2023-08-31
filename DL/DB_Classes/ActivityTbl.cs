using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class ActivityTbl
    {
        public static bool SaveActivity(Activitiy activitiy)
        {
            bool done = false;
            try
            {
                
                DBCon.DB.Open();
                string query = $"insert into {Activitiy.ACTIVITYTABLE} ({Activitiy.TYPEC}, {Activitiy.DATEC}, {Activitiy.EMPLOYEEC}, {Activitiy.DESCRIPTION})" +
                    $" values ('{activitiy.ActivityType.ToStr()}', '{activitiy.Date.ToString("u")}', '{activitiy.Employee.Id}', '{activitiy.Description}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {

            }
            DBCon.DB.Close();
            return done;
        }

        public static DataTable GetActivities(Employee emp, string dtfrm = "", string dt2 = "", string actType = "")
        {
            try
            {
                DBCon.DB.Open();
                string subquery = "";
                if (dtfrm != "" && dt2 != "")
                    subquery = $" and {Activitiy.DATEC} between '{dtfrm}' and '{dt2}'";
                if (actType != "")
                    subquery += $" and {Activitiy.TYPEC} = '{actType}'";
                string query = $"select {Activitiy.DATEC}, {Activitiy.TYPEC}, {Activitiy.DESCRIPTION}" +
                    $" from {Activitiy.ACTIVITYTABLE} where {Activitiy.EMPLOYEEC} = '{emp.Id}' {subquery}";
                var activities = DBCon.DB.GetData(query);
                return activities;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }

            DBCon.DB.Close();
            return new DataTable();
        }
    }
}
