using Microsoft.AspNetCore.Mvc;
using vcart.services.Interfaces;

namespace vcart.Web.Controllers
{
    public class CategoriesController : Controller
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(_categoryService.GetAll());
        }
    }
}
