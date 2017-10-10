using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThreeTrailsTaiko.Controllers
{
    public class PerformancesController : Controller
    {
        // GET: Performances
        public ActionResult Index()
        {
            return View();
        }
    }
}