using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using System.Text.Json;

namespace OrnekProje.Controllers
{
    public class Myclass
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        //public IActionResult CreateProduct(string a,string b)
        public IActionResult CreateProduct()
        {
            /* https://localhost:7100/product/createproduct?a=5&b=Mehmet */
            // a=5 b=Mehmet değerini almış oldu
            var querystring = Request.Query; //Request yapılan endpoint'e query string parametresi eklenmiş mi eklenmemiş mi bununla ilgili bilgi verir.
            var aparameter = Request.Query["a"].ToString(); //A'dan gelen veriyi tutar
            var bparameter= Request.Query["b"].ToString(); //B'den gelen veriyi tutar
            return View();
        }
    }
}
