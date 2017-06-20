using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using C4W.Web.Models;

namespace C4W.Web.Controllers
{
    public class ContactoLandingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ContactoLandings
        public ActionResult Index()
        {
            return View(db.ContactosLanding.ToList());
        }

        // GET: ContactoLandings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactoLanding contactoLanding = db.ContactosLanding.Find(id);
            if (contactoLanding == null)
            {
                return HttpNotFound();
            }
            return View(contactoLanding);
        }

        // GET: ContactoLandings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactoLandings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Pais,Email,Ciudad,Telefono,Landing")] ContactoLanding contactoLanding)
        {
            if (ModelState.IsValid)
            {
                db.ContactosLanding.Add(contactoLanding);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactoLanding);
        }

        // GET: ContactoLandings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactoLanding contactoLanding = db.ContactosLanding.Find(id);
            if (contactoLanding == null)
            {
                return HttpNotFound();
            }
            return View(contactoLanding);
        }

        // POST: ContactoLandings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Pais,Email,Ciudad,Telefono,Landing")] ContactoLanding contactoLanding)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactoLanding).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactoLanding);
        }

        // GET: ContactoLandings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactoLanding contactoLanding = db.ContactosLanding.Find(id);
            if (contactoLanding == null)
            {
                return HttpNotFound();
            }
            return View(contactoLanding);
        }

        // POST: ContactoLandings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactoLanding contactoLanding = db.ContactosLanding.Find(id);
            db.ContactosLanding.Remove(contactoLanding);
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
