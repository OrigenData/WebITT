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
    [Authorize]
    public class TypeCoffeeModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TypeCoffeeModels
        public ActionResult Index()
        {
            return View(db.TypeCoffeeModels.ToList());
        }

        // GET: TypeCoffeeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeCoffeeModels typeCoffeeModels = db.TypeCoffeeModels.Find(id);
            if (typeCoffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(typeCoffeeModels);
        }

        // GET: TypeCoffeeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeCoffeeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type")] TypeCoffeeModels typeCoffeeModels)
        {
            if (ModelState.IsValid)
            {
                db.TypeCoffeeModels.Add(typeCoffeeModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeCoffeeModels);
        }

        // GET: TypeCoffeeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeCoffeeModels typeCoffeeModels = db.TypeCoffeeModels.Find(id);
            if (typeCoffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(typeCoffeeModels);
        }

        // POST: TypeCoffeeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type")] TypeCoffeeModels typeCoffeeModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeCoffeeModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeCoffeeModels);
        }

        // GET: TypeCoffeeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeCoffeeModels typeCoffeeModels = db.TypeCoffeeModels.Find(id);
            if (typeCoffeeModels == null)
            {
                return HttpNotFound();
            }
            return View(typeCoffeeModels);
        }

        // POST: TypeCoffeeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeCoffeeModels typeCoffeeModels = db.TypeCoffeeModels.Find(id);
            db.TypeCoffeeModels.Remove(typeCoffeeModels);
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
    }
}
