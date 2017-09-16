using Mod04_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mod04_7.Models;

namespace Mod04_7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DemoDropdownlist()
        {

            string[] ary = { "AA", "BB", "CC", "DD" };
            ViewBag.source = new SelectList(ary);
            return View();
        }

        //3
        [HttpPost]
        public ActionResult DemoDropdownlist(FormCollection fc)
        {
            ViewBag.select = fc["source"];

            string[] ary = { "AA", "BB", "CC", "DD" };
            ViewBag.source = new SelectList(ary, fc["source"]);

            return View();
        }

        public ActionResult DemoDropdownlist2()
        {

            List<Comment> cList = new List<Comment>() {
                new Comment(){ Id=1 , Subject="AA" },
                new Comment(){ Id=2 , Subject="BB" },
                new Comment(){ Id=3 , Subject="CC" }
            };
            ViewBag.source = new SelectList(cList, "Id", "Subject");

            return View("DemoDropdownlist");
        }

        [HttpPost]
        public ActionResult DemoDropdownlist2(FormCollection fc)
        {
            List<Comment> cList = new List<Comment>() {
                new Comment(){ Id=1 , Subject="AA" },
                new Comment(){ Id=2 , Subject="BB" },
                new Comment(){ Id=3 , Subject="CC" }
            };
            ViewBag.source = new SelectList(cList, "Id", "Subject", fc["source"]);

            ViewBag.select = fc["source"];

            return View("DemoDropdownlist");
        }


        public ActionResult GetComments()
        {
            List<Comment> data = new List<Comment> {
                 new Comment{Id=100,Subject="A"},
                 new Comment{Id=200,Subject="B"},
                 new Comment{Id=300,Subject="C"}
               };
            return View(data);
        }

        public ActionResult GetOtherComments()
        {
            List<Comment> data = new List<Comment> {
                  new Comment{Id=500,Subject="E"},
                  new Comment{Id=600,Subject="F"},
                  new Comment{Id=700,Subject="G"}
              };

            return View(data);
        }

    }
}