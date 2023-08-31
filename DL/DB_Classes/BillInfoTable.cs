using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class BillInfoTable
    {
        public static bool SaveBillInfo(Bill items)
        {
            bool done = false;
            try
            {
                DBCon.DB.Open();
                string valuesQuery = "";
                foreach (ItemInBill item in items)
                {
                    valuesQuery += $" ('{item.IdInShop}', '{items.Id}', '{item.Unit}', '{item.Price}', '{item.Count}','{item.Totalprice}'),";

                }
                valuesQuery = valuesQuery.Remove(valuesQuery.Length - 1);
                
                string query = $"insert into {ItemInBill.ITEMINBILLTABLE} values {valuesQuery}";
                //throw new Exception(query);
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception ex)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool SaveBillBuyInfo(Bill items)
        {
            bool done = false;
            try
            {
                DBCon.DB.Open();
                string valuesQuery = "";
                foreach (ItemInBill item in items)
                {
                    valuesQuery += $" ('{item.Code}', '{items.Id}', '{item.Unit}', '{item.Price}', '{item.Count}','{item.Totalprice}','{item.ExpirationDate}'),";

                }
                valuesQuery = valuesQuery.Remove(valuesQuery.Length - 1);

                string query = $"insert into bill_buy_info values {valuesQuery}";
                //throw new Exception(query);
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception ex)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteBillInfo(Bill bill)
        {
            bool done = false;
            try
            {
                DBCon.DB.Open();
                string query = $"delete from {ItemInBill.ITEMINBILLTABLE} where {ItemInBill.BILLC} = '{bill.Id}'";
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

        public static bool DeleteBillBuyInfo(Bill bill)
        {
            bool done = false;
            try
            {
                DBCon.DB.Open();
                string query = $"delete from bill_buy_info where {ItemInBill.BILLC} = '{bill.Id}'";
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

        public static List<ItemInBill> GetBillInfo(Bill bill)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select {ItemInBill.ITEMC} as id, {ItemInBill.UNITC} as unit, {ItemInBill.UNITPRICEC} as price," +
                    $"{ItemInBill.NUMTOTALC} as count, {ItemInBill.TOTALPRICE} total from {ItemInBill.ITEMINBILLTABLE} where {ItemInBill.BILLC} = '{bill.Id}'";
                var tbl = DBCon.DB.GetData(query);
                var billinfo = new List<ItemInBill>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    billinfo.Add(new ItemInBill() {
                        IdInShop = int.Parse(tbl.Rows[i]["id"].ToString()),
                        Price = double.Parse(tbl.Rows[i]["price"].ToString()),
                        Count = double.Parse(tbl.Rows[i]["count"].ToString()),
                        Totalprice = double.Parse(tbl.Rows[i]["total"].ToString()),
                        Unit = tbl.Rows[i]["unit"].ToString(),
                    });
                }
                return billinfo;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return new List<ItemInBill>();
        }


        public static List<ItemInBill> GetBillBuyInfo(Bill bill)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select {ItemInBill.ITEMC} as id, {ItemInBill.UNITC} as unit, {ItemInBill.UNITPRICEC} as price," +
                    $"{ItemInBill.NUMTOTALC} as count, {ItemInBill.TOTALPRICE} total, date_end date from bill_buy_info where {ItemInBill.BILLC} = '{bill.Id}'";
                var tbl = DBCon.DB.GetData(query);
                var billinfo = new List<ItemInBill>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    billinfo.Add(new ItemInBill()
                    {
                        Code = tbl.Rows[i]["id"].ToString(),
                        Price = double.Parse(tbl.Rows[i]["price"].ToString()),
                        Count = double.Parse(tbl.Rows[i]["count"].ToString()),
                        Totalprice = double.Parse(tbl.Rows[i]["total"].ToString()),
                        Unit = tbl.Rows[i]["unit"].ToString(),
                        ExpirationDate = tbl.Rows[i]["date"].ToString(),
                    });
                }
                return billinfo;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return new List<ItemInBill>();
        }

    }
}
