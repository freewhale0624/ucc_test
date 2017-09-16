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

    }
}