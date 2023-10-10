using Admin.BusinessLogicLayer.Abstract;
using Admin.EntityLayer.POCO;
using Microsoft.AspNetCore.Mvc;

namespace Admin.MVC.Controllers
{
    public class AdminDashboard : Controller
    {
        private readonly IAdminService service;
        public AdminDashboard(IAdminService _Services)
        {
            service = _Services;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(string UserName, string PassWord, string Email)
        {
            var result = new Admins { UserName = UserName, Password = PassWord, Email = Email };
            service.Add(result);
            if (result != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UpdateAdmin()
        {
            return View(service.GetAll());
        }
        [HttpPost]
        public IActionResult UpdateAdmin(int id, string UserName, string PassWord, string Email)
        {
            Admins admin = new Admins();
            admin = service.Get(id);
            if (admin != null)
            {
                admin.UserName = UserName;
                admin.Password = PassWord;
                admin.Email = Email;
                bool result = service.Update(admin);
                if (result)
                {
                    return RedirectToAction("Index");
                }

            }
            return View();
        }
        public IActionResult DeleteAdmin()
        {
            var result = service.GetAll();
            if (result != null)
            {
                return View(result);
            }
            return View("Index");
        }
        [HttpPost]
        public IActionResult DeleteAdmin(int AdminId)
        {
            Admins admin = new();
            admin = service.Get(AdminId);
            if (admin != null)
            {
                service.Delete(admin);
                return View("Index");
            }
            return View();
        }
        public IActionResult GetAdmins()
        {
            return View(service.GetAll());
        }
        public IActionResult GetAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetAdmin(string email)
        {
            int adminid = service.GetIdByEmail(email);
            var admin = service.Get(adminid);
            if (admin != null)
            {
                return View(admin);
            }
            return View();
        }
    }
}
