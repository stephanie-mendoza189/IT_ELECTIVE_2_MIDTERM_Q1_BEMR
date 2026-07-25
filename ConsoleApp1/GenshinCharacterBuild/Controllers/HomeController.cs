using Microsoft.AspNetCore.Mvc;

namespace GenshinCharacterBuild.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            
            if (email == "user@gmail.com" && password == "12345")
            {
                
                return RedirectToAction("Privacy");
            }

            
            ViewBag.ErrorMessage = "Incorrect email or password.";
            ViewBag.EnteredEmail = email;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}