using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DangTheToan_241230865.Models;

public partial class HangHoa
{
    public int MaHang { get; set; }
    [Display(Name ="Mã loại")]

    public int MaLoai { get; set; }
    [Required(ErrorMessage ="Tên hàng không được để trống")]
    [Display(Name = "Tên hàng")]
    public string TenHang { get; set; } = null!;
    [Required(ErrorMessage = "Giá không được để trống")]
    [Range(100,5000,ErrorMessage ="Giá phải là số và nằm trong giới hạn từ 100 đến 5000")]
    [Display(Name = "Giá")]

    public decimal? Gia { get; set; }
    [Required(ErrorMessage = "Tên file ảnh không được để trống")]
    [RegularExpression(@"^.+\.(jpg|JPG|png|PNG)$",ErrorMessage = "Tên file ảnh phải có đuôi jpg|JPG|png|PNG")]
    [Display(Name = "Ảnh")]

    public string? Anh { get; set; }

    public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
}
