using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DttBtLapSvTuLamThem.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Tên sản phẩm phải từ 6 đến 150 ký tự")]
        public string Name { get; set; }

        public string? Image {  get; set; }
        [NotMapped]

        [Required(ErrorMessage = "Vui lòng chọn ảnh sản phẩm")]
        public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage ="Giá sản phẩm không được để trống")]
        [Range(100000, double.MaxValue, ErrorMessage ="Giá sản phẩm phải nhỏ nhất là 100000")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Giá khuyến mãi không được để trống")]
        [Range(0,double.MaxValue, ErrorMessage ="Giá khuyến mãi không được âm")]
        public float SalePrice { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        [MaxLength(1500, ErrorMessage ="Mô tả không vượt quá 1500 ký tự")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn danh mục sản phẩm")]
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
