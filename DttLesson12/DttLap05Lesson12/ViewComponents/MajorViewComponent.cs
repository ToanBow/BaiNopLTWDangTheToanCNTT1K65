using DttLap05Lesson12.Data;
using DttLap05Lesson12.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttLap05Lesson12.ViewComponents
{
    public class MajorViewComponent:ViewComponent
    {
        SchoolContext db;
        List<Major> majors;
        public MajorViewComponent(SchoolContext _context)
        {
            db = _context;
            var majors = db.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View("~/Views/Shared/Components/Major/Default.cshtml",majors);
        }
    }
}
