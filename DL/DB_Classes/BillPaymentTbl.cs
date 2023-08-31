using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public class BillPaymentTbl
    {
        public static void AddPayment(BillPayment billPayment)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {BillPayment.BILLPAYMENT} ({BillPayment.DATEC}, {BillPayment.PRICEC}, {BillPayment.DETAILSC}, {BillPayment.BILLC})" +
                    $" values ('{billPayment.DateTime}', '{billPayment.Price}', '{billPayment.Details}','{billPayment.BillId}')";
                DBCon.DB.Run(query);
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
        }
        public static void EditPayment(BillPayment billPayment)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"update {BillPayment.BILLPAYMENT} set  {BillPayment.DATEC} ='{billPayment.DateTime}'," +
                    $" {BillPayment.PRICEC} = '{billPayment.Price}', " +
                    $" {BillPayment.DETAILSC} = '{billPayment.Details}' " +
                    $"  where {BillPayment.IDC} = '{billPayment.Id}'";
                DBCon.DB.Run(query);
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
        }
        public static void DeletePayment(BillPayment billPayment)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"delete from  {BillPayment.BILLPAYMENT} " +
                    $"  where {BillPayment.IDC} = '{billPayment.Id}'";
                DBCon.DB.Run(query);
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
        }

        public static DataTable GetPayment(int billId)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select * from  {BillPayment.BILLPAYMENT} " +
                    $"  where {BillPayment.BILLC} = '{billId}'";
                return DBCon.DB.GetData(query);
            }
            catch (Exception)
            {
                DBCon.DB.Close();
                throw;
            }
            DBCon.DB.Close();
        }

        public static double GetTotalBillPaids(string date, BillType billType)
        {
            DBCon.DB.Open();
            try
            {
                string query = $"select sum({BillPayment.BILLPAYMENT}.{BillPayment.PRICEC}) from  {BillPayment.BILLPAYMENT}" +
                    $" inner join {Bill.BILLTABLE} on {BillPayment.BILLPAYMENT}.{BillPayment.BILLC} =  {Bill.BILLTABLE}.{Bill.IDC}" +
                    $"  where {BillPayment.BILLPAYMENT}.{BillPayment.DATEC} like '%{date}%' and {Bill.BILLTABLE}.{Bill.TYPE} = '{billType.ToStr()}'";

                var tbl =  DBCon.DB.GetData(query);
                if (tbl.Rows.Count == 0 || tbl.Rows[0][0].ToString().Trim() == "")
                    return 0;
                bool vaildNum = double.TryParse(tbl.Rows[0][0].ToString().Trim(), out double price);
                if (vaildNum)
                    return price;
                return 0;
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
