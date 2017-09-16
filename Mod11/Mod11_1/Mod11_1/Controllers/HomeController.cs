using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod11_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            TempData["name"] = "Test data";
            return RedirectToAction("TempDataDemo");

        }

        public ActionResult TempDataDemo()
        {
            TempData["name"] = TempData["name"] + DateTime.Now.ToString();

            return View();
        }

        public ActionResult SessionDemo()
        {
            if (Session["count"] == null)
                Session["count"] = 0;
            else
                Session["count"] = (int)Session["count"] + 1;

            return View();
        }

        public ActionResult ApplicationDemo()
        {
            if (HttpContext.Application["count"] == null)
                HttpContext.Application["count"] = 0;
            else
                HttpContext.Application["count"] = 
                    (int)HttpContext.Application["count"] + 1;

            return View();
        }
    }
}