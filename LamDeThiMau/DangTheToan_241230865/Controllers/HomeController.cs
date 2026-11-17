using System.Diagnostics;
using DangTheToan_241230865.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DangTheToan_241230865.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLHangHoaContext _db;
        public HomeController(QLHangHoaContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listHangHoa = _db.HangHoas.Where(
                h => h.Gia >= 100).ToList();
            return View(listHangHoa);
        }
        [HttpGet]
        public IActionResult GetHangHoaByLoai(int maLoai)
        {
            var listHangHoa = _db.HangHoas.Where(h => h.MaLoai == maLoai && h.Gia >= 100).ToList();
            return PartialView("_HangHoaList", listHangHoa);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                _db.HangHoas.Add(hangHoa);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.MaLoai = new SelectList(_db.LoaiHangs.ToList(), "MaLoai", "TenLoai", hangHoa.MaLoai);
            return View(hangHoa);
        }
    }
}
