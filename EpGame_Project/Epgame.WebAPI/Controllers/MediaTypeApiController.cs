using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EpGame.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MediaTypeApiController : Controller
	{
		IMediaTypeService mediaTypeService;
		public MediaTypeApiController(IMediaTypeService MediaTypeService)
		{
			mediaTypeService = MediaTypeService;
		}
		[HttpGet("GetAllMediaTypes")]
		public IActionResult GetAllMediaTypes()
		{
			var mediatypes = mediaTypeService.GetAll();
			return Ok(mediatypes);
		}
		[HttpGet("GetMediaType")]
		public IActionResult GetMediaType(int id)
		{
			var mediaType = mediaTypeService.Get(id);
			return Ok(mediaType);
		}
		[HttpPost("UpdateMedia")]
		public IActionResult UpdateMediaType(MediaType mediatype)
		{
			var result = mediaTypeService.Update(mediatype);
			return Ok(result);
		}
		[HttpPost("DeleteMedia")]
		public IActionResult DeleteMedia(MediaType mediaType) 
		{
			var result = mediaTypeService.Delete(mediaType);
			return Ok(result);
		}
	}
}
