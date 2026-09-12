using Microsoft.AspNetCore.Mvc;
using DttBaiTapLab.Models;
using System.Diagnostics.Eventing.Reader;

namespace DttBaiTapLab.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        protected Product product = new Product();
        public IViewComponentResult Invoke()
        {
            var products = product.GetProductList();
            return View(products);
        }
    }
}
