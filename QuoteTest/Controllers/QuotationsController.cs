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
    public class QuotationsController : Controller
    {
        private QuoteDBContext db = new QuoteDBContext();

        //
        // GET: /Quotations/

        public ActionResult Index()
        {
            return View(db.Quotations.ToList());
        }

        //
        // GET: /Quotations/Details/5

        public ActionResult Details(int id = 0)
        {
            Quote quote = db.Quotations.Find(id);
            if (quote == null)
            {
                return HttpNotFound();
            }
            return View(quote);
        }

        //
        // GET: /Quotations/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Quotations/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quote quote)
        {
            if (ModelState.IsValid)
            {
                db.Quotations.Add(quote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quote);
        }

        //
        // GET: /Quotations/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Quote quote = db.Quotations.Find(id);
            if (quote == null)
            {
                return HttpNotFound();
            }
            return View(quote);
        }

        //
        // POST: /Quotations/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Quote quote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quote);
        }

        //
        // GET: /Quotations/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Quote quote = db.Quotations.Find(id);
            if (quote == null)
            {
                return HttpNotFound();
            }
            return View(quote);
        }

        //
        // POST: /Quotations/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quote quote = db.Quotations.Find(id);
            db.Quotations.Remove(quote);
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