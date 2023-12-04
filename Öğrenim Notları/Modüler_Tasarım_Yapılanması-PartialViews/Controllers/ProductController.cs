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
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //ModelState:MVC'de bir type'ın data annotationslarının durumunu kontrol eden ve geriye sonuç dönen bir property.
            if (!ModelState.IsValid)
            {
                //Loglama
                //Kullanıcı bilgilendirme

                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x=>x.ValidationState==Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
                var messages = ModelState.ToList();
                return View(model);
            }
            //İşleme Tabi tutulur.

            return View();
        }
    }
}
