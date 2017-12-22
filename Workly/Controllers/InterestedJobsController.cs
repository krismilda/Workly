using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workly.Controllers
{
    public class InterestedJobsController : Controller
    {
        // GET: InterestedJobs
        public ActionResult Index()
        {
            return View();
        }
    }
}