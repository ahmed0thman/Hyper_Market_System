using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class OutGoingsTbl
    {
        public static string GetLastId()
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select max({OutGoings.IDC}) from {OutGoings.OUTGIONGSTABLE}";
                var lastId = DBCon.DB.GetData(query).Rows[0][0].ToString();
                return lastId;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            
            DBCon.DB.Close();
            return "";
        }
        public static bool SaveOutGoing(OutGoings outGoings)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {OutGoings.OUTGIONGSTABLE} ({OutGoings.TYPEC}, {OutGoings.PRICEC}, {OutGoings.DATEC}, {OutGoings.DESCRIPTIONC}, {OutGoings.ACCOUNTC})" +
                $" values ('{outGoings.Type}', '{outGoings.Price}',  '{outGoings.Date}', '{outGoings.Description}', '{outGoings.Account}') ";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool EditOutGoing(OutGoings outGoings)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {OutGoings.OUTGIONGSTABLE} set {OutGoings.TYPEC} = '{outGoings.Type}', " +
                $"{OutGoings.PRICEC} = '{outGoings.Price}', {OutGoings.DATEC} = '{outGoings.Date}'," +
                $" {OutGoings.DESCRIPTIONC} = '{outGoings.Description}' where {OutGoings.IDC} = '{outGoings.Id}' ";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteOutGoing(string id)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from  {OutGoings.OUTGIONGSTABLE} where {OutGoings.IDC} = '{id}' ";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static DataTable GetOutGoings(string type = "", string dt = "")
        {
            DBCon.DB.Open();
            try
            {
                string subquery = "";
                if (type != "")
                    subquery = $" where {OutGoings.TYPEC} = '{type}'";
                if (dt != "")
                    subquery = $" where {OutGoings.DATEC} like '%{dt}%'";
                string query = $"select * from {OutGoings.OUTGIONGSTABLE} {subquery}";
                var outgoings = DBCon.DB.GetData(query);
                return outgoings;
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
