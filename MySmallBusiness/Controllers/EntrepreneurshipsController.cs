using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MySmallBusiness.Models;

namespace MySmallBusiness.Controllers
{
    public class EntrepreneurshipsController : Controller
    {
        private BusinessContext db = new BusinessContext();

        // GET: Entrepreneurships
        public ActionResult Index()
        {
            var entrepreneurships = db.Entrepreneurships.Include(e => e.Category);
            return View(entrepreneurships.ToList());
        }

        // GET: Entrepreneurships/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrepreneurship entrepreneurship = db.Entrepreneurships.Find(id);
            if (entrepreneurship == null)
            {
                return HttpNotFound();
            }
            return View(entrepreneurship);
        }

        // GET: Entrepreneurships/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName");
            return View();
        }

        // POST: Entrepreneurships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,CreationDate,CategoryID,Description")] Entrepreneurship entrepreneurship)
        {
            if (ModelState.IsValid)
            {
                db.Entrepreneurships.Add(entrepreneurship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName", entrepreneurship.CategoryID);
            return View(entrepreneurship);
        }

        // GET: Entrepreneurships/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrepreneurship entrepreneurship = db.Entrepreneurships.Find(id);
            if (entrepreneurship == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName", entrepreneurship.CategoryID);
            return View(entrepreneurship);
        }

        // POST: Entrepreneurships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,CreationDate,CategoryID,Description")] Entrepreneurship entrepreneurship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrepreneurship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "ID", "CategoryName", entrepreneurship.CategoryID);
            return View(entrepreneurship);
        }

        // GET: Entrepreneurships/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entrepreneurship entrepreneurship = db.Entrepreneurships.Find(id);
            if (entrepreneurship == null)
            {
                return HttpNotFound();
            }
            return View(entrepreneurship);
        }

        // POST: Entrepreneurships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Entrepreneurship entrepreneurship = db.Entrepreneurships.Find(id);
            db.Entrepreneurships.Remove(entrepreneurship);
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
