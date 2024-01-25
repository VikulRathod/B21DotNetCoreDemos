using Microsoft.AspNetCore.Mvc;

namespace _2_MVCCoreApp.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            // fetch data from database
            // fetch data from api
            List<string> categories = new List<string>() 
            { "Mens Wear", "Women Wear", "Home Appliances", "Eloctronic Devices" };

            return View("~/Views/Components/_Categories.cshtml", 
                categories.Where(c => c.Contains(name)));
        }
    }
}
