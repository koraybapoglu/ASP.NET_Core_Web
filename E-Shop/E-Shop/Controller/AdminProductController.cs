using BusinessLogicLayer.Concrete;
using DataAccesLayer;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace E_Shop.Controllers
{
    public class AdminProductController : Controller
    {
        ProductRepository productRepository = new ProductRepository();
        E_ShopDbContext db = new E_ShopDbContext();
        public IActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).ToList();

            //return View(productRepository.List());
            return View(products);
        }
        public IActionResult Create()
        {
            List<SelectListItem> categories = (from i in db.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.ID.ToString()
                                               }).ToList();

            ViewBag.ktgr = categories;
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Product data, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Hata Oluştu");
            }

            if (file != null && file.Length > 0)
            {
                // Dosyanın kaydedileceği fiziksel yol
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/", file.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    // Dosyayı yükleyin
                    file.CopyToAsync(stream);
                    data.Image = file.FileName.ToString();
                }
            }
            productRepository.Insert(data);
            // Geri dönüş işlemleri burada yapılır.
            return RedirectToAction("Index"); // Örnek olarak Index sayfasına yönlendirme yapılabilir.
        }
        public IActionResult Delete(int id)
        {
            var delete = productRepository.GetByID(id);
            productRepository.Delete(delete);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int id)
        {
            List<SelectListItem> categories = (from i in db.Categories.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = i.Name,
                                                   Value = i.ID.ToString()
                                               }).ToList();

            ViewBag.ktgr = categories;
            var update = productRepository.GetByID(id);
            if (update != null)
            {
                return View(update);
            }
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Update(Product p, IFormFile file)
        {
            var update = productRepository.GetByID(p.ID);
            if (!ModelState.IsValid)
            {
                if (file == null && update != null)
                {
                    update.Description = p.Description;
                    update.Name = p.Name;
                    update.Popular = p.Popular;
                    update.IsApproved = p.IsApproved;
                    update.Price = p.Price;
                    update.Stock = p.Stock;
                    update.CategoryID = p.CategoryID;
                    productRepository.Update(update);
                    return RedirectToAction("Index");
                }
                else if (file != null && update != null)
                {
                    update.Description = p.Description;
                    update.Name = p.Name;
                    update.Popular = p.Popular;
                    update.IsApproved = p.IsApproved;
                    update.Price = p.Price;
                    update.Stock = p.Stock;
                    update.CategoryID = p.CategoryID;
                    update.Image = file.FileName.ToString();
                    productRepository.Update(update);
                    return RedirectToAction("Index");
                }
            }
            return View(update);

        }
    }
}
