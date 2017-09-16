using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mod02_1.DAL;
using Mod02_1.Models;
using System.Diagnostics;

namespace Mod02_1.Controllers
{
    //[LogActionFilter]
    public class Opera3Controller : Controller
    {
        private OperaContext db = new OperaContext();

        // GET: Opera3
        //[LogActionFilter]
        public async Task<ActionResult> Index()
        {
            Debug.WriteLine("Opera.Index");
            return View(await db.Operas.ToListAsync());
        }

        // GET: Opera3/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera opera = await db.Operas.FindAsync(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            return View(opera);
        }

        // GET: Opera3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Opera3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "OperaID,Title,Year,Composer")] Opera opera)
        {
            if (ModelState.IsValid)
            {
                db.Operas.Add(opera);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        // GET: Opera3/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera opera = await db.Operas.FindAsync(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            return View(opera);
        }

        // POST: Opera3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "OperaID,Title,Year,Composer")] Opera opera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(opera).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        // GET: Opera3/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opera opera = await db.Operas.FindAsync(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            return View(opera);
        }

        // POST: Opera3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Opera opera = await db.Operas.FindAsync(id);
            db.Operas.Remove(opera);
            await db.SaveChangesAsync();
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
