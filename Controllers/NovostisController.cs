using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stranica.Models;

namespace Stranica.Controllers
{
    public class NovostisController : Controller
    {
        private NovostiContext db = new NovostiContext();

        // GET: Novostis
        public ActionResult Index()
        {
            return View(db.Novosti.ToList());
        }

        // GET: Novostis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novosti novosti = db.Novosti.Find(id);
            if (novosti == null)
            {
                return HttpNotFound();
            }
            return View(novosti);
        }

        // GET: Novostis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novostis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Author,Text,ImageUrl")] Novosti novosti)
        {
            if (ModelState.IsValid)
            {
                db.Novosti.Add(novosti);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(novosti);
        }

        // GET: Novostis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novosti novosti = db.Novosti.Find(id);
            if (novosti == null)
            {
                return HttpNotFound();
            }
            return View(novosti);
        }

        // POST: Novostis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Author,Text,ImageUrl")] Novosti novosti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(novosti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(novosti);
        }

        // GET: Novostis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novosti novosti = db.Novosti.Find(id);
            if (novosti == null)
            {
                return HttpNotFound();
            }
            return View(novosti);
        }

        // POST: Novostis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Novosti novosti = db.Novosti.Find(id);
            db.Novosti.Remove(novosti);
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
