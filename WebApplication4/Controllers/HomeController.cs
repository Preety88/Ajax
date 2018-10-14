using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        HarpreetEntities1 harpreetEntities1 = new HarpreetEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            List<Employee> models = harpreetEntities1.Employees.ToList();
            return PartialView("_Employee", models);
        }

        public PartialViewResult Top3()
        {
            List<Employee> models = harpreetEntities1.Employees.OrderByDescending(x => x.Salary).Take(3).ToList();
            return PartialView("_Employee", models);
        }

        public PartialViewResult Bottom3()
        {
            List<Employee> models = harpreetEntities1.Employees.OrderBy(x => x.Salary).Take(3).ToList();
            return PartialView("_Employee", models);
        }
    }
}