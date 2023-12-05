using Microsoft.AspNetCore.Mvc;

namespace OrnekProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var images = new List<string> { "https://w7.pngwing.com/pngs/969/229/png-transparent-banana-scalable-graphics-s-of-banana-food-fruit-banana.png", "https://png.pngtree.com/png-clipart/20230508/original/pngtree-the-banana-png-image_9149388.png" };

            ViewBag.Data=images;
            return View(images);
        }
        public IActionResult Sayfa1()
        {
            return View();
        }
        public IActionResult Sayfa2()
        {
            return View();
        }
        public IActionResult Index5()
        {
            return View();
        }
    }
}
