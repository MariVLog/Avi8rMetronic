using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class QuotationsController : Controller
    {
        // GET: Quotations
        public ActionResult Quotations()
        {
            return View("Quotations");
        }
    }
}