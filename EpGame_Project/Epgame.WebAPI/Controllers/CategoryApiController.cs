using EpGame.BusinessLogicLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EpGame.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryApiController : Controller
	{
		ICategoryService categoryservice;
		public CategoryApiController(ICategoryService categoryService)
		{
			categoryservice = categoryService;
		}
		[HttpGet("getallcategories")]
		public IActionResult GetAll() 
		{
			var category=categoryservice.GetAll();
			return Ok(category);
		}
		[HttpGet("getcategory")]
		public IActionResult Get(int id) 
		{
			var category=categoryservice.Get(id);
			return Ok(category);
		}
		[HttpPost("addcategory")]
		public IActionResult AddCategory(Category category)
		{
			var result = categoryservice.Add(category);
			return Ok(result);
		}
		[HttpPost("updatecategory")]
		public IActionResult UpdateCategory(Category category) 
		{
			var result = categoryservice.Update(category);
			return Ok(result);
		}
		[HttpPost("deletecategory")]
		public IActionResult DeleteCategory(Category category) 
		{
			var result = categoryservice.Delete(category);
			return Ok(result);
		}
	}
}
