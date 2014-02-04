using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuoteTest.Models;

namespace QuoteTest.Controllers
{
    public class AauthorsController : Controller
    {
        private QuoteTest.Models.Aauthor.AauthorDBContext db = new QuoteTest.Models.Aauthor.AauthorDBContext();

        //
        // GET: /Aauthors/

        public ActionResult Index()
        {
            return View(db.Aauthors.ToList());
        }

        //
        // GET: /Aauthors/Details/5

        public ActionResult Details(int id = 0)
        {
            Aauthor aauthor = db.Aauthors.Find(id);
            if (aauthor == null)
            {
                return HttpNotFound();
            }
            return View(aauthor);
        }

        //
        // GET: /Aauthors/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aauthors/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aauthor aauthor)
        {
            if (ModelState.IsValid)
            {
                db.Aauthors.Add(aauthor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aauthor);
        }

        //
        // GET: /Aauthors/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Aauthor aauthor = db.Aauthors.Find(id);
            if (aauthor == null)
            {
                return HttpNotFound();
            }
            return View(aauthor);
        }

        //
        // POST: /Aauthors/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Aauthor aauthor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aauthor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aauthor);
        }

        //
        // GET: /Aauthors/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Aauthor aauthor = db.Aauthors.Find(id);
            if (aauthor == null)
            {
                return HttpNotFound();
            }
            return View(aauthor);
        }

        //
        // POST: /Aauthors/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aauthor aauthor = db.Aauthors.Find(id);
            db.Aauthors.Remove(aauthor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}