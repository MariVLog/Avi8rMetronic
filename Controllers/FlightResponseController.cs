using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class FlightResponseController : Controller
    {
        // GET: FlightResponse
        public ActionResult FlResp()
        {
            return View("FlightResponse");
        }
    }
}