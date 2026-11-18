using DangTheToan_241230865.Models;
using Microsoft.AspNetCore.Mvc;

namespace DangTheToan_241230865.ViewComponents
{
    public class TheLoaiViewComponent:ViewComponent
    {
        private readonly QLNhaSachContext _db;
        public TheLoaiViewComponent(QLNhaSachContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var listTheLoai = _db.TheLoais.ToList();
            return View(listTheLoai);
        }
    }
}
