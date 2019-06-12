using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class OfflineRequestsController : Controller
    {
        // GET: OfflineRequests
        public ActionResult OffReq()
        {
            return View("Offline");
        }
    }
}