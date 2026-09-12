using System.Security.Cryptography.X509Certificates;

namespace DttBaiTapLab.Models
{
    public class DanhMuc
    {
        public string Title { get; set; }
        public List<DanhMuc> GetDanhMucs()
        {
            List<DanhMuc> danhMucs = new List<DanhMuc>()
            {
                new DanhMuc() {
                    Title="Áo dài"
                },
                new DanhMuc() {
                    Title="Áo đông"
                },
                new DanhMuc() {
                    Title="Túi xách"
                },
                new DanhMuc() {
                    Title="Đồng hồ"
                },
                new DanhMuc() {
                    Title="Ví da"
                },
                new DanhMuc() {
                    Title="Thắt lưng da"
                },
                new DanhMuc() {
                    Title="Tủ lạnh"
                },
                new DanhMuc() {
                    Title="Ti vi"
                },
                new DanhMuc() {
                    Title="Quạt điện"
                },
                new DanhMuc() {
                    Title="Lò sưởi"
                }
            };
            return danhMucs;
        }
    }
}
