using System.Web.Mvc;

namespace Real_Estate_Website.Filters
{
    public class AuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.IsInRole("Admin"))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}