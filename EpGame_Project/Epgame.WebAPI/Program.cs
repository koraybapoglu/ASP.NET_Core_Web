
using EpGame.BusinessLogicLayer.Abstract;
using EpGame.BusinessLogicLayer.Concrete;
using EpGame.DataAccesLayer.Abstract;
using EpGame.DataAccesLayer.Concrete.ENTITY_FRAMEWORK;

namespace EpGame.WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddScoped<ICartDAL, EFCart>();
			builder.Services.AddScoped<IGameDAL, EFGame>();
			builder.Services.AddScoped<IMediaDAL, EFMedia>();
			builder.Services.AddScoped<IMediaTypeDAL, EFMediaType>();
			builder.Services.AddScoped<ICategoryDAL, EFCategory>();
			builder.Services.AddScoped<IGameCategoryDAL, EFGameCategory>();
			builder.Services.AddScoped<IGiftDAL, EFGift>();

			builder.Services.AddScoped<IGameService, GameManager>();
			builder.Services.AddScoped<ICartService, CartManager>();
			builder.Services.AddScoped<IMediaService, MediaManager>();
			builder.Services.AddScoped<IMediaTypeService, MediaTypeManager>();
			builder.Services.AddScoped<ICategoryService, CategoryManager>();
			builder.Services.AddScoped<IGameCategoryService, GameCategoryManager>();
			builder.Services.AddScoped<IGiftService, GiftManager>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
