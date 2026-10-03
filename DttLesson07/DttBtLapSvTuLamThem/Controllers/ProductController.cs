using DttBtLapSvTuLamThem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DttBtLapSvTuLamThem.Controllers
{
    public class ProductController : Controller
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Điện thoại" },
            new Category { Id = 2, Name = "Laptop" },
            new Category { Id = 3, Name = "Phụ kiện" }
        };
        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "iPhone 15 Pro Max", Price = 25000000, SalePrice = 22000000, Description = "Sản phẩm chính hãng Apple", CategoryId = 1, Image = "iphone15.jpg" },
            new Product { Id = 2, Name = "MacBook Pro M3", Price = 38000000, SalePrice = 35000000, Description = "Laptop hiệu năng cao", CategoryId = 2, Image = "macbook.jpg" }
        };
        // GET: ProductController
        public ActionResult Index()
        {
            foreach(var p in _products)
            {
                p.Category = _categories.FirstOrDefault(c => c.Id == p.CategoryId);
            }
            return View(_products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.CategoryList = new SelectList(_categories, "Id", "Name");
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Product product)
        {
            if(product.SalePrice >= product.Price * 0.9f)
            {
                ModelState.AddModelError("SalePrice", "Giá khuyến mãi phải nhỏ hơn giá gốc ít nhất 10%");
            }

            if (product.ImageFile != null)
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/products");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + product.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await product.ImageFile.CopyToAsync(fileStream);
                }
                product.Image = uniqueFileName;
            }
            if (ModelState.IsValid)
            {
                product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
                _products.Add(product);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.CategoryList = new SelectList(_categories, "Id", "Name", product.CategoryId);
            return View(product);
        }


        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            product.Category=_categories.FirstOrDefault(c=>c.Id==product.CategoryId);
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            for(int i = 0; i < _products.Count; i++)
            {
                _products.Remove(_products[i]);
                break;
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
