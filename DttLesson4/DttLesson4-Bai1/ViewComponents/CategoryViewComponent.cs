using DttLesson4.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttLesson3.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    CategoryId = 1, CategoryName = "Điện tử"
                },
                new Category
                {
                    CategoryId = 1, CategoryName = "Điện lạnh"
                },
                new Category
                {
                    CategoryId = 1, CategoryName = "Đồ gia dụng"
                },
                new Category
                {
                    CategoryId = 1, CategoryName = "Tiện ích"
                },
            };
            n = n ?? 0;
            var search = categories.Where(x => x.CategoryId > n);
            return View(categories);
        }
    }
}
