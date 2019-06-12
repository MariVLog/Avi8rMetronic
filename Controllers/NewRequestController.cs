using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class NewRequestController : Controller
    {
        // GET: NewRequest
        public ActionResult NewReq()
        {
            return View("NewRequest");
        }
    }
}