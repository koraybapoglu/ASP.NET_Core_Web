using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using System.Text.Json;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix="Item1")]Product product,[Bind(Prefix ="Item2")] User user)
        {
            return View();
        }
    }
}
