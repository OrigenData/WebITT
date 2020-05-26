using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ControlInventario.Models;

namespace ControlInventario.Controllers
{
    
    public class CoffeeModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CoffeeModels
        [Authorize]
        public ActionResult Index()
        {
            var coffeeModels = db.CoffeeModels.Include(c => c.TypeCoffee);
            return View(coffeeModels.ToList());
        }

        // GET: CoffeeModels/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(coffeeModels);
        }

        // GET: CoffeeModels/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.TypeCoffeeId = new SelectList(db.TypeCoffeeModels, "Id", "Type");
            return View();
        }

        // POST: CoffeeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,NutritionInformation,Ingredients,Description,TypeCoffeeId,ImagenCoffee")] CoffeeModels coffeeModels)
        {
            if (ModelState.IsValid)
            {
                db.CoffeeModels.Add(coffeeModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TypeCoffeeId = new SelectList(db.TypeCoffeeModels, "Id", "Type", coffeeModels.TypeCoffeeId);
            return View(coffeeModels);
        }

        // GET: CoffeeModels/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.TypeCoffeeId = new SelectList(db.TypeCoffeeModels, "Id", "Type", coffeeModels.TypeCoffeeId);
            return View(coffeeModels);
        }

        // POST: CoffeeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,NutritionInformation,Ingredients,Description,TypeCoffeeId,ImagenCoffee")] CoffeeModels coffeeModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coffeeModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TypeCoffeeId = new SelectList(db.TypeCoffeeModels, "Id", "Type", coffeeModels.TypeCoffeeId);
            return View(coffeeModels);
        }

        // GET: CoffeeModels/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(coffeeModels);
        }

        // POST: CoffeeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            db.CoffeeModels.Remove(coffeeModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }




        /**
         * 
         * 
         * */

        // GET: CoffeeModels/Details/5
        public ActionResult DetailsMenu(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoffeeModels coffeeModels = db.CoffeeModels.Find(id);
            if (coffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(coffeeModels);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsMenu
            ([Bind(Include = "Id,DateOrder,StatusOrderNameId,CoffeeId")] OrdersModels ordersModels)
        {
            if (ModelState.IsValid)
            {
                db.OrdersModels.Add(ordersModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoffeeId = new SelectList(db.CoffeeModels, "Id", "Title", ordersModels.CoffeeId);
            ViewBag.StatusOrderNameId = new SelectList(db.StatusOrderNameModels, "Id", "StatusName", ordersModels.StatusOrderNameId);
            return View(ordersModels);
        }

    }
}
