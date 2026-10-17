using System.Diagnostics;
using DttLapBaiSinhVienTuLamBai1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttLapBaiSinhVienTuLamBai1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
