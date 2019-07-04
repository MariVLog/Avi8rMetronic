using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class FareRulesController : Controller
    {
        // GET: FareRules
        public ActionResult FrRls()
        {
            return View("FareRules");
        }
    }
}