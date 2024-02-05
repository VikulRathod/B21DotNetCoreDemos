using DbModels;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreEFDBFIrstApp.Controllers
{
    public class CategoryController : Controller
    {
        B21EFCoreCodeFirstDBContext _db;

        public CategoryController(B21EFCoreCodeFirstDBContext db)
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
