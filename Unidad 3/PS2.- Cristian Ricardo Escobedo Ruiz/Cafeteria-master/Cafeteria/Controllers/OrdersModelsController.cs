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
    public class OrdersModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: OrdersModels
        public ActionResult Index()
        {
            var ordersModels = db.OrdersModels.Include(o => o.Coffee).Include(o => o.StatusOrderName);
            return View(ordersModels.ToList());
        }

        // GET: OrdersModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdersModels ordersModels = db.OrdersModels.Find(id);
            if (ordersModels == null)
            {
                return HttpNotFound();
            }
            return View(ordersModels);
        }

        // GET: OrdersModels/Create
        public ActionResult Create()
        {
            ViewBag.CoffeeId = new SelectList(db.CoffeeModels, "Id", "Title");
            ViewBag.StatusOrderNameId = new SelectList(db.StatusOrderNameModels, "Id", "StatusName");
            return View();
        }

        // POST: OrdersModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DateOrder,Cantidad,StatusOrderNameId,CoffeeId")] OrdersModels ordersModels)
        {
            if (ModelState.IsValid)
            {
                db.OrdersModels.Add(ordersModels);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }

            ViewBag.CoffeeId = new SelectList(db.CoffeeModels, "Id", "Title", ordersModels.CoffeeId);
            ViewBag.StatusOrderNameId = new SelectList(db.StatusOrderNameModels, "Id", "StatusName", ordersModels.StatusOrderNameId);
            return View(ordersModels);
        }

        // GET: OrdersModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdersModels ordersModels = db.OrdersModels.Find(id);
            if (ordersModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoffeeId = new SelectList(db.CoffeeModels, "Id", "Title", ordersModels.CoffeeId);
            ViewBag.StatusOrderNameId = new SelectList(db.StatusOrderNameModels, "Id", "StatusName", ordersModels.StatusOrderNameId);
            return View(ordersModels);
        }

        // POST: OrdersModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DateOrder,Cantidad,StatusOrderNameId,CoffeeId")] OrdersModels ordersModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ordersModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoffeeId = new SelectList(db.CoffeeModels, "Id", "Title", ordersModels.CoffeeId);
            ViewBag.StatusOrderNameId = new SelectList(db.StatusOrderNameModels, "Id", "StatusName", ordersModels.StatusOrderNameId);
            return View(ordersModels);
        }

        // GET: OrdersModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdersModels ordersModels = db.OrdersModels.Find(id);
            if (ordersModels == null)
            {
                return HttpNotFound();
            }
            return View(ordersModels);
        }

        // POST: OrdersModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdersModels ordersModels = db.OrdersModels.Find(id);
            db.OrdersModels.Remove(ordersModels);
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
