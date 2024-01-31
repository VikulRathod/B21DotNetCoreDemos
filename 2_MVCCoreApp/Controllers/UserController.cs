using _2_MVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace _2_MVCCoreApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserViewModel> users = new List<UserViewModel>();

            if(TempData.Peek("user") != null)
            {
                var json = (string) TempData.Peek("user");
                users.Add(JsonSerializer.Deserialize<UserViewModel>(json));
            }

            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                TempData["user"] = JsonSerializer.Serialize(user);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
