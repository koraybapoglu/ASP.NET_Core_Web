using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EpGame.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	public class GameApiController : Controller
	{
		IGameService gameservice;
        public GameApiController(IGameService GameService)
        {
                gameservice = GameService;
        }
        [HttpGet("getallgames")]
        public IActionResult GetAll() 
        {
            var games= gameservice.GetAll();
            return Ok(games);
        }
        [HttpGet("getgame")]
        public IActionResult Get(int id) 
        {
            var game= gameservice.Get(id);
            return Ok(game);
        }
        [HttpPost("addgame")]
        public IActionResult AddGame(Game game) 
        {
            var result = gameservice.Add(game);
            return Ok(result);
        }
        [HttpPost("updategame")]
        public IActionResult UpdateGame(Game game) 
        {
            var result = gameservice.Update(game);
            return Ok(result);
        }
        [HttpPost("deletegame")]
        public IActionResult DeleteGame(Game games) 
        {
            var result = gameservice.Delete(games);
            return Ok(result);
        }
    }
}
