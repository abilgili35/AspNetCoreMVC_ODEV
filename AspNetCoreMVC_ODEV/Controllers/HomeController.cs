using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_ODEV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Products"] = ProductController.products.ToList();
            ViewData["Categories"] = CategoryController.categories.ToList();
            ViewData["Suppliers"] = SupplierController.suppliers.ToList();

            return View();
        }
    }
}
