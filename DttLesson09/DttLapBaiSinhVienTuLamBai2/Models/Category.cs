using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DttLapBaiSinhVienTuLamBai2.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "tinyint")]
        public byte Status { get; set; } = 1;
        [Column(TypeName ="date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string? Image {  get; set; }
        [Column(TypeName = "varchar(250)")]
        [StringLength(350)]
        public string? Description { get; set; }
    }
}