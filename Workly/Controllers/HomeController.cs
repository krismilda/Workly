using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to Workly";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "TOP employers";

            return View();
        }
    }
}