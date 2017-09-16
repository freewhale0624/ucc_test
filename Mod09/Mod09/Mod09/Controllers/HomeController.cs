using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectorDemo()
        {
            return View();
        }

        public ActionResult JsonData(string id, string name)
        {
            if (Request.IsAjaxRequest())
            {
                var data = new { empId = id, EmpName = name, Age = 25 };
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            return View();
        }

        public ActionResult AjaxDemo()
        {
            return View();
        }


        public ActionResult Index2()
        {
            return View();
        }

    }
}