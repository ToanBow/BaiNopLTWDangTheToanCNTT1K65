using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1, Name="Hoàng Anh",
                    Email = "anh@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/02.jfif"),
                    Gender=1,
                    Bio="My name is small",
                    Birtday = new DateTime(1998,7,12)
                },
                new Account()
                {
                    Id = 1, Name="Trường Giang",
                    Email = "giang@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/03.jfif"),
                    Gender=1,
                    Bio="My name is small",
                    Birtday = new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 1, Name="Hoàng Thúy",
                    Email = "thuy@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/04.jfif"),
                    Gender=1,
                    Bio="My name is small",
                    Birtday = new DateTime(1998,7,16)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }
    }
}
