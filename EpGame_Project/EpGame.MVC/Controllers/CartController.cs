using Epic217.BusinessLogicLayer.Abstract;
using Epic217.Entity.DTO;
using Epic217.Entity.POCO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Epic217.MVC.Controllers
{
    public class CartController : Controller
    {

        ICartService cartService;
        SignInManager<AppUser> signIn;
        public CartController(ICartService cartService, SignInManager<AppUser> signInManager)
        {
            signIn = signInManager;
            this.cartService = cartService;
        }
        public IActionResult Index()
        {
            int totalPrice = 0;
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = signIn.UserManager.FindByNameAsync(User.Identity.Name).Result;
                List<CartDTO> carts = cartService.GetCartsByUserId(user.Id);
                carts.ForEach(x => totalPrice += Convert.ToInt32(x.Price));
                TempData["TotalPrice"] = totalPrice;
                return View(carts);
            }
            else
                return RedirectToAction("SignIn", "Account");
        }
        public IActionResult AddCart(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = signIn.UserManager.FindByNameAsync(User.Identity.Name).Result;
                
                cartService.CartAdd(id, user.Id);

                #region API POST İşlemi
                //string apiUrl = "https://localhost:7170/api/CartApi/addcartwithcartdto";
                //HttpClient http = new HttpClient();
                //CartDTO cart = new CartDTO { AppUserId = user.Id ,GameId = id,Price=10};
                //string data = JsonConvert.SerializeObject(cart);
                //StringContent content = new StringContent(data,Encoding.UTF8, "application/json");
                //var result = http.PostAsync(apiUrl, content).Result; 
                #endregion


                int totalPrice = 0;
                List<CartDTO> carts = cartService.GetCartsByUserId(user.Id);
                carts.ForEach(x => totalPrice += Convert.ToInt32(x.Price));
                TempData["TotalPrice"] = totalPrice;

                return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("SignIn", "Account");

        }
        public IActionResult DeleteCart(int id)
        {
            AppUser user = signIn.UserManager.FindByNameAsync(User.Identity.Name).Result;
            bool result = cartService.DeleteCartByUserId(id, user.Id);
            return RedirectToAction("Index");
        }
    }
}
