using DttBaiTapLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttBaiTapLab.Controllers
{
    public class DanhMucController : Controller
    {
        protected DanhMuc danhmucs = new DanhMuc();
        public PartialViewResult DanhMuc()
        {
            var danhmuc = danhmucs.GetDanhMucs();
            return PartialView(danhmuc);
        }
    }
}
