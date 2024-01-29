using _2_MVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2_MVCCoreApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            List<CategoryViewModel> categories =
                new List<CategoryViewModel>() 
                {
                new CategoryViewModel(){CategoryId = 1, CategoryName = "Shirt", BrandName = "WanHussain"},
                new CategoryViewModel(){CategoryId = 2, CategoryName = "Shoe", BrandName = "Adidas"},
                new CategoryViewModel(){CategoryId = 3, CategoryName = "TShirt", BrandName = "Polo"}
                };

            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // public IActionResult Create(string CategoryName, string BrandName)
        // public IActionResult Create(CategoryViewModel category)
        public IActionResult Create(IFormCollection form, string Price)
        {
            string catName = form["CategoryName"];
            string brandName = form["BrandName"];
            string price = Price;

            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult Details(int id, string brandName)
        {
            ViewData["categoryname"] = "Category Name Passed Using ViewData";
            ViewBag.brandname = "Brand Name Passed Using ViewBag";

            CategoryViewModel category =
                new CategoryViewModel() { CategoryId = 1, CategoryName = "Shirt", BrandName = "WanHussain" };
            return View(category);
            // return RedirectToAction("Index", "Category");
        }
    }
}
