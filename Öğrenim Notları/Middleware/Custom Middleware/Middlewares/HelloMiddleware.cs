namespace MiddlewareExample.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
                _next = next;
        }
        public async Task Invoke(HttpContext httpContext) 
        {
            //Custom operasyon....

            Console.WriteLine("Hello");
            await _next.Invoke(httpContext);
            Console.WriteLine("Hello2");
        }
    }
}
