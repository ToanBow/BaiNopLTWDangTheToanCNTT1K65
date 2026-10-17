using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DttLapBaiSinhVienTuLamBai2.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên bài viết không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "tinyint")]
        public byte Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName ="varchar(100)")]
        [StringLength(100)]
        public string? Image { get; set; }
        [Column(TypeName = "varchar(350)")]
        [StringLength(350)]
        public string? Description { get; set; }
    }
}
