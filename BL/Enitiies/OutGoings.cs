using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class OutGoings
    {
        #region Fields
        public int Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Account { get; set; }
        public DateTime Date { get; set; }
        #endregion

        #region Constructors
        public OutGoings()
        {

        }
        public OutGoings(int id) => Id = id;
        #endregion

        #region Database Info
        // Table Name
        public static string OUTGIONGSTABLE = "out_goings";
        // Fields Names
        public static string IDC = "id";
        public static string TYPEC = "type";
        public static string PRICEC = "price";
        public static string DATEC = "_date";
        public static string DESCRIPTIONC = "descripion";
        public static string ACCOUNTC = "account";
        #endregion

        #region Database Handling
        public virtual bool Add()
        {
            return true;
        }
        public virtual bool Edit(OutGoings outGoings)
        {
            return true;
        }
        public virtual bool Delete()
        {
            return true;
        }
        public static OutGoings Get(int id)
        {
            return new OutGoings(id);
        }
        #endregion
    }
}
