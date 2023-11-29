using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using System.Text.Json;

namespace OrnekProje.Controllers
{
    public class Model
    {
        public string TxtValue1 { get; set; }
        public string TxtValue2 { get; set; }
        public string TxtValue3 { get; set; }
    }
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
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]

        //public IActionResult CreateProduct(IFormCollection datas)
        //public IActionResult CreateProduct(string txtValue1, string txtValue2, string txtValue3)
        //public IActionResult CreateProduct(Product product)
        public IActionResult CreateProduct(Myclass myclass)
        {
            //var value1 = datas["txtValue1"].ToString;
            //var value2 = datas["txtValue2"].ToString;
            //var value3 = datas["txtValue3"].ToString;
            return View();
        }
    }
}
