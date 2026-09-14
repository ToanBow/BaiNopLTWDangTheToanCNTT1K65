using DtLesson05Components.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DtLesson05Components.ViewComponents
{
    public class DttCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(bool? active)
        {
            var categories = new List<DttCategory>
            {
                new DttCategory { CategoryId = 1, CategoryName = "Test", IsActive = true },
                new DttCategory { CategoryId = 2, CategoryName = "Test", IsActive = true },
                new DttCategory { CategoryId = 3, CategoryName = "Test", IsActive = true },
                new DttCategory { CategoryId = 4, CategoryName = "Test", IsActive = true }
            };
            active = active ?? true;
            categories = categories.Where(c => c.IsActive == active.Value).ToList();
            

            return View(categories);
        }
    }
}
