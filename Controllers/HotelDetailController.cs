using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class HotelDetailController : Controller
    {
        // GET: HotelDetail
        public ActionResult HtlDet()
        {
            return View("HotelDetail");
        }
    }
}