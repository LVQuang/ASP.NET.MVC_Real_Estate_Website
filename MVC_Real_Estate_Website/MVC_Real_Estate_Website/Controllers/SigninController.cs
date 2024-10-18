using Real_Estate_Website.DTO.Request;
using Real_Estate_Website.Services;
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

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        public ActionResult Register(Register requestRegister)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("New Error", "Invalid Data");
                return View();
            }
            AuthenticationService authenticationService = new AuthenticationService();
            authenticationService.Register(requestRegister);
            return RedirectToAction("Index", "Home");
        }
    }
}