using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MVCFirstProject.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult StudentDetails()
        {
            List<string> options= new List<string>()
            {
                "Select Stream","Computer ","Civil","Electrical","Mechanaical","E&TC"
            };
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult StudentDetails(IFormCollection form)
        {
            ViewBag.RollNo = form["rollno"];
            ViewBag.Name = form["name"];
            ViewBag.Percentage = form["percentage"];
            ViewBag.Stream = form["options"];
            return View("Display");
        }
    }
}
