using Microsoft.AspNetCore.Mvc;
using MVCCoreCodeFirstEFApp.Models;

namespace MVCCoreCodeFirstEFApp.Controllers
{
    public class CategoryController : Controller
    {
        ProductDbContext _db;

        public CategoryController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
