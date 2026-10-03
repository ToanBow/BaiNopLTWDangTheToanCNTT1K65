using System.ComponentModel.DataAnnotations;

namespace DttBtLapSvTuLamThem.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(150, MinimumLength =3,ErrorMessage ="Tên danh mục từ 3 đến 150 ký tự")]

        public string Name { get; set; }
    }
}
