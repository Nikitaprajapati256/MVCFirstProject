using Microsoft.AspNetCore.Mvc;
using MVCFirstProject.Models;
using System.Diagnostics;

namespace MVCFirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> courseList = new List<string>()
            {
                "c#","SQL","MVC","Angular"
            };
            ViewData["list"]=courseList;
            List<Student> studentList = new List<Student>() {
            
            new Student{Name="Ajay",City="Mumbai",Percentage=88},
            new Student{Name="Vijay",City="pune",Percentage=90},
            new Student{Name="Ajay",City="Mumbai",Percentage=88},
            new Student{Name="Vijay",City="pune",Percentage=90},

            };
            ViewData["studlist"] = studentList;

            List<Employee> emp = new List<Employee>()
            {
                new Employee{Id=101,Name="Ajay",Salary=20000},
                new Employee{Id=102,Name="Vijay",Salary=25000},
                new Employee{Id=103,Name="Sakshi",Salary=29000},
                new Employee{Id=105,Name="Puja",Salary=35000},
            };
            ViewBag.List = emp;

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}