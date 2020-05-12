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
    public class SuppliersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Suppliers
        public ActionResult Index()
        {
            return View(db.SupplierModels.ToList());
        }

        // GET: Suppliers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplierModels supplierModels = db.SupplierModels.Find(id);
            if (supplierModels == null)
            {
                return HttpNotFound();
            }
            return View(supplierModels);
        }

        // GET: Suppliers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,SupplierCode,SupplierName,Email,Phone,Address")] SupplierModels supplierModels)
        {
            if (ModelState.IsValid)
            {
                db.SupplierModels.Add(supplierModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(supplierModels);
        }

        // GET: Suppliers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplierModels supplierModels = db.SupplierModels.Find(id);
            if (supplierModels == null)
            {
                return HttpNotFound();
            }
            return View(supplierModels);
        }

        // POST: Suppliers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,SupplierCode,SupplierName,Email,Phone,Address")] SupplierModels supplierModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supplierModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supplierModels);
        }

        // GET: Suppliers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SupplierModels supplierModels = db.SupplierModels.Find(id);
            if (supplierModels == null)
            {
                return HttpNotFound();
            }
            return View(supplierModels);
        }

        // POST: Suppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SupplierModels supplierModels = db.SupplierModels.Find(id);
            db.SupplierModels.Remove(supplierModels);
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
