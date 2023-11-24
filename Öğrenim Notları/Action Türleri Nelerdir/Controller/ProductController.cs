using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;

namespace OrnekProje.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            Product product = new Product();
            if (product==null)
            {
                return View();
            }
            else if (product.Id == 0) 
            {
                return Json(new object());
            }
            else
            {
                return Content("asdfasdasfa");
            }
        }
        public JsonResult GetProducts2() 
        {
            JsonResult result= Json(new Product
            {
                Id = 5,
                ProductName = "Terlik",
                Quantity = 15
            });
            return result;
        }
        public EmptyResult GetProducts3() 
        {
            return new EmptyResult();
        }
        public ContentResult GetProducts4() 
        {
            ContentResult result= Content("Content");
            return result;
        }
    }
}
