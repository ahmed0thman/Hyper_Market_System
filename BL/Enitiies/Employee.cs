using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{

    #region Employee Permissions
    public enum EmpPermission
    {
        Owner, Manager, Cashier
    }
    #endregion

    #region Employee Permission extension class
    public static class EmpExtention
    {
        public static string ToStr(this EmpPermission empPermission)
        {
            switch (empPermission)
            {
                case EmpPermission.Owner:
                    return "مالك";
                case EmpPermission.Manager:
                    return "مسؤول";
                case EmpPermission.Cashier:
                    return "كاشير";
                default:
                    throw new ArgumentException("Not a vaild Permission type");
            }
        }

        public static EmpPermission ToEmpPermission(this string empPermission)
        {
            switch (empPermission.Trim())
            {
                case "مالك":
                    return EmpPermission.Owner;
                case "مسؤول":
                    return EmpPermission.Manager;
                case "كاشير":
                    return EmpPermission.Cashier;
                default:
                    throw new ArgumentException("Not a vaild Permission string");
            }
        }
    }
    #endregion
    public class Employee : Person
    {

        #region Fields
        public string Username { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; } = 0;
        public EmpPermission Permission { get; set; }
        #endregion

        #region Constructor
        public Employee()
        {

        }
        #endregion

        #region Database Info
        // Table Name
        public static string EMPTABLE = "users";

        // Fields Names
        public static string USERNAMEC = "username";
        public static string PASSWORDC = "userpassword";
        public static string SALARYC = "salary";
        #endregion

        #region Database Handling
        public override bool Add()
        {
            return true;
        }
        public override bool Edit(Person person)
        {
            return true;
        }
        public override bool Delete()
        {
            return true;
        }
        public static new Person Get(int id)
        {
            return new Person(id);
        }
        #endregion
    }
}
