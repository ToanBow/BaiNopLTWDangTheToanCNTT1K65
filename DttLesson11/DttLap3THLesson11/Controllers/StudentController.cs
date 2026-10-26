using System.Reflection;
using DttLap3THLesson11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DttLap3THLesson11.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> listStudents = new List<Student>
        {
            new Student() {Id=101,Name="Hải Nam",Branch=Branch.IT,Gender=Gender.Male,
                IsRegular=true,Address="A1-2018",Email="nam@g.com",Score=6.7},
            new Student() {Id=102,Name="Minh Tú",Branch=Branch.BE,Gender=Gender.Female,
                IsRegular=true,Address="A1-2019",Email="tu@g.com",Score=10},
            new Student() {Id=103,Name="Hoàng Phong",Branch=Branch.CE,Gender=Gender.Male,
                IsRegular=false,Address="A1-2020",Email="phong@g.com",Score=9.87},
            new Student() {Id=104,Name="Xuân Mai",Branch=Branch.EE,Gender=Gender.Female, 
                IsRegular=false,Address="A1-2021",Email="mai@g.com",Score=7.77},
        };

        [Route("Admin/Student/List", Name = "StudentList")]
        public IActionResult Index()
        {
            return View(listStudents);
        }

        [HttpGet]
        [Route("Admin/Student/Add", Name = "StudentAdd")]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [Route("Admin/Student/Add")]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = listStudents.Last().Id + 1;
                listStudents.Add(s);
                return View("Index", listStudents);
            }


            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem{Text = "IT",Value="1"},
                new SelectListItem{Text = "BE",Value="2"},
                new SelectListItem{Text = "CE",Value="3"},
                new SelectListItem{Text = "EE",Value="4"},
            };
            return View();
        }
    }
}