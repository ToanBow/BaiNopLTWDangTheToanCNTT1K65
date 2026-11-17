using System.Diagnostics;
using DangTheToan_241230865.Models;
using Microsoft.AspNetCore.Mvc;

namespace DangTheToan_241230865.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlhangHoaContext _context;
        public HomeController(QlhangHoaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var hangHoas = _context.HangHoas;
            return View(hangHoas);
        }
    }
}
