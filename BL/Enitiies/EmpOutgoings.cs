using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class EmpOutgoings : OutGoings
    {
        #region Fields
        public int Id { get; set; }
        public Person Employee { get; set; }
        public string Alarm { get; set; }
        public string Details { get; set; }
        #endregion

        #region Constructors
        public EmpOutgoings()
        {

        }
        public EmpOutgoings(int id) : base(id)
        {

        }
        #endregion

        #region Database Info
        // Table Name
        public static string EMPOUTGIONGSTABLE = "emp_outgoings";
        // Fields Names
        public static string EMPLOYEEC = "employee";
        public static string ALARMC = "alarm";
        public static string DETAILSC = "details";

        #endregion

        #region Database Handling
        public override bool Add()
        {
            return true;
        }
        public override bool Edit(OutGoings outGoings)
        {
            return true;
        }
        public override bool Delete()
        {
            return true;
        }
        public static new OutGoings Get(int id)
        {
            return new OutGoings(id);
        }
        #endregion
    }
}
