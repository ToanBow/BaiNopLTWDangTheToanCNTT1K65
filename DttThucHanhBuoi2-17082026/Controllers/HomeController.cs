using Microsoft.AspNetCore.Mvc;
using DttThucHanhBuoi2_17082026.Models;

namespace DttThucHanhBuoi2_17082026.Controllers;

public class HomeController : Controller
{
    private static readonly IReadOnlyList<Product> SampleData =
    [
        new(1, "Product Name 1", 500000m, new DateTime(2020, 12, 25), "/images/bag1.jpg"),
        new(2, "Product Name 2", 700000m, new DateTime(2020, 12, 25), "/images/bag2.jpg"),
        new(3, "Product Name 3", 550000m, new DateTime(2020, 12, 25), "/images/bag3.jpg"),
        new(4, "Product Name 4", 550000m, new DateTime(2020, 12, 25), "/images/bag4.jpg")
    ];

    [HttpGet]
    public IActionResult Index() => RedirectToAction(nameof(TrangChu));

    [HttpGet]
    public IActionResult TrangChu() => View(SampleData);

    [HttpGet]
    public IActionResult SanPham() => View(SampleData);

    [HttpGet]
    public IActionResult GioiThieu() => View();

    [HttpGet]
    public IActionResult LienHe() => View();
}