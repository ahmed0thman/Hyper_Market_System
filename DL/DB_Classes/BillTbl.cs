using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class BillTbl
    {
        public static int GetLastBillCode()
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select max({Bill.IDC}) from {Bill.BILLTABLE}";
                var bill =int.Parse( DBCon.DB.GetData(query).Rows[0][0].ToString());
                return bill;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return -1;
        }

        public static int GetLastBillInDay(DateTime dt, BillType billType)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select max({Bill.IDINDAYC}) from {Bill.BILLTABLE} " +
                $"where {Bill.DATEC} like '%{dt.ToString("yyyy-MM-dd")}%' and {Bill.TYPE} = '{billType.ToStr()}'";
                var tbl = DBCon.DB.GetData(query);
                if (tbl.Rows.Count == 0 || tbl.Rows[0][0] is null || tbl.Rows[0][0].ToString() == "")
                    return 0;
                var bill = int.Parse(tbl.Rows[0][0].ToString());
                return bill;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return -1;
        }
        public static bool SaveBill(Bill bill)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {Bill.BILLTABLE} values ('{bill.Id}', '{bill.IdInDay}'," +
                    $" '{bill.date.ToString("u").Replace("Z", "")}', '{bill.CountItems}'," +
                $"'{bill.Person.Id}',  '{bill.Employee.Id}','{bill.Price}','{bill.Discount}','{bill.TotalPrice}'," +
                $" '{bill.Paid}', '{bill.Rest}', '{bill.Type.ToStr()}','{bill.profit}','{bill.Account}')";
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

        public static bool EditBill(Bill bill)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {Bill.BILLTABLE} set {Bill.ITEMTOTALNUMBERC} = '{bill.CountItems}', {Bill.PAIDC} = '{bill.Paid}', " +
                $"{Bill.RESTC} = '{bill.Rest}', {Bill.PRICEC} = '{bill.Price}', {Bill.DISCOUNTC} = '{bill.Discount}'," +
                $" {Bill.TOTALPRICEC} = '{bill.TotalPrice}', {Bill.PROFITC} = '{bill.profit}'," +
                $" {Bill.PERSONC} = '{bill.Person.Id}', {Bill.ACCOUNTC} = '{bill.Account}' where {Bill.IDC} = '{bill.Id}' ";
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

        public static bool PayDebts(string billId = "", string Person = "")
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string subQuery = "";
                if(billId != "")
                {
                    subQuery = $" where {Bill.IDC} = '{billId}'";
                }
                else if (Person != "")
                {
                    subQuery = $" where {Bill.PERSONC} = '{Person}'";
                }
                string query = $"update {Bill.BILLTABLE} set  {Bill.PAIDC} = {Bill.TOTALPRICEC}, " +
                $"{Bill.RESTC} = 0  {subQuery}";
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

        public static bool DeleteBill(Bill bill)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from  {Bill.BILLTABLE}  " +
                 $"where {Bill.IDC} = '{bill.Id}' ";
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

        public static List<Bill> GetBill(BillType type, string id = "", string dtFrm = "", string dt2 = "", string person = "", string emp = "", bool rest = false)
        {
            DBCon.DB.Open();
            try
            {
                DataTable tbl = GetTblBill(type, id, dtFrm, dt2, person, emp, rest);
                List<Bill> bills = new List<Bill>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    bills.Add(new Bill()
                    {
                        Id = int.Parse(tbl.Rows[i][Bill.IDC].ToString()),
                        IdInDay = int.Parse(tbl.Rows[i][Bill.IDINDAYC].ToString()),
                        date = DateTime.Parse(tbl.Rows[i][Bill.DATEC].ToString()),
                        CountItems = int.Parse(tbl.Rows[i][Bill.ITEMTOTALNUMBERC].ToString()),
                        Person = new Person(int.Parse(tbl.Rows[i][Bill.PERSONC].ToString())),
                        Employee = new Employee() { Id = int.Parse(tbl.Rows[i][Bill.PERSONC].ToString()) },
                        Price = double.Parse(tbl.Rows[i][Bill.PRICEC].ToString()),
                        Discount = int.Parse(tbl.Rows[i][Bill.DISCOUNTC].ToString()),
                        Paid = double.Parse(tbl.Rows[i][Bill.PAIDC].ToString()),
                        TotalPrice = double.Parse(tbl.Rows[i][Bill.TOTALPRICEC].ToString()),
                        Rest = double.Parse(tbl.Rows[i][Bill.RESTC].ToString()),
                        Type = tbl.Rows[i][Bill.TYPE].ToString().ToBillType(),
                        profit = double.Parse(tbl.Rows[i][Bill.PROFITC].ToString()),
                        Account = tbl.Rows[i][Bill.ACCOUNTC].ToString(),
                    });
                }
                return bills;
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
            return new List<Bill>();
        }

        public static DataTable GetTblBill(BillType type, string id ="", string dtFrm = "", string dt2 = "", string person = "", string emp = "", bool rest = false)
        {
            string subQuery = "";
            if (id != "")
                subQuery = $" and {Bill.IDC} = {id}";
            if (dtFrm != "" && dt2 != "")
                subQuery = $" and {Bill.DATEC} between '{dtFrm}' and '{dt2}'";
            if (person != "")
                subQuery += $" and {Bill.PERSONC} = {person} ";
            if (emp != "")
                subQuery += $" and {Bill.EMPLOYEEC} = {emp}";
            if (rest)
                subQuery += $" and {Bill.RESTC} > 0";
            DBCon.DB.Open();
            string query = $"select * from {Bill.BILLTABLE} where type = '{type.ToStr()}' {subQuery} and not id = 1";
            var tbl = DBCon.DB.GetData(query);
            return tbl;
        }

        public static void BillPaidPlus(int bill, double price)
        {
            HandlePaid(bill, price);
        }

        public static void BillPaidMinus(int bill, double price)
        {
            HandlePaid(bill, price, -1);
        }

        private static void HandlePaid(int bill, double price, int op = 1)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"update  {Bill.BILLTABLE} set {Bill.PAIDC} = {Bill.PAIDC} + {price * op} , " +
                    $" {Bill.RESTC} = {Bill.RESTC} - {price * op}" +
                    $"  where {Bill.IDC} = '{bill}'";
                DBCon.DB.Run(query);
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
        }
    }
}
