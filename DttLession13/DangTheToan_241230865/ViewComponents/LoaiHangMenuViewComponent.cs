using DangTheToan_241230865.Models;
using Microsoft.AspNetCore.Mvc;

namespace DangTheToan_241230865.ViewComponents
{
    public class LoaiHangMenuViewComponent : ViewComponent
    {
        private readonly QlhangHoaContext _context;
        public LoaiHangMenuViewComponent (QlhangHoaContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var loaiHangs = _context.LoaiHangs.ToList();
            return View(loaiHangs);
        }
    }
}
