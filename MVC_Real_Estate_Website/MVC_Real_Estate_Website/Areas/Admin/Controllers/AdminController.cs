using Real_Estate_Website.Filters;
using System.Web.Mvc;

namespace Real_Estate_Website.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [AuthorizationFilter]
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}