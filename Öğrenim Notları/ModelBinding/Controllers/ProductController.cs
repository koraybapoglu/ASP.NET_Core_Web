using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;
using OrnekProje.Models.ViewModel;
using System.Text.Json;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                //new Product{Id=1,ProductName="A Product",Quantity=10 },
                //new Product{Id=2,ProductName="B Product",Quantity=20 },
                //new Product{Id=3,ProductName="C Product",Quantity=30 }
            };

            #region Model Bazlı Veri Gönderimi
            //return View(products);
            #endregion

            #region Veri Taşıma Kontrolleri
            #region ViewBag
            ViewBag.Products = products;
            #endregion

            #region ViewData
            ViewData["products"] = products;
            #endregion

            #region TempData
            string data =JsonSerializer.Serialize(products);
            TempData["products"] = data;

            //TempData["x"] = 5;
            //ViewBag.x = 5;
            //ViewData["x"] = 5;
            #endregion
            #endregion
            return RedirectToAction("Index2");
        }
        public IActionResult Index2() 
        {
            //var v1=ViewBag.x;
            //var v2 = ViewData["x"];
            //var v3 = TempData["x"];
            var data = TempData["products"].ToString();
            List<Product> products=JsonSerializer.Deserialize<List<Product>>(data);
            return View(products);
        }
        public IActionResult GetProducts() 
        {
            var product = new Product();
            return View(product);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product) 
        {
            return View();
        }
    }
}
