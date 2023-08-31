using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class ShopTbl
    {
        public static int CheckItemExist(ItemInStore item, bool bigUnit = false)
        {
            DBCon.DB.Open();
            string unit = item.SmallUnit;
            if (bigUnit)
                unit = item.BigUnit;
            string query = $"select id from shop where item = '{item.Id}' and unit ='{unit}'";
            var tbl = DBCon.DB.GetData(query);
            DBCon.DB.Close();
            if (tbl.Rows.Count > 0)
                return int.Parse(tbl.Rows[0][0].ToString());
            return 0;
        }
        public static bool SaveItemInShop(ItemInStore item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into shop (item, qunatity, unit) values ('{item.Id}', '{item.Quantity}', '{item.Unit}')";
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

        public static bool EditItemInShop(ItemInStore item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update shop set  qunatity = '{item.Quantity}', unit='{item.Unit}' where id = '{item.IdInShop}'";
                DBCon.DB.Run(query);
                query = $"update {ItemInStore.ITEMINSTORETABLE} set " +
                $" {ItemInStore.EXPDATEC} = '{item.ExpirationDate}'" +
                $" where {ItemInStore.IDC} = '{item.Id}'";
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
        public static bool EditQuantity(ItemInStore item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update shop set  qunatity = qunatity + '{item.Quantity}' where id = '{item.IdInShop}'";
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

        public static bool MinusQuantity(ItemInBill item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update shop set  qunatity = qunatity - '{item.Count}' where id = '{item.IdInShop}'";
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
        public static bool EditQuantityBuyBill(ItemInBill item)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update shop set  qunatity = '{item.Count}' where item = '{item.Id}' and unit = '{item.Unit}'";
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
        public static bool DeleteItemInShop(string id)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from shop where id = '{id}'";
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
    }
}
