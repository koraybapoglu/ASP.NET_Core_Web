using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;

namespace OrnekProje.Controllers
{
    [NonController]
    public class ProductController : Controller
    {   
        public IActionResult Index()
        {
            X();
            return View();
        }
        [NonAction] 
        public void X() 
        {

        }
    }
}
