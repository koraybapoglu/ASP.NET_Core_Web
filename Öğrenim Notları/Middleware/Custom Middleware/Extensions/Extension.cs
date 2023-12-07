using MiddlewareExample.Middlewares;

namespace MiddlewareExample.Extensions
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<HelloMiddleware>();
        }
    }
}
