using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class Unit
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructor
        public Unit()
        {

        }
        #endregion

        #region DataBase Info
        // Table Name
        public static string UNITTAbLE = "unit";

        //Fields Names
        public static string IDC = "id";
        public static string NAMEC = "name";
        #endregion

        #region Method

        public override string ToString()
        {
            return this.Name;
        }
        public bool Save()
        {
            return true;
        }
        public List<Unit> GetUnits()
        {
            return new List<Unit>();
        }
        #endregion
    }
}
