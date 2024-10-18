using Real_Estate_Website.DTO.Request;
using Real_Estate_Website.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Real_Estate_Website.Mapper;
using System.Web;

namespace Real_Estate_Website.Services
{
    public class AuthenticationService
    {
        private readonly AppUserManager userManager;
        private readonly UserMapper userMapper;

        public AuthenticationService()
        {
            userManager = new AppUserManager(new AppUserStore(new IdentityDB()));
            userMapper = new UserMapper();
        }
        public void Register(Register registerRequest)
        {
            var user = userMapper.RegisterToAppUser(registerRequest);
            IdentityResult identityResult = userManager.Create(user);
            if (identityResult.Succeeded)
            {
                userManager.AddToRole(user.Id, "Customer");
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
            }
        }

        public void LogIn(LogIn loginRequest)
        {
            var user = userManager.Find(loginRequest.UserName, loginRequest.Password);
            if (user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
            }
        }
        public void LogOut()
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
        }
    }
}