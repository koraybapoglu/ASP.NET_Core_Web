using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sayfa1() 
        {
            return View();
        }
        public IActionResult Sayfa2() 
        {
            return View();
        }
    }
}
