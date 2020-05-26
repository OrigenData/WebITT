using ControlInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace ControlInventario.Controllers
{
    public class UsersController : Controller
    {
        readonly ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult ViewProfile()
        {
            var id = User.Identity.GetUserId();
            var user = db.Users.Find(id);
            return View(user);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult EditProfile(HttpPostedFileBase Picture)
        {
            if (Picture!=null)
            {
                string nombreArchivo = System.IO.Path.GetFileName(Picture.FileName);
                string filePath = "~/Content/img/perfil/" + User.Identity.GetUserName()+ "_"+ nombreArchivo ;
                Picture.SaveAs(Server.MapPath(filePath));

                var id=User.Identity.GetUserId();
                var userdb = db.Users.Find(id);
                userdb.Picture = User.Identity.GetUserName()+"_"+nombreArchivo;
                db.Entry(userdb).State = EntityState.Modified;
                db.SaveChanges();

            }

            return RedirectToAction("ViewProfile","Users");
        }

       
    }
}
