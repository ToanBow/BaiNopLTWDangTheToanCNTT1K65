using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DangTheToan_241230865.Models;

public partial class Sach
{

    public int MaSach { get; set; }
    [Display(Name ="MaTL")]
    public int MaTl { get; set; }
    [Required(ErrorMessage ="Tên sách không được để trống")]
    [Display(Name ="TenSach")]
    public string TenSach { get; set; } = null!;
    [Required(ErrorMessage = "Giá sách không được để trống")]
    [Range(50,1000,ErrorMessage ="Giá sách phải nằm trong khoảng 50 ->1000")]
    [Display(Name = "Gia")]
    public decimal? Gia { get; set; }
    [Required(ErrorMessage = "Tên file ảnh không được để trống")]
    [RegularExpression(@"^.+\.(jpg|JPG|png|PNG|webp|WEBP)$",
        ErrorMessage = "Tên file ảnh phải có đuôi jpg|JPG|png|PNG|webp|WEBP")]
    [Display(Name = "Anh")]
    public string? Anh { get; set; }

    public virtual TheLoai MaTlNavigation { get; set; } = null!;
}
