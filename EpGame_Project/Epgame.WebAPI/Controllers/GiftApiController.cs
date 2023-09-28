using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EpGame.WebAPI.Controllers
{
	[Route("api/[controller]")]
	public class GiftApiController : Controller
	{
		IGiftService giftservice;
		public GiftApiController(IGiftService GiftService)
		{
			giftservice = GiftService;
		}
		[HttpGet("getallgift")]
		public IActionResult GetAllGifts()
		{
			var gifts = giftservice.GetAll();
			return Ok(gifts);
		}

		[HttpGet("getgift")]
		public IActionResult GetGifts(int id)
		{
			var gift = giftservice.Get(id);
			return Ok(gift);
		}
		[HttpPost("updategift")]
		public IActionResult UpdateGift(Gift gift)
		{
			var result = giftservice.Update(gift);
			return Ok(result);
		}
		[HttpPost("deletegift")]
		public IActionResult DeleteGift(Gift gift) 
		{
			var result=giftservice.Delete(gift);
			return Ok(result);
		}
	}
}

