using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod02_1.Controllers
{
    public class HomeController : Controller
    {
        //Install-Package MvcSiteMapProvider.MVC5 -version 4.6.22
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}