using DataLib.DataAccess;
using DataLib.models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.BusinessLogic
{
    class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string emailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LasttName = lastName,
                EmailAddress = emailAddress

            };

            string sql = @"insert into sbo.Employee (EmployeeId, FirstName, LastName, EmailAddress)
                           values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = "select Id, EmployeeId, FirstName, LastName, EmailAddress from dbo.Employees;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
