using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class PassivesController : Controller
    {
        // GET: Passives
        public ActionResult Passv()
        {
            return View("Passives");
        }
    }
}