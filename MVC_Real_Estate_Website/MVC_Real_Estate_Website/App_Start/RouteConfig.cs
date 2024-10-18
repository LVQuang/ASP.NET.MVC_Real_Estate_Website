using System.Web.Mvc;
using System.Web.Routing;

namespace BaiTapTuan01
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Help Center",
                url: "profile/help-center",
                defaults: new { controller = "Profile", action = "HelpCenter" }
            );

            routes.MapRoute(
                name: "Settings",
                url: "profile/settings",
                defaults: new { controller = "Profile", action = "Settings" }
            );

            routes.MapRoute(
                name: "Profile",
                url: "profile/profile",
                defaults: new { controller = "Profile", action = "Profile" }
            );

            routes.MapRoute(
                name: "Wallet",
                url: "profile/wallet",
                defaults: new { controller = "Profile", action = "Wallet" }
            );

            routes.MapRoute(
                name: "Overview",
                url: "profile/overview",
                defaults: new { controller = "Profile", action = "Overview" }
            );

            routes.MapRoute(
                name: "Register",
                url: "Register",
                defaults: new { controller = "Signin", action = "Register" }
            );

            routes.MapRoute(
                name: "Sign In",
                url: "signin",
                defaults: new { controller = "Signin", action = "Signin" }
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Contact", action = "Contact" }
            );

            routes.MapRoute(
                name: "About",
                url: "about",
                defaults: new { controller = "About", action = "About" }
            );

            routes.MapRoute(
                name: "Detail",
                url: "detail",
                defaults: new { controller = "Detail", action = "Detail" }
            );

            routes.MapRoute(
                name: "Listing",
                url: "listing",
                defaults: new { controller = "Listing", action = "Listing" }
            );

            routes.MapRoute(
                name: "Home",
                url: "home",
                defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
