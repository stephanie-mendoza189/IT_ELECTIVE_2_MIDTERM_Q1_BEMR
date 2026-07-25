using Microsoft.AspNetCore.Mvc;

namespace GenshinCharacterBuild.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
           
            if (email == "user@gmail.com" && password == "12345")
            {
                
                return RedirectToAction("Index", "Home");
            }

            
            ViewBag.ErrorMessage = "Incorrect email or password.";
            ViewBag.EnteredEmail = email;

            
            return View();
        }
    }
}