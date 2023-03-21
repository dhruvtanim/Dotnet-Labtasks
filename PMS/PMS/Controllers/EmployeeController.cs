using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult CheckRequest()
        {
            NGOContext db = new NGOContext();
            return View(db.Orders.ToList());
        }
      
         
        public ActionResult Assign(int id)
        {
            var db = new NGOContext();
            var st = (from s in db.Orders where s.Id == id select s).SingleOrDefault();
            db.Orders.Remove(st);
            db.SaveChanges();
            return RedirectToAction("CheckRequest");
        }
    }
}