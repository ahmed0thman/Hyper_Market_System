using BL.Enitiies;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Enitiies.Employee;

namespace DL
{
    public static class EmployeeTbl
    {
        public static bool FindEmployeeCode(string code)
        {
            bool found = false;
            var emp = GetEmployee(code);
            if (emp.Count > 0)
                found = true;
            return found;
        }
        public static bool SaveEmployee(Employee employee)
        {
            bool done = false;
            DBCon.DB.Open();
            try
            {
                string query = $"insert into {EMPTABLE} ({Employee.IDC}, {Employee.SALARYC}, {Employee.TYPEC}," +
                $" {Employee.USERNAMEC}, {Employee.PASSWORDC}) values ('{employee.Id}', '{employee.Salary}'," +
                $" '{employee.Permission.ToStr()}', '{employee.Username}', '{employee.Password}')";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            
            DBCon.DB.Close();
            return done;

        }

        public static bool EditEmployee(Employee employee)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"update {EMPTABLE} set  {Employee.SALARYC} = '{employee.Salary}', {Employee.TYPEC} = '{employee.Permission.ToStr()}'" +
                $"where {Employee.IDC} = '{employee.Id}'";
                DBCon.DB.Run(query);
                done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;

        }
        public static bool EditEmployeeLoginInfo(Employee employee)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"update {EMPTABLE} set " +
                $" {Employee.USERNAMEC} = '{employee.Username}', {Employee.PASSWORDC} = '{employee.Password}' " +
                $"where {Employee.IDC} = '{employee.Id}'";
            DBCon.DB.Run(query);
            done = true;
        }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;

        }

        public static bool EditEmployeeDebt(EmpOutgoings debt)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"update {EMPTABLE} set " +
                $" {Employee.DEBTC} = {Employee.DEBTC} + '{debt.Price}' " +
                $"where {Employee.IDC} = '{debt.Employee.Id}'";
            DBCon.DB.Run(query);
            done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;

        }

        public static bool DeleteEmployee(Employee employee)
        {
            bool done = true;
            DBCon.DB.Open();
            try
            {
                string query = $"Delete from {EMPTABLE} " +
                $"where {Employee.IDC} = '{employee.Id}'";
            DBCon.DB.Run(query);
            done = true;
            }
            catch (Exception)
            {
            }
            DBCon.DB.Close();
            return done;

        }

        private static List<Employee> GetEAllmployees(bool hasDept = false, string empInfo = "", string username = "")
        {
            DBCon.DB.Open();
            try
            {
                string dept = "";
                string oneEmp = "";
                if (hasDept)
                    dept = $" and {Employee.EMPTABLE}.{Employee.DEBTC} > 1";
                if (username != "")
                    oneEmp = $" and {Employee.EMPTABLE}.{Employee.USERNAMEC} = '{username}' ";
                if (empInfo != "")
                    if (Char.IsDigit(empInfo[0]))
                        if (empInfo[0] == '0')
                            oneEmp = $" and {Employee.EMPTABLE}.{Employee.PHONEC} like '%{empInfo}%'";
                        else
                            oneEmp = $" and {Employee.EMPTABLE}.{Employee.IDC} like '%{empInfo}%'";
                    else
                        oneEmp = $" and {Employee.NAMEC} like '%{empInfo}%'";
                string query = $"select {Person.PERSONTABLE}.{Person.IDC} id, {Person.PERSONTABLE}.{Person.NAMEC} name," +
                    $"{Person.PERSONTABLE}.{Person.PHONEC} phone, {Employee.EMPTABLE}.{Employee.USERNAMEC} user," +
                    $"{Employee.EMPTABLE}.{Employee.PASSWORDC} pass, {Employee.EMPTABLE}.{Employee.SALARYC} salary," +
                    $"{Employee.EMPTABLE}.{Employee.TYPEC} type, {Employee.EMPTABLE}.{Employee.DEBTC} debt from {Employee.EMPTABLE} " +
                    $"inner join {Person.PERSONTABLE} on {Employee.EMPTABLE}.{Employee.IDC} = {Person.PERSONTABLE}.{Person.IDC}" +
                    $" where {Person.PERSONTABLE}.{Person.TYPEC} = '{PersonType.Employee.ToStr()}' {dept} {oneEmp}";
                var tbl = DBCon.DB.GetData(query);
                
                List<Employee> employees = new List<Employee>();
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    employees.Add(new Employee() {
                        Id = int.Parse(tbl.Rows[i]["id"].ToString()),
                        Name = tbl.Rows[i]["name"].ToString(),
                        Phone = tbl.Rows[i]["phone"].ToString(),
                        Salary = int.Parse(tbl.Rows[i]["salary"].ToString()),
                        Debt = int.Parse(tbl.Rows[i]["debt"].ToString()),
                        Permission = tbl.Rows[i]["type"].ToString().ToEmpPermission(),
                        Username = tbl.Rows[i]["user"].ToString(),
                        Password = tbl.Rows[i]["pass"].ToString(),
                    });;
                }
                return employees;
            }
            catch (Exception)
            {
            }

            DBCon.DB.Close();
            return new List<Employee>();
        }
        public static List<Employee> GetEmployee(string empInfo)
        {
            return GetEAllmployees(empInfo: empInfo);
        }
        public static List<Employee> CheckEmployee(string username)
        {
            return GetEAllmployees(username: username);
        }
        public static List<Employee> GetEmployeesWithDept()
        {
            return GetEAllmployees(hasDept: true);
        }
        public static List<Employee> GetEAllmployees()
        {
            return GetEAllmployees(false, "");
        }

    }
}
