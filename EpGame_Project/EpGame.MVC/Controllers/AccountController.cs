using Epic217.Entity.POCO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Epic217.MVC.Controllers
{
	public class AccountController : Controller
	{
        SignInManager<AppUser> signIn;
        UserManager<AppUser> userManager;
        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            signIn = signInManager;
        }
        [HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string userName,string password)
        {
            var result = signIn.PasswordSignInAsync(userName, password, false, false).Result;
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(string userName, string email, string password)
        {

            
          var result =  userManager.CreateAsync(new AppUser { UserName = userName, Email = email, NormalizedEmail = email.ToUpper(), NormalizedUserName = userName.ToUpper()},password).Result;
            if (result.Succeeded)
            {
                return View("SignIn");
            }
            return View();
        }

        public IActionResult Profile()
        {
            AppUser user = signIn.UserManager.FindByNameAsync(User.Identity.Name).Result;
            IList<string> result = signIn.UserManager.GetRolesAsync(user).Result;
			return View(result);
		}

        public IActionResult LogOut()
        {
            signIn.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
