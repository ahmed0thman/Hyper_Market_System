using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class Store
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
        public string Phone { get; set; }
        #endregion

        #region Constructor
        public Store()
        {

        }
        public Store(int id) => this.Id = id;
        #endregion

        #region Database Info
        // Table Name
        public static string STORETABLE = "store";

        // Fields Names
        public static string IDC = "id";
        public static string NAMEC = "name";
        public static string ADDRESSC = "address";
        public static string EMPLOYEEC = "employee";
        public static string PHONEC = "phone";
        #endregion

        #region Database Handling
        public bool Add()
        {
            return true;
        }
        public bool Edit(Store Store)
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static Store Get(int id)
        {
            return new Store(id);
        }
        #endregion

        
    }
}
