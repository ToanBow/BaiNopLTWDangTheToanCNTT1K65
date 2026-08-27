using Microsoft.AspNetCore.Mvc;
using DttThucHanhBuoi3_21082026.Models;

namespace DttThucHanhBuoi3_21082026.Controllers;

[Route("san-pham")]
public class ProductController : Controller
{
    private static readonly List<CategoryDto> Categories =
    [
        new(1, "Quần Áo"),
        new(2, "Túi xách"),
        new(3, "Đồng hồ"),
        new(4, "Ti vi"),
        new(5, "Tủ lạnh"),
        new(6, "Máy bơm"),
        new(7, "Quạt điện"),
        new(8, "Lò sưởi")
    ];

    private static readonly List<ProductDto> AllProducts =
    [
        new(1, 1, "Bộ đồ bơi cho trẻ em nam", 50000m, 35000m,
            "Chất liệu co giãn cao cấp, chống tia UV, thoáng khí và an toàn cho da bé.",
            true, new DateTime(2021, 7, 15, 12, 0, 0), "/images/boi-nam.jpg"),
        new(2, 1, "Bộ đồ bơi cho trẻ em nữ", 50000m, 35000m,
            "Thiết kế liền thân xinh xắn, chất liệu mềm nhẹ, nhanh khô.",
            true, new DateTime(2021, 7, 15, 12, 0, 0), "/images/boi-nu.png"),
        new(3, 1, "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", 50000m, 35000m,
            "Phù hợp cho bé từ 12-18kg, họa tiết dễ thương, bền màu.",
            true, new DateTime(2021, 7, 15, 12, 0, 0), "/images/boi-35.jpg"),
        new(4, 1, "Bộ đồ bơi cho trẻ em thời trang", 50000m, 35000m,
            "Phong cách năng động, giữ ấm tốt khi ở dưới nước lâu.",
            true, new DateTime(2021, 7, 15, 12, 0, 0), "/images/boi-tt.jpg"),
        new(5, 2, "Túi thời trang mẫu mới 2021", 50000m, 35000m,
            "Túi xách da cao cấp, thiết kế thanh lịch chuẩn phong cách công sở.",
            true, new DateTime(2021, 7, 15, 12, 0, 0), "/images/tui-1.jpg"),
        new(6, 2, "Túi thời trang da cá sấu", 50000m, 35000m,
            "Vân da cá sấu dập nổi sang trọng, đường may tỉ mỉ, khóa mạ vàng.",
            true, new DateTime(2021, 7, 15, 12, 0, 0), "/images/tui-2.jpg")
    ];

    [HttpGet("")]
    public IActionResult Index([FromQuery] int? categoryId)
    {
        // Lọc sản phẩm theo danh mục nếu có categoryId được chọn
        var filteredProducts = categoryId.HasValue
            ? AllProducts.Where(p => p.CategoryId == categoryId.Value).ToList()
            : AllProducts;

        var viewModel = new ProductCatalogViewModel(Categories, filteredProducts, categoryId);
        return View(viewModel);
    }

    [HttpGet("chi-tiet/{id:int}")]
    public IActionResult Details(int id)
    {
        var product = AllProducts.FirstOrDefault(p => p.Id == id);
        if (product is null)
        {
            return NotFound();
        }

        return View(product);
    }
}