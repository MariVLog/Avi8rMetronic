using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class ApprovalInboxController : Controller
    {
        // GET: ApprovalInbox
        public ActionResult AppInbx()
        {
            return View("ApprovalInbox");
        }
    }
}