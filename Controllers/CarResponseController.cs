using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class CarResponseController : Controller
    {
        // GET: CarResponse
        public ActionResult CarResp()
        {
            return View("CarResponse");
        }
    }
}