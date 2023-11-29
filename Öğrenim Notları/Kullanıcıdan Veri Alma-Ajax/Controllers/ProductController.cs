using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using System.Text.Json;

namespace OrnekProje.Controllers
{
    public class AjaxData 
    {
        public string A { get; set; }
        public string B { get; set; }
    }
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(AjaxData ajaxData) 
        {
            return View();
        }
    }
}
