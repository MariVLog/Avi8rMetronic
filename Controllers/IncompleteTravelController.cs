using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class IncompleteTravelController : Controller
    {
        // GET: IncompleteTravel
        public ActionResult IncTrvl()
        {
            return View("IncompleteTravel");
        }
    }
}