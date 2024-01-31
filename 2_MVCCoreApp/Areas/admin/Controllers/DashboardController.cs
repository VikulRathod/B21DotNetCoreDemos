using Microsoft.AspNetCore.Mvc;

namespace _2_MVCCoreApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
