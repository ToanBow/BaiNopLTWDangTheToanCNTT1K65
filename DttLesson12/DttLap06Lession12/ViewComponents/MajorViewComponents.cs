using DttLap06Lession12.Data;
using DttLap06Lession12.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttLap06Lession12.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;

        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            majors = db.Majors.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(majors);
        }
    }
}