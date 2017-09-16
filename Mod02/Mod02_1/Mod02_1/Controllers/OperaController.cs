using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod02_1.Models;
using Mod02_1.DAL;

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

        private OperaContext context= new OperaContext();

        public ActionResult Index()
        {
            return View(context.Operas.ToList());
        }
    }
}