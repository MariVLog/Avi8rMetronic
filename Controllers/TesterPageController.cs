﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class TesterPageController : Controller
    {
        // GET: TesterPage
        public ActionResult TesterPage()
        {
            return View("TesterPage");
        }
    }
}