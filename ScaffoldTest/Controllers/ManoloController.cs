using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScaffoldTest.Models;

namespace ScaffoldTest.Controllers
{
    public class ManoloController : Controller
    {
        private ScaffoldTextContext db = new ScaffoldTextContext();

        //
        // GET: /Manolo/

        public ActionResult Index()
        {
            return View(db.Manoloes.ToList());
        }

        //
        // GET: /Manolo/Details/5

        public ActionResult Details(int id = 0)
        {
            Manolo manolo = db.Manoloes.Find(id);
            if (manolo == null)
            {
                return HttpNotFound();
            }
            return View(manolo);
        }

        //
        // GET: /Manolo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Manolo/Create

        [HttpPost]
        public ActionResult Create(Manolo manolo)
        {
            if (ModelState.IsValid)
            {
                db.Manoloes.Add(manolo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manolo);
        }

        //
        // GET: /Manolo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Manolo manolo = db.Manoloes.Find(id);
            if (manolo == null)
            {
                return HttpNotFound();
            }
            return View(manolo);
        }

        //
        // POST: /Manolo/Edit/5

        [HttpPost]
        public ActionResult Edit(Manolo manolo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manolo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manolo);
        }

        //
        // GET: /Manolo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Manolo manolo = db.Manoloes.Find(id);
            if (manolo == null)
            {
                return HttpNotFound();
            }
            return View(manolo);
        }

        //
        // POST: /Manolo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Manolo manolo = db.Manoloes.Find(id);
            db.Manoloes.Remove(manolo);
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