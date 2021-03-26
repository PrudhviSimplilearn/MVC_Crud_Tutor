using JqueryAjaxCrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAjaxCrudMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public IEnumerable<Employee> GetAllEmployees()
        {
            using (DBModel db = new DBModel())
            {
                return db.Employees.ToList<Employee>();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll() 
        {
            return View(GetAllEmployees());
        }

        public ActionResult AddorEdit(int id = 0) 
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult AddorEdit() 
        {
            return View();
        }

       
    }
}