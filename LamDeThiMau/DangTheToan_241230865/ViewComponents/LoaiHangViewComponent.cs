using DangTheToan_241230865.Models;
using Microsoft.AspNetCore.Mvc;

namespace DangTheToan_241230865.ViewComponents
{
    public class LoaiHangViewComponent:ViewComponent
    {
        private readonly QLHangHoaContext _db;
        public LoaiHangViewComponent(QLHangHoaContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var loaiHangs = _db.LoaiHangs.ToList();
            return View(loaiHangs);
        }
    }
}
