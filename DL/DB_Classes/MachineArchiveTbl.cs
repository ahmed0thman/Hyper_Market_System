using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class MachineArchiveTbl
    {
        public static bool SaveMachineOperation(MachineOperation operation)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {MachineOperation.MACHINEOPERATIONTABLE} ({MachineOperation.TYPEC}, {MachineOperation.PRICEC}, {MachineOperation.DATEC}, " +
                $"{MachineOperation.MACHINEC}, {MachineOperation.DETAILSC})" +
                $" values ('{operation.Type.ToStr()}', '{operation.Price}', '{operation.Date.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $" '{operation.Machine.Id}', '{operation.Details}')";
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
        public static bool EditMachineOperation(MachineOperation operation)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {MachineOperation.MACHINEOPERATIONTABLE} set " +
                $" {MachineOperation.PRICEC} = '{operation.Price}', {MachineOperation.DATEC} = '{operation.Date.ToString("d")}', " +
                $"{MachineOperation.MACHINEC} = '{operation.Machine}', {MachineOperation.DETAILSC} = '{operation.Details}')" +
                $" where {MachineOperation.IDC} = '{operation.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteMachineOperation(int operation)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from {MachineOperation.MACHINEOPERATIONTABLE} " +
                $" where {MachineOperation.IDC} = '{operation}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }

        public static DataTable GetMachineOperations(string id = "", string dt = "")
        {
            DBCon.DB.Open();
            try
            {
                string subqury = "";
                if (id != "")
                    subqury = $"where {MachineOperation.MACHINEC} = '{id}'";
                if (dt != "")
                    subqury = $"where {MachineOperation.DATEC} like '%{dt}%'";
                string query = $"select id, _date, type, price, details from {MachineOperation.MACHINEOPERATIONTABLE} " +
                    $" {subqury}";
                var operations = DBCon.DB.GetData(query);
                return operations;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new DataTable(); ;
        }
    }
}
