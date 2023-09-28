using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EpGame.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class GameCategoryApiController : Controller
    {
        IGameCategoryService gamecategoryservice;
        public GameCategoryApiController(IGameCategoryService GameCategoryService)
        {
            gamecategoryservice = GameCategoryService;
        }
        [HttpGet("getallgamecategories")]
        public IActionResult GetAllGameCategory() 
        {
            var gamecategory = gamecategoryservice.GetAll();
            return Ok(gamecategory);
        }
        [HttpGet("getgamecategory")]
        public IActionResult GetGameCategory(int id) 
        {
            var gamecategory=gamecategoryservice.Get(id);
            return Ok(gamecategory);
        }
        [HttpPost("updategamecategory")]
        public IActionResult UpdateGameCategory(GameCategory gamecategory) 
        {
            var result=gamecategoryservice.Update(gamecategory);
            return Ok(result);
        }
        [HttpPost("deletegamecategory")]
        public IActionResult DeleteGameCategory(GameCategory gameCategory) 
        {
            var result = gamecategoryservice.Delete(gameCategory);
            return Ok(gameCategory);
        }
    }
}
