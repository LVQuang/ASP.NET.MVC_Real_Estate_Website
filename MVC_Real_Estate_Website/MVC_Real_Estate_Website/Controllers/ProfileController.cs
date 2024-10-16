using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Website.Controllers
{
    public class ProfileController : Controller
    {

        // GET: Profile
        public ActionResult Overview()
        {
            return View();
        }

        public ActionResult Wallet()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Settings()
        {
            return View();
        }

        public ActionResult HelpCenter()
        {
            return View();
        }
    }
}