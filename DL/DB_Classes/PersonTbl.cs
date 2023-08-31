using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Enitiies;

namespace DL.DB_Classes
{
    public static    class PersonTbl
    {
        public static bool FindPersonCode(string code)
        {
            bool found = false;
            DBCon.DB.Open();
            try
            {
                var emp = DBCon.DB.GetData($"select {Person.NAMEC} from {Person.PERSONTABLE} where {Person.IDC} = {code}");
                if (emp.Rows.Count > 0)
                    found = true;
            }
            catch (Exception)
            {
            }
            
            DBCon.DB.Close();
            return found;
        }
        public static bool SavePerson(Person Person)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {Person.PERSONTABLE} ({Person.IDC}, {Person.NAMEC}, {Person.PHONEC}, {Person.PHONE2C}, {Person.TYPEC})" +
                $" values ('{Person.Id}', '{Person.Name}', '{Person.Phone}', '{Person.Phone2}', '{Person.Type.ToStr()}')";

                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;

        }

        public static bool EditPerson(Person Person)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"update {Person.PERSONTABLE} set  {Person.NAMEC} = '{Person.Name}'," +
               $" {Person.PHONEC} = '{Person.Phone}', {Person.PHONE2C} = '{Person.Phone2}' " +
               $"where {Person.IDC} = '{Person.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;

        }

        public static bool DeletePerson(Person Person)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"Delete from {Person.PERSONTABLE} " +
                $"where {Person.IDC} = '{Person.Id}'";
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

        private static List<Person> GetAllPersons(PersonType personType, bool hasDept = false, string personInfo = "")
        {
            DBCon.DB.Open();
            try
            {
                string dept = "";
                string onePerson = "";
                if (hasDept)
                    dept = $" and {Person.DEBTC} > 0";
                if (personInfo != "")
                    if (Char.IsDigit(personInfo[0]))
                        if (personInfo[0] == '0')
                            onePerson = $" and {Person.PHONEC} like '%{personInfo}%'";
                        else
                            onePerson = $" and {Person.IDC} like '%{personInfo}%'";
                    else
                        onePerson = $" and {Person.NAMEC} like '%{personInfo}%'";
                string query = $"select * from {Person.PERSONTABLE} where {Person.TYPEC} = '{personType.ToStr()}' " +
                    $" and not {Person.NAMEC} = 'gust' {dept} {onePerson} order by {Person.NAMEC}";
                var tbl = DBCon.DB.GetData(query);
                List<Person> people = new List<Person>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    people.Add(new Person()
                    {
                        Id = int.Parse(tbl.Rows[i][Person.IDC].ToString()),
                        Name = tbl.Rows[i][Person.NAMEC].ToString(),
                        Phone = tbl.Rows[i][Person.PHONEC].ToString(),
                        Phone2 = tbl.Rows[i][Person.PHONE2C].ToString(),
                        Debt = double.Parse(tbl.Rows[i][Person.DEBTC].ToString()),
                        Type = personType,
                    });
                }
                return people;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new List<Person>();
        }

        public static List<Person> GetPersonsButSupplier(bool hasDept = false, string info = "")
        {
            DBCon.DB.Open();
            try
            {
                string subquery = "";
                if (hasDept)
                    subquery = $" and {Person.DEBTC} > 0";
                if(info != "")
                {
                    if(info.ToList().TrueForAll( x => Char.IsDigit(x)))
                        subquery = $" and {Person.PHONEC} like '%{info}%'";
                    else
                        subquery = $" and {Person.NAMEC} like '%{info}%'";
                }
                string query = $"select * from {Person.PERSONTABLE} where not {Person.TYPEC} = '{PersonType.Supplier.ToStr()}' " +
                    $" and not {Person.NAMEC} = 'gust' {subquery} order by {Person.NAMEC}";
                var tbl = DBCon.DB.GetData(query);
                List<Person> people = new List<Person>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    people.Add(new Person()
                    {
                        Id = int.Parse(tbl.Rows[i][Person.IDC].ToString()),
                        Name = tbl.Rows[i][Person.NAMEC].ToString(),
                        Phone = tbl.Rows[i][Person.PHONEC].ToString(),
                        Phone2 = tbl.Rows[i][Person.PHONE2C].ToString(),
                        Debt = double.Parse(tbl.Rows[i][Person.DEBTC].ToString()),
                        Type = tbl.Rows[i][Person.TYPEC].ToString().ToPersonType(),
                    });
                }
                return people;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return new List<Person>();
        }
        public static List<Person> GetPerson(string personInfo, PersonType personType)
        {
            return GetAllPersons(personType, personInfo: personInfo);
        }
        public static List<Person> GetPersonsWithDept(bool hasDept, PersonType personType)
        {
            return GetAllPersons(personType, hasDept: hasDept);
        }
        public static List<Person> GetAllPersons(PersonType personType)
        {
            return GetAllPersons(personType, false, "");
        }
    }
}
