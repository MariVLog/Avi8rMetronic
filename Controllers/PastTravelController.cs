using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class PastTravelController : Controller
    {
        // GET: PastTravel
        public ActionResult PaTrvl()
        {
            return View("PastTravel");
        }
    }
}