using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Website.Controllers
{
    public class ListingController : Controller
    {
        // GET: Listing
        public ActionResult Listing()
        {
            return View();
        }
    }
}