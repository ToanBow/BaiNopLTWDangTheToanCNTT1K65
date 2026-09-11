using Microsoft.AspNetCore.Mvc;

namespace DttLesson3.Controllers
{
    public class DttAboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "The Toan";
            ViewData["age"] = "20++";
            TempData["address"] = "Hà Nội";

            return View();
        }
    }
}
