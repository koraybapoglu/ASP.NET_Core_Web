using BusinessLogicLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_Shop.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryRepository categoryRepository=new CategoryRepository();
        public IActionResult Index()
        {
            return View(categoryRepository.List());
        }
        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Create(Category p) 
        {
           var result=new Category { Description = p.Description ,Name=p.Name };
            if (result!=null)
            {
                categoryRepository.Insert(result);
                return RedirectToAction("Index");
            }
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Delete(int id) 
        {
            var delete = categoryRepository.GetByID(id);
            if (delete!=null)
            {
                categoryRepository.Delete(delete);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(int id) 
        {
            var update= categoryRepository.GetByID(id);
            if (update!=null) 
            {
                return View(update);
            }
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Update(Category p) 
        {
            var update = categoryRepository.GetByID(p.ID);
            if (update!=null)
            {
                update.Description = p.Description;
                update.Name = p.Name;
                categoryRepository.Update(update);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
