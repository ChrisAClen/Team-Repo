using Microsoft.AspNetCore.Mvc;

namespace eMNY.Client.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }

        public IActionResult Register()
        {
          return View("Register");
        }
    }
}
