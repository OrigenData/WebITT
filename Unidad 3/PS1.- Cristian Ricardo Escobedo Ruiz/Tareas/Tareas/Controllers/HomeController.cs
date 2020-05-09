using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tareas.Models;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace Tareas.Controllers
{
    public class HomeController : Controller
    {

        private TaskDbContext db = new TaskDbContext();



        public ActionResult Index()
        {
            var movies = db.Movies.Include(m => m.Genero);
            return View(movies.ToList());
            //return View();
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

    }
}