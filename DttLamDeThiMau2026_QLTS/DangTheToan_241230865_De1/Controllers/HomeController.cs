using System.Diagnostics;
using DangTheToan_241230865_De1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DangTheToan_241230865_De1.Controllers
{
    public class HomeController : Controller
    {
        private readonly QltaisanContext _db;
        public HomeController(QltaisanContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _db.TaiSans
                .Where(t => t.NguyenGia != null && t.NguyenGia >= 20).ToListAsync();
            ViewBag.TieuDe = "Đặng Thế Toàn";
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> LocTheoLoai(int maLoai)
        {
            if (maLoai == 0)
            {
                var defaultList = await _db.TaiSans
                    .Where(t => t.NguyenGia != null && t.NguyenGia >= 20).ToListAsync();
                ViewBag.TieuDe = "Đặng Thế Toàn";
                return PartialView("_DanhSachTaiSan",defaultList);
            }

            var loai = await _db.LoaiTaiSans.FindAsync(maLoai);
            var list = await _db.TaiSans.Where(t => t.MaLoai == maLoai).ToListAsync();

            ViewBag.TieuDe = loai?.TenLoai ?? "Danh sách tài sản";
            return PartialView("_DanhSachTaiSan", list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(_db.LoaiTaiSans, "MaLoai", "TenLoai");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(TaiSan taiSan)
        {
            if (ModelState.IsValid)
            {
                _db.TaiSans.Add(taiSan);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.MaLoai = new SelectList(_db.LoaiTaiSans, "MaLoai", "TenLoai", taiSan.MaLoai);
            return View(taiSan);
        }
    }
}
