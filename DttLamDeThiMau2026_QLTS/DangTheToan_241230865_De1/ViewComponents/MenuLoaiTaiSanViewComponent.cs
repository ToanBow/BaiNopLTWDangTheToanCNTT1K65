using DangTheToan_241230865_De1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DangTheToan_241230865_De1.ViewComponents
{
    public class MenuLoaiTaiSanViewComponent:ViewComponent
    {
        private readonly QltaisanContext _db;
        public MenuLoaiTaiSanViewComponent(QltaisanContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(){
            var list = await _db.LoaiTaiSans.ToListAsync();
            return View(list);
        }
    }
}
