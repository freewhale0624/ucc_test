using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_1.Models;
using Mod02_1.DAL;
using System.Net;
using System.Data.Entity;

namespace Mod02_1.Controllers
{
    public class OperaController : Controller
    {
        // GET: Opera
        //public ActionResult Index()
        //{
        //    Opera o = new Opera()
        //    {
        //        OperaID = 1,
        //        Title = "尤麗狄西",
        //        Year = 1600,
        //        Composer = "佩里"
        //    };
        //    return View(o);
        //}

        //public ActionResult Index(int? year)
        //{
        //    Opera o = new Opera()
        //    {
        //        OperaID = 1,
        //        Title = "尤麗狄西",
        //        Year = year,
        //        Composer = "佩里"
        //    };
        //    return View(o);
        //}

        //public ActionResult Index(Opera opera)
        //{
        //    Opera o = new Opera()
        //    {
        //        OperaID = opera.OperaID,
        //        Title = opera.Title,
        //        Year = opera.Year,
        //        Composer = opera.Composer
        //    };
        //    return View(o);
        //}

        private OperaContext context = new OperaContext();

        public ActionResult Index()
        {
            return View(context.Operas.ToList());
        }

        public ActionResult FilterData(int number)
        {
            //LINQ
            var query = (from o in context.Operas
                         orderby o.Year descending
                         select o).Take(number).ToList();

            return View("Index", query);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            return View(o);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Operas.Add(opera);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(opera);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = context.Operas.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }

        [HttpPost]
        public ActionResult Edit(Opera opera)
        {
            if (ModelState.IsValid)
            {
                context.Entry(opera).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(opera);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();

            return View(o);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Opera o = context.Operas.Find(id);
            context.Operas.Remove(o);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete2(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Opera o = context.Operas.Find(id);
            if (o == null)
                return HttpNotFound();
            context.Operas.Remove(o);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}