using PMS.EF;
using PMS.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult OrderDetails(int id)
        {
            NGOContext db = new NGOContext();
            var product = db.Products.Find(id);
            return View(product);
        }
        public ActionResult Index(int id=1) //id means page number
        {

            NGOContext db = new NGOContext();
            int itemperpage = 10;
            int total = db.Products.Count();
            int pages = (int)Math.Ceiling(total / (double)itemperpage);
            ViewBag.pages = pages;

            var products = db.Products.OrderBy(p => p.Id).Skip((id - 1) * itemperpage).Take(itemperpage).ToList();

            return View(products);
        }

        public ActionResult AllOrders(int id = 1)
        {
            NGOContext db = new NGOContext();
            return View(db.Orders.ToList());
        }

        public ActionResult AddCart(int id) {
            NGOContext db = new NGOContext();
            var product = db.Products.Find(id); 

            List<Product> cart = null;
            if (Session["cart"] == null)
            {
                cart = new List<Product>();
            }
            else {
                cart = (List<Product>)Session["cart"];
            }
            
            cart.Add(new Product() { 
                Id = product.Id,
                Name = product.Name,
                Location = product.Location,
                Qty = 1,
            });
            
            
            db.SaveChanges();
            Session["cart"] = cart;
            TempData["Msg"] = "Successfully Collected";
            TempData["Color"] = "alert-success";
            return RedirectToAction("Index");
        }
        public ActionResult Cart() {
            if (Session["cart"]!=null)
                return View((List<Product>)Session["cart"]);
            TempData["Msg"] = "No order collected";
            TempData["Color"] = "alert-info";
            return RedirectToAction("Index");
        }
        public ActionResult Place()
        {
            var products = (List<Product>)Session["cart"];
            Order o = new Order();
            o.Lasttime = DateTime.Now;
            NGOContext db = new NGOContext();
            db.Orders.Add(o);
            db.SaveChanges();
            foreach (var p in products)
            {
                Order od = new Order();
                
                od.Name = p.Name;
                od.Qty = p.Qty;
                od.Location= p.Location;
                od.Lasttime= DateTime.Now;
                db.Orders.Add(od);
                db.Products.Find(p.Id).Qty -= p.Qty;
            }
            db.SaveChanges();
            Session["cart"] = null;
            TempData["Msg"] = "Order Placed Successfully";
            return RedirectToAction("Index");
        }

    }
       
    }
