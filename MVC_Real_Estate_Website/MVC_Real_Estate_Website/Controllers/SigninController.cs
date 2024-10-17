using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_Estate_Website.Controllers
{
    public class SigninController : Controller
    {
        // GET: SignIn
        public ActionResult Signin()
        {
            return View();
        }

        // GET: SignUp
        public ActionResult SignUp()
        {
            return View();
        }
    }
}