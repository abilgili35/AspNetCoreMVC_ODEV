using AspNetCoreMVC_ODEV.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_ODEV.Controllers
{
    public class CategoryController : Controller
    {
        public static List<Category> categories = new List<Category>();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            categories.Add(category);
            return Redirect("/Home/Index");
        }
    }
}
