using DttBaiTapLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttBaiTapLab.Controllers
{
    public class ProductController : Controller
    {
        protected Product products = new Product();
        protected DanhMuc danhmucs = new DanhMuc();

        public IActionResult Index()
        {
            var product = products.GetProductList();
            ViewBag.DanhMuc = danhmucs.GetDanhMucs();
            return View(product);
        }
    }
}
