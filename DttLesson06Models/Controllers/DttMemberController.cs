using DttLesson06Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace DttLesson06Models.Controllers
{
    public class DttMemberController : Controller
    {
        //muck data
        private static readonly List<DttMember> _dttMembers = new List<DttMember>()
{
    new DttMember
    {
        DttMemberId = Guid.NewGuid().ToString(),
        DttMemberUserName = "ToanBow",
        DttMemberFullName = "Đặng Thế Toàn",
        DttPassword = "123456",
        DttMemberEmail = "thetoan.official@gmail.com"
    },
    new DttMember
    {
        DttMemberId = Guid.NewGuid().ToString(),
        DttMemberUserName = "ducnam",
        DttMemberFullName = "Nguyễn Đức Nam",
        DttPassword = "abcdef",
        DttMemberEmail = "namnd@gmail.com"
    },
    new DttMember
    {
        DttMemberId = Guid.NewGuid().ToString(),
        DttMemberUserName = "thihong",
        DttMemberFullName = "Lê Thị Hồng",
        DttPassword = "password123",
        DttMemberEmail = "honglt@gmail.com"
    },
    new DttMember
    { 
        DttMemberId = Guid.NewGuid().ToString(),
        DttMemberUserName = "hoangminh",
        DttMemberFullName = "Trần Hoàng Minh",
        DttPassword = "minh1234",
        DttMemberEmail = "minhth@gmail.com"
    }
};
        //get:list
        public IActionResult DttIndex()
        {
            return View(_dttMembers);
        }
        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public IActionResult DttCreate()
        {
            return View();
        }
        /// <summary>
        /// Create - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DttCreate(DttMember dttMember)
        {
            dttMember.DttMemberId= Guid.NewGuid().ToString();
            _dttMembers.Add(dttMember);
            return RedirectToAction("DttIndex");
        }
        /// <summary>
        /// DttEdit
        /// </summary>
        /// <returns></returns>
        /// 
        public IActionResult DttEdit(string id)
        {
            var dttMember = _dttMembers.FirstOrDefault(x=>x.DttMemberId.Equals(id));
            return View(dttMember);
        }
        /// <summary>
        /// DttEdit - submit form
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult DttEdit(string id,DttMember dttMember)
        {
            for(int i = 0; i < _dttMembers.Count; i++)
            {
                if (_dttMembers[i].DttMemberId == id)
                {
                    _dttMembers[i].DttMemberId = dttMember.DttMemberId;
                    _dttMembers[i].DttMemberUserName = dttMember.DttMemberUserName;
                    _dttMembers[i].DttPassword = dttMember.DttPassword;
                    _dttMembers[i].DttMemberFullName = dttMember.DttMemberFullName;
                    _dttMembers[i].DttMemberEmail = dttMember.DttMemberEmail;
                    break;
                }
                
            }
            return View();
        }
        public IActionResult DttGetDetails()
        {
            var DttMember = new DttMember()
            {
                DttMemberId = Guid.NewGuid().ToString(),
                DttMemberFullName = "Đặng Thế Toàn",
                DttMemberUserName ="TheToan",
                DttMemberEmail="thetoan.official@gmail.com",
                DttPassword="123456678"
            };
            return View(DttMember);
        }
    }
}
