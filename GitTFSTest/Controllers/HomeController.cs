using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTFSTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // This is change 3
            ViewBag.Title = "GitTFSTest";
            return View();
        }

        public ActionResult About()
        {
            // This is change 1
            ViewBag.Message = "Description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // This is change 2
            ViewBag.Message = "My contact page.";

            return View();
        }
    }
}