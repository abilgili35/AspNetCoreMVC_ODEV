using AspNetCoreMVC_ODEV.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC_ODEV.Controllers
{
    public class SupplierController : Controller
    {
        public static List<Supplier> suppliers = new List<Supplier>();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Supplier supplier)
        {
            suppliers.Add(supplier);
            return Redirect("/Home/Index");
        }
    }
}
