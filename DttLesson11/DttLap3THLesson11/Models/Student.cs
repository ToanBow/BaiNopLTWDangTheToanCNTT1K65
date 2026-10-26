using System.ComponentModel.DataAnnotations;

namespace DttLap3THLesson11.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Họ và tên")] 
        [Required(ErrorMessage = "Vui lòng nhập họ và tên.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải từ {2} đến {1} ký tự.")]
        public string Name { get; set; }
        [Display(Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$",
                ErrorMessage = "Địa chỉ email không hợp lệ hoặc không có đuôi gmail.com.")]
        public string Email { get; set; }
        [StringLength(100,MinimumLength =8)]
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên, bao gồm chữ hoa, chữ thường, số và ký tự đặc biệt.")]
        public string Password { get; set; }
        [Required]
        public Branch? Branch { get; set; }
        [Required]
        public Gender? Gender { get; set; }
        [Required]
        public bool IsRegular { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }
        [Range(typeof(DateTime),"1/1/1963","12/31/2005")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBorth { get; set; }
        [Display(Name = "Điểm số")]
        [Required(ErrorMessage = "Vui lòng nhập điểm số.")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ {1} đến {2}.")]
        public double Score { get; set; }
    }
}
