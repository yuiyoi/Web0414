using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410919166.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.woo = "555";
            ViewData["oow"] = 111;
            return View();
        }

        public ActionResult HW1()
        {
            return View();
        }

        public ActionResult HW2()
        {
            return View();
        }

        public ActionResult HW3()
        {
            return View();
        }
    }
}