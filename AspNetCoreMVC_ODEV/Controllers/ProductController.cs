using AspNetCoreMVC_ODEV.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_ODEV.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            products.Add(product);
            return Redirect("/Home/Index");
        }


    }
}
