using _2_MVCCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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

            // creating cookie
            Response.Cookies.Append("catName", "Electronic Devices Category");
            Response.Cookies.Append("brandName", "Sony Brand",
                new CookieOptions() { Expires = DateTime.Now.AddDays(1) });

            // setting tempdata
            TempData["customername"] = "Vishal";

            CategoryViewModel category =
                new CategoryViewModel()
                {
                    CategoryId = 1,
                    CategoryName = "Shirt",
                    BrandName = "WanHussain"
                };

            // TempData["category"] = category;
            // TempData["category"] = JsonSerializer.Serialize(category);

            TempData["category"] = 
                Newtonsoft.Json.JsonConvert.SerializeObject(category);

            // setting data in session

            HttpContext.Session.SetString("SiteName", "Flipkart.Com");

            var jsonCategories = JsonSerializer.Serialize(categories);
            HttpContext.Session.SetString("categories", jsonCategories);


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
        public IActionResult Details(int id) //, string brandName
        {
            string brandName = Request.Query["brandName"];

            ViewData["categoryname"] = "Category Name Passed Using ViewData";
            ViewBag.brandname = "Brand Name Passed Using ViewBag";

            // reading cookie
            ViewBag.catName = Request.Cookies["catName"];
            ViewBag.brandName = Request.Cookies["brandName"];

            // reading tempdata
            // ViewBag.customername = TempData["customername"];
            ViewBag.customername = TempData.Peek("customername");

            // ViewBag.Category = TempData.Peek("category");
            ViewBag.Category = 
                JsonSerializer.Deserialize<CategoryViewModel>((string)TempData.Peek("category"));

            // reading session
            ViewBag.SiteName = HttpContext.Session.GetString("SiteName");

            
            List<CategoryViewModel> categories =
                JsonSerializer.Deserialize<List<CategoryViewModel>>
                (HttpContext.Session.GetString("categories"));

            ViewBag.categories = categories;

            CategoryViewModel category =
                new CategoryViewModel() { CategoryId = 1, CategoryName = "Shirt", BrandName = "WanHussain" };
            return View(category);
            // return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // reading tempdata
            ViewBag.customername = TempData["customername"];
            // ViewBag.Category = TempData.Peek("category");
            ViewBag.Category =
    JsonSerializer.Deserialize<CategoryViewModel>((string)TempData.Peek("category"));

            return View();
        }
    }
}
