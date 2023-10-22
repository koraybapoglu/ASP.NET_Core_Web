using Epic217.BusinessLogicLayer.Abstract;
using Epic217.Entity.DTO;
using Epic217.Entity.POCO;
using Epic217.MVC.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace Epic217.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameService service;
        private readonly ICartService cartService;
        private readonly SignInManager<AppUser> signIn;
        public HomeController(ILogger<HomeController> logger,IGameService gameService, ICartService cartService,SignInManager<AppUser> signInManager)
        {
            signIn = signInManager;
            _logger = logger;
            service = gameService;
            this.cartService = cartService;
        }

        public IActionResult Index()
        {
            double totalPrice = 0;
            List<GameDTO> result = service.GetGamesWithMedias();

            #region API GET İşlemi
            //string apiUrl = "https://localhost:7170/api/GameApi/getgameswithmedias";
            //WebClient web = new WebClient();
            //string resultString = web.DownloadString(apiUrl);
            //List<GameDTO> result = JsonConvert.DeserializeObject<List<GameDTO>>(resultString); 
            #endregion

            if (User.Identity.IsAuthenticated)
            {
                AppUser user = signIn.UserManager.FindByNameAsync(User.Identity.Name).Result;
                List<CartDTO> carts = cartService.GetCartsByUserId(user.Id);
                carts.ForEach(x => totalPrice += x.Price); 
            }

            TempData["TotalPrice"] = totalPrice;
            return View(result);
        }
    }
}