using _2_MVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2_MVCCoreApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        // [NonAction]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email.Equals("admin") && password.Equals("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        [Route("account/welcome/{firstName}/{lastName}")]
        public ViewResult Welcome(string firstName, string lastName)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginViewModel model)
        {
            if (model.Email.Equals("admin@gmail.com") &&
                model.Password.Equals("admin"))
            {
                return RedirectToAction("Index", "Dashboard", new { area = "admin" });
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
