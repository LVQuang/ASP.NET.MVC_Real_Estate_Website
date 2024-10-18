using Real_Estate_Website.DTO.Request;
using Real_Estate_Website.Services;
using System;
using System.Web.Mvc;


namespace Real_Estate_Website.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly AuthenticationService authenticationService;
        public AuthenticationController()
        {
            authenticationService = new AuthenticationService();
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
            authenticationService.Register(requestRegister);
            return RedirectToAction("Index", "Home");
        }

        // GET: LogIn
        public ActionResult LogIn()
        {
            return View();
        }

        // POST: LogIn  
        [HttpPost]
        public ActionResult LogIn(LogIn loginRequest)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("New Error", "Invalid Data");
                return View();
            }
            authenticationService.LogIn(loginRequest);
            return RedirectToAction("Index", "Home");
        }

        // GET: LogOut
        public ActionResult LogOut()
        {
            authenticationService.LogOut();
            return RedirectToAction("Index", "Home");
        }
    }
}