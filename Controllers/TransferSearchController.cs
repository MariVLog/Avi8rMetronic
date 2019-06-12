using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class TransferSearchController : Controller
    {
        // GET: TransferSearch
        public ActionResult TrsfrSearch()
        {
            return View("Transfers");
        }
    }
}