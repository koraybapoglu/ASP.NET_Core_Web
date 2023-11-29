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
            return View();
        }
        public IActionResult VeriAl(string id,string a,string b) 
        {
            // https://localhost:7100/product/verial/5
            // id değerine 5 değeri gelmiş oluyor Route Parameter ile
            var values =Request.RouteValues;
            return View();
        }
    }
}
