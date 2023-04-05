using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MVCFirstProject.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> option = new List<string>() { "Select Option ", "Yes", "No" };
            ViewData["option"] = new SelectList(option);//used for single selection
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form) 
        {
            ViewBag.Name = form["name"];
            ViewBag.Email = form["email"];
            ViewBag.Contact = form["contact"];
            ViewBag.Gender = form["gender"];
            ViewBag.Options = form["option"];
            return View("Display");

           
        }
    }
}
