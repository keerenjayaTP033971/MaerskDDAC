using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Maersk_Line.Models;

namespace Maersk_Line.Controllers
{
    public class ShipsController : Controller
    {
        private Maersk_LineContext db = new Maersk_LineContext();

        public ActionResult Index()
        {
            return View(db.Ships.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ships ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShipCode,ShipName,ShipDescription,NumberOfContainersCarried")] Ships ships)
        {
            if (ModelState.IsValid)
            {
                db.Ships.Add(ships);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ships);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ships ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShipCode,ShipName,ShipDescription,NumberOfContainersCarried")] Ships ships)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ships).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ships);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ships ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ships ships = db.Ships.Find(id);
            db.Ships.Remove(ships);
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
