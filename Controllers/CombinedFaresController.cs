﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class CombinedFaresController : Controller
    {
        // GET: CombinedFares
        public ActionResult CombFares()
        {
            return View("CombinedFares");
        }
    }
}