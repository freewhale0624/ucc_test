using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mod02_1.DAL;
using Mod02_1.Models;

namespace Mod02_1.Controllers
{
    public class Opera2Controller : Controller
    {
        private OperaContext db = new OperaContext();

        // GET: Opera2
        public ActionResult Index()
        {
            return View(db.Operas.ToList());
        }

        // GET: Opera2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera opera = db.Operas.Find(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            return View(opera);
        }

        // GET: Opera2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opera2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OperaID,Title,Year,Composer")] Opera opera)
        {
            if (ModelState.IsValid)
            {
                db.Operas.Add(opera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        // GET: Opera2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera opera = db.Operas.Find(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            return View(opera);
        }

        // POST: Opera2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OperaID,Title,Year,Composer")] Opera opera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(opera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        // GET: Opera2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera opera = db.Operas.Find(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            return View(opera);
        }

        // POST: Opera2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Opera opera = db.Operas.Find(id);
            db.Operas.Remove(opera);
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
