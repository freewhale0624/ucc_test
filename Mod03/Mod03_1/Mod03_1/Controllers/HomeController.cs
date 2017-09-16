using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod03_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RedirDemo()
        {
            return RedirectToAction("Index");
        }

        public FileResult FileDemo()
        {
            return File(Server.MapPath(@"~/Content/Site.css"), "text/css");
        }

        public ActionResult ContentDemo()
        {
            return Content("<xml>xml demo</xml>", "text/xml");
        }

        public ActionResult JsonDemo()
        {
            return Json(
                new { name = "MVC5", StartDate = new DateTime(2014, 6, 30) },
                JsonRequestBehavior.AllowGet);

        }

        public ActionResult Index2()
        {
            ViewData["date1"] = DateTime.Now;
            ViewBag.date2 = DateTime.Now;

            return View();
        }
    }
}