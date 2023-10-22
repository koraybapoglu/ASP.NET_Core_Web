using Epic217.BusinessLogicLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Epic217.MVC.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService service;
        public GameController(IGameService gameService)
        {
            service = gameService;
        }
        public IActionResult Detail(int id)
        {
            var result = service.GetGamesWithMediasById(id);
            return View(result);
        }
    }
}
