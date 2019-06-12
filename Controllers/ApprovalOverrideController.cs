using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class ApprovalOverrideController : Controller
    {
        // GET: ApprovalOverride
        public ActionResult AppOver()
        {
            return View("ApprovalOverride");
        }
    }
}