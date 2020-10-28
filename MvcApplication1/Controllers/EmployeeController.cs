using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            IEnumerable<Employee> employees= new List<Employee>
                {
                    new Employee{EmployeeName = "Sachin",EmployeeDepartment = "Dev"},
                    new Employee{EmployeeDepartment = "Accounts",EmployeeName = "Sandeep"}
                };

            //Tsting
            return employees;
        }

        public void Test()
        {


            var data1 = "new data";
        }
    }
}
