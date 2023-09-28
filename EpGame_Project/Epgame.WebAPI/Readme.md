# EpGame.WebAPI Katmanı

Bu README dosyası, `EpGame.WebAPI` katmanının temel işlevselliğini ve yapısını özetler. WebAPI katmanı, uygulamanın HTTP isteklerini alarak iş mantığını yürüten bir arayüz sağlar.

Program.cs

Program.cs dosyası, WebAPI uygulamasının ana giriş noktasını içerir. Servislerin kaydedilmesi, Swagger/OpenAPI konfigürasyonu ve HTTP istek yönlendirmeleri gibi uygulamanın temel ayarlarını yapar.

## Controllers (Denetleyiciler)

`Controllers` klasörü, API'nin dış dünyayla etkileşimini yöneten denetleyici sınıflarını içerir. Her tabloya karşılık gelen bir denetleyici bulunur ve bu denetleyiciler, ilgili iş mantığı hizmetleriyle işbirliği yaparlar. İşte bir denetleyici örneği:

```csharp
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

		// Diğer HTTP isteklerine karşılık gelen metotlar
    }
}

Program.cs :

public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Servislerin eklenmesi

			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddScoped<ICartDAL, EFCart>();
			builder.Services.AddScoped<IGameDAL, EFGame>();
			// Diğer servislerin eklenmesi

			var app = builder.Build();
