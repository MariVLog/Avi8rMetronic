using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class SavedTravelController : Controller
    {
        // GET: SavedTravel
        public ActionResult SvTrvl()
        {
            return View("SavedTravel");
        }
    }
}