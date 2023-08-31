using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    public class BalanceMachine
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        #endregion

        #region Constructor
        public BalanceMachine()
        {

        }
        public BalanceMachine(int id) => Id = id;
        #endregion

        #region Database Info
        // Table Name
        public static string BALANCEMACHINETABLE = "machine";
        // Fields Names
        public static string IDC = "id";
        public static string NAMEC = "name";
        public static string BALANCEC = "balance";
        #endregion

        #region Database Handling
        public bool Add()
        {
            return true;
        }
        public bool Edit(BalanceMachine balanceMachine)
        {
            return true;
        }
        public bool Delete()
        {
            return true;
        }
        public static BalanceMachine Get(int id)
        {
            return new BalanceMachine(id);
        }
        #endregion

        #region Methods
        public bool IsAvailable(double balance)
        {
            return true;
        }

        public override string ToString() => $"ID:{Id}, Name:{Name}, Current Balance:{Balance}";
        #endregion
    }
}
