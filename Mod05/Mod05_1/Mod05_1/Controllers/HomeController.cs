using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mod05_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //[HandleError]
        public ActionResult ExceptionDemo()
        {
            int i = 0;

            int j = 10 / i;

            return View();
        }


        protected override void OnException(ExceptionContext filterContext)
        {

            var msg = filterContext.Exception.Message;
            var actionName = filterContext.HttpContext.Request.Path;
            var controllerName = filterContext.Controller.ToString();

            System.IO.File.WriteAllText(Server.MapPath("~/log.txt"),
                $"{actionName} - {controllerName} \r\n {msg}");

            //filterContext.ExceptionHandled = true;
        }

    }
}