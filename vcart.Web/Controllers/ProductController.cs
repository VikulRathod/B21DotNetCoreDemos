using Microsoft.AspNetCore.Mvc;
using vcart.services.Interfaces;

namespace vcart.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductService _prodService;

        public ProductController(IProductService prodService)
        {
            _prodService = prodService;
        }

        public IActionResult Index()
        {
            var products = _prodService.GetAll();
            return View(products);
        }
    }
}
