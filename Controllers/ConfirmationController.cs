using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class ConfirmationController : Controller
    {
        // GET: Confirmation
        public ActionResult Conf()
        {
            return View("Confirmation");
        }
    }
}