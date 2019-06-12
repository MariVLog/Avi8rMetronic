using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class BookingInfoController : Controller
    {
        // GET: BookingInfo
        public ActionResult BookInf()
        {
            return View("BookingInfo");
        }
    }
}