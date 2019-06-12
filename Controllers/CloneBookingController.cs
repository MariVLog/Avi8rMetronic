using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class CloneBookingController : Controller
    {
        // GET: CloneBooking
        public ActionResult ClnBook()
        {
            return View("CloneBooking");
        }
    }
}