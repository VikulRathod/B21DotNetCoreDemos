using Microsoft.AspNetCore.Mvc;

namespace _2_MVCCoreApp.Controllers
{
    public class ProductController : Controller
    {
        // product/index
        public IActionResult Index()
        {
            return View();
        }

        // product/details/10
        public IActionResult Details(int id)
        {
            return View();
        }

        [HttpGet]
        [Route("product-details/{id:int}/{catId:int}")]
        // product/productbycategory/1/10
        public IActionResult ProductByCategory(int id, int catId)
        {
            return View();
        }

        [HttpGet("popular-product/{catId:int}/{rating:int}")]
        // [Route("popular-product/{catId:int}/{rating:int}")]
        [Route("product/productbyrating/{catId:int}/{rating:int}")]
        // product/productbyrating/1/5
        public IActionResult ProductByRating(int catId, int rating)
        {
            return View();
        }
    }
}
