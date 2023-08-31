using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.DB_Classes
{
    public static class UnitTbl
    {
        public static bool SaveUnit(Unit unit)
        {
            bool done = false;
            DBCon.DB.Open();
            string query = $"insert into {Unit.UNITTAbLE} ({Unit.NAMEC}) values ('{unit.Name}')";
            DBCon.DB.Run(query);
            done = true;
            DBCon.DB.Close();
            return done;
        }

        public static DataTable GetUnits()
        {
            DBCon.DB.Open();
            string query = $"select * from {Unit.UNITTAbLE}";
            var units = DBCon.DB.GetData(query);
            DBCon.DB.Close();
            return units;
        }
    }
}
