using BaiTapTuan01.Services;
using System.Web.Mvc;

namespace BaiTapTuan01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetAll();
            ViewBag.Categories = categories;
            return View();
        }
    }
}