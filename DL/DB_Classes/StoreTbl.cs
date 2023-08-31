using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class StoreTbl
    {
        public static bool SaveStore(Store store)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {Store.STORETABLE} ({Store.NAMEC}, {Store.EMPLOYEEC}, {Store.PHONEC}, {Store.ADDRESSC})" +
                $"values ('{store.Name}', '{store.Employee.Id}', '{store.Phone}', '{store.Address}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            
            DBCon.DB.Close();
            return done;
        }

        public static bool EditStore(Store store)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {Store.STORETABLE} set {Store.NAMEC} = '{store.Name}', {Store.EMPLOYEEC} = '{store.Employee.Id}'," +
                $" {Store.PHONEC} = '{store.Phone}', {Store.ADDRESSC} = '{store.Address}'" +
                $" where {Store.IDC} = '{store.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }
        public static bool DeleteStore(Store store)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from {Store.STORETABLE} where {Store.IDC} = '{store.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }

        public static List<Store> GetAllStores()
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select * from {Store.STORETABLE} order by {Store.IDC}";
                var tbl = DBCon.DB.GetData(query);
                List<Store> stores = new List<Store>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    stores.Add(new Store()
                    {
                        Id = int.Parse(tbl.Rows[i][Store.IDC].ToString()),
                        Name = tbl.Rows[i][Store.NAMEC].ToString(),
                        Address = tbl.Rows[i][Store.ADDRESSC].ToString(),
                        Phone = tbl.Rows[i][Store.PHONEC].ToString(),
                        Employee = new Employee() { Id = int.Parse(tbl.Rows[i][Store.EMPLOYEEC].ToString()) },
                    });
                }
                return stores;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new List<Store>();
        }
    }
}
