using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity.EntityFramework;
using Real_Estate_Website.Identity;

[assembly: OwinStartup(typeof(Real_Estate_Website.Startup))]

namespace Real_Estate_Website
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            this.InitRoleAndUser();

        }

        private void InitRoleAndUser()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new IdentityDB()));
            var userManager = new AppUserManger(new AppUserStore(new IdentityDB()));

            InitAdmin(roleManager, userManager);
            InitCustomerRole(roleManager, userManager);
        }

        private void InitAdmin(
            RoleManager<IdentityRole> roleManager, AppUserManger userManger)
        {
            if(!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }

            if (userManger.FindByName("admin") == null)
            {
                var user = new AppUser();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";
                string userPassword = "admin123";
                var checkUser = userManger.Create(user, userPassword);
                if (checkUser.Succeeded)
                {
                    userManger.AddToRole(user.Id, "Admin");
                }
            }
        }

        private void InitCustomerRole(
            RoleManager<IdentityRole> roleManager, AppUserManger userManger)
        {
            if (!roleManager.RoleExists("Customer"))
            {
                var role = new IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
        }
    }
}
