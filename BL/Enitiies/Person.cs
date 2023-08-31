using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BL.Enitiies
{
    #region PersonType Enumration 
    public enum PersonType
    {
         Employee = 0,
         Client = 1,
         Supplier = 2,
         Manager = 3,
         Owner = 4
    }

    public static class PersonTypeExtention
    {
        #region Friendly PersonType string
        public static string ToStr(this PersonType personType)
        {
            switch (personType)
            {
                case PersonType.Employee:
                    return "موظف";
                case PersonType.Client:
                    return "عميل";
                case PersonType.Supplier:
                    return "مورد";
                case PersonType.Manager:
                    return "مدير";
                case PersonType.Owner:
                    return "مالك";
                default:
                    throw new ArgumentException("not a vaild person type");
            }
        }

        public static PersonType ToPersonType(this string personType)
        {
            switch (personType)
            {
                case "موظف":
                    return PersonType.Employee;
                case "عميل":
                    return PersonType.Client;
                case "مورد":
                    return PersonType.Supplier;
                case "مدير":
                    return PersonType.Manager;
                case "مالك":
                    return PersonType.Owner;
                default:
                    throw new ArgumentException("not a vaild person String");
            }
        }
        #endregion


    }
    #endregion
    public class Person
    {
        #region Fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public double Debt { get; set; } = 0;
        public double DebtBill { get; set; } = 0;
        public PersonType Type  { get; set; }
        #endregion

        #region Constrictors
        public Person()
        {

        }
        public Person(int id)
            => this.Id = id;
        public Person(int id, string name) : this(id)
            => this.Name = name;
        public Person(int id, string name, string phone) : this (id, name)
            => this.Phone = phone;
        public Person(int id, string name, string phone, double debt) : this(id, name, phone)
            => this.Debt = debt;
        #endregion

        #region  Database Info
        // Table Name
        public static string PERSONTABLE = "Person";

        // Fields Names
        public static string IDC = "id";
        public static string NAMEC = "name";
        public static string PHONEC = "phone";
        public static string PHONE2C = "phone2";
        public static string DEBTC = "debt";
        public static string TYPEC = "type";
        #endregion

        #region Database Handling
        public virtual bool Add()
        {
            return true;
        }
        public virtual bool Edit(Person person)
        {
            return true;
        }
        public virtual bool Delete()
        {
            return true;
        }
        public static Person Get(int  id)
        {
            return new Person(id);
        }
        #endregion
    }
}
