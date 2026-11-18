using System.Diagnostics;
using DangTheToan_241230865.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DangTheToan_241230865.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLNhaSachContext _db;
        public HomeController(QLNhaSachContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.SectionTitle = "Đặng Thế Toàn";
            var listSach = _db.Saches.Where(s => s.Gia != null && s.Gia >= 100).ToList();
            return View(listSach);
        }

        [HttpGet]
        public IActionResult GetSachByTheLoai(int maTL)
        {
            var theLoai = _db.TheLoais.Find(maTL);
            ViewBag.SectionTitle = theLoai != null ? theLoai.TenTl : "Danh sách sách";

            var listSach = _db.Saches.Where(s => s.MaTl == maTL).ToList();
            return PartialView("_SachList", listSach);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaTL = new SelectList(_db.TheLoais.ToList(), "MaTl", "TenTl");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sach sach)
        {
            if (ModelState.IsValid)
            {
                _db.Saches.Add(sach);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.MaTL = new SelectList(_db.TheLoais.ToList(), "MaTl", "TenTl", sach.MaTl);
            return View(sach);
        }
    }
}
