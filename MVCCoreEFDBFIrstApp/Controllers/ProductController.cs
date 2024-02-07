using Microsoft.AspNetCore.Mvc;
using MVCCoreEFDBFIrstApp.Models;

namespace MVCCoreEFDBFIrstApp.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext _db;

        public ProductController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var products = _db.TblProducts.ToList();
            return View(products);
        }
    }
}
