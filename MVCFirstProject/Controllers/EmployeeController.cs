using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCFirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {
            List<string> options = new List<string>()
            {
                "Select option ","HR","Admin","Sales","Development","Finance"
            };
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]

        public IActionResult EmployeeDetails(IFormCollection form)
        {
            ViewBag.Id = form["id"];
            ViewBag.Name = form["name"];
            ViewBag.Salary = form["salary"];
            ViewBag.Department = form["options"];
            return View("Print");
        }
    }
}
