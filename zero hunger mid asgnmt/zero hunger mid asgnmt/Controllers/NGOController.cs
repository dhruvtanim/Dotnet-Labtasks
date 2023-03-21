using PMS.EF;
using PMS.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class NGOController : Controller
    {
        // GET: NGO
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee e)
        {
            var db = new NGOContext();
            db.Employees.Add(e);
            db.SaveChanges();
            return RedirectToAction("ShowEmployee");
        }

        public ActionResult ShowEmployee()
        {
            var db = new NGOContext();
            var emp = db.Employees.ToList();
            return View(emp);
        }
    }
}