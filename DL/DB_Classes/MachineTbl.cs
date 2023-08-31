using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class MachineTbl
    {
        public static bool SaveMachine(BalanceMachine machine)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {BalanceMachine.BALANCEMACHINETABLE} ({BalanceMachine.NAMEC}, {BalanceMachine.BALANCEC})" +
                $" values ('{machine.Name}','{machine.Balance}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            
            DBCon.DB.Close();
            return done;
        }

        public static bool EditMachine(BalanceMachine machine)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"update {BalanceMachine.BALANCEMACHINETABLE} set {BalanceMachine.NAMEC} = '{machine.Name}'," +
                $"{BalanceMachine.BALANCEC} = '{machine.Balance}' where {BalanceMachine.IDC} = '{machine.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }

        public static bool DeleteMachine(int id)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"delete from {BalanceMachine.BALANCEMACHINETABLE} where {BalanceMachine.IDC} = '{id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;
        }
        public static DataTable GetMachines()
        {

            DBCon.DB.Open();
            try
            {
                string query = $"select * from {BalanceMachine.BALANCEMACHINETABLE}";
            var machines = DBCon.DB.GetData(query);
                return machines;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new DataTable();
        }

        public static void UpdateAccountBalance(double amount, int id, double op = 1)
        {
            DBCon.DB.Open();
            string query = $"update {BalanceMachine.BALANCEMACHINETABLE} set {BalanceMachine.BALANCEC} = {BalanceMachine.BALANCEC} + {amount * op } where {BalanceMachine.IDC} = '{id}'";
            DBCon.DB.Run(query);
            DBCon.DB.Close();
        }
        public static void Plus(double amount, int id)
        {
            UpdateAccountBalance(amount, id);
        }

        public static void Minus(double amount, int id)
        {
            UpdateAccountBalance(amount, id, -1);
        }
    }
}
