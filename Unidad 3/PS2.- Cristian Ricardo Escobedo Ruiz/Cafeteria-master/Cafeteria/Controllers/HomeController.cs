using ControlInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.Entity;
using System.Net;

namespace ControlInventario.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
              return  RedirectToAction("Index","Principal");
            }
            
             return View();
            
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        public ActionResult Menu()
        {
            ViewBag.Message = "Your Menu page.";

            var coffeeModels = db.CoffeeModels.Include(c => c.TypeCoffee);
            return View(coffeeModels.ToList());

        }

    }
}