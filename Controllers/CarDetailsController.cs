using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avi8rMetronic.Controllers
{
    public class CarDetailsController : Controller
    {
        // GET: CarDetails
        public ActionResult CarDet()
        {
            return View("CarDetails");
        }
    }
}