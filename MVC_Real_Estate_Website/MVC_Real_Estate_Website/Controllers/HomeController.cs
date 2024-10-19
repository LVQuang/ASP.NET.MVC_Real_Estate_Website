using BaiTapTuan01.Services;
using Real_Estate_Website.Filters;
using System.Web.Mvc;

namespace BaiTapTuan01.Controllers
{
    public class HomeController : Controller
    {
        [AuthenticationFilter]
        public ActionResult Index()
        {
            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetAll();
            ViewBag.Categories = categories;
            return View();
        }

        public ActionResult getNewEstates()
        {
            return PartialView();
        }

        public ActionResult getPopularLocations()
        {
            return PartialView();
        }
    }
}