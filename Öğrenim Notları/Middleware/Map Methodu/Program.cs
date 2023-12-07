namespace MiddlewareExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.Use(async (context, next) =>
            {
                Console.WriteLine("Middleware 1 Baþlatýldý.");
                await next.Invoke();
                Console.WriteLine("Middleware 1 Sona Erdi !");
            });
            app.Map("/Home", builder =>
            {
                builder.Run(async c => await c.Response.WriteAsync("Run Middleware'i tetiklendi !"));
            });
            app.Map("/Product", builder =>
            {
                builder.Use(async (context, task) => 
                {
                    Console.WriteLine("Start Use Middleware2");
                    await task.Invoke();
                    Console.WriteLine("Stop Use Middleware2");
                });
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
