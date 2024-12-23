using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC11.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e1 = new Employee()
            {
                Id = 9001,
                EmployeeName = "John Miller",
                Department = "Solutions",
                Designation = "Developer",
                Salary = 20000.00
            };
            return View(e1);
        }
        public ActionResult ShowEmployees()
        {
            List<Employee> emplist = new List<Employee>()
        {
            new Employee()
            {
            Id = 9001,
            EmployeeName = "John Miller",
            Department = "Solutions",
            Designation = "Developer",
            Salary = 20000.00
            },
            new Employee()
            {
            Id = 9002,
            EmployeeName = "Sabresan",
            Department = "HR",
            Designation = "Manager",
            Salary = 30000.00
            },
            new Employee()
            {
            Id = 9003,
            EmployeeName = "Bala Subrmanyan",
            Department = "Solutions",
            Designation = "Lead",
            Salary = 40000.00
            }
        };
            return View(emplist);
        }
    }

}

