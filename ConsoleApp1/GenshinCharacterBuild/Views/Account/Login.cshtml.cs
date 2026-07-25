using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenshinCharacterBuild.Views.Account
{
    public class LoginModel : PageModel
    {
        
        [BindProperty]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        public string Password { get; set; } = string.Empty;

    
        public string ErrorMessage { get; set; } = string.Empty;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
           
            if (Email == "user@gmail.com" && Password == "12345")
            {
                
                return RedirectToPage("/Index");
            }

           
            ErrorMessage = "Incorrect email or password.";

            return Page(); 
        }
    }
}