using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EpGame.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MediaApiController : Controller
	{
		IMediaService mediaService;
        public MediaApiController(IMediaService MediaService)
        {
				mediaService = MediaService;
        }
		[HttpGet("GetAllMedias")]
		public IActionResult GetAll() 
		{
			var Medias = mediaService.GetAll();
			return Ok(Medias);
		}
		[HttpGet("GetMedia")]
		public IActionResult Get(int id) 
		{
			var Media=mediaService.Get(id);
			return Ok(Media);
		}
		[HttpPost("UpdateMedia")]
		public IActionResult UpdateMedia(Media media) 
		{
			var result=mediaService.Update(media);
			return Ok(result);
		}
		[HttpPost("DeleteMedia")]
		public IActionResult DeleteMedia(Media media) 
		{
			var result= mediaService.Delete(media);
			return Ok(result);
		}
    }
}
