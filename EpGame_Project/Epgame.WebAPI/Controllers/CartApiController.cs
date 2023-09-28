using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EpGame.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartApiController : Controller
	{
		ICartService cartService;
        public CartApiController(ICartService cartservice)
        {
				cartService= cartservice;
        }
		[HttpGet("getcarts")]
		public IActionResult GetCarts() 
		{
			var carts = cartService.GetAll();
			return Ok(carts);
		}
		[HttpGet("getcart/{id}")]
		public IActionResult GetCart(int id) 
		{
			var cart = cartService.Get(id);
			return Ok(cart);
		}
		[HttpPost("addcart")]
		public IActionResult Addcart(Cart cart) 
		{
			var result = cartService.Add(cart);
			return Ok(result);
		}
		[HttpPost("updatecart")]
		public IActionResult Updatecart(Cart cart) 
		{
			var result = cartService.Update(cart);
			return Ok(result);
		}
		[HttpPost("deletcart")]
		public IActionResult Deletecart(Cart cart) 
		{
			var result= cartService.Delete(cart);
			return Ok(result);
		}
    }
}
