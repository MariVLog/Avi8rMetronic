using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class CarSearchController : Controller
    {
        // GET: CarSearch
        public ActionResult CrSearch()
        {
            return View("Cars");
        }
    }
}