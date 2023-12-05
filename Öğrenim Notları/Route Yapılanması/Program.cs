namespace RouteYapilanmasi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthorization();

            app.MapControllerRoute("Default5","{controller=Home}/{action=Index}/{id=int?}/{x?}/{y?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            //Custom Route
            app.MapControllerRoute(
                name: "Default2",
                pattern:"{action}/ahmet/{controller}"); //index/ahmet/home
            app.MapControllerRoute(
                name: "Default3", 
                pattern:"{controller=Personel}/koray/{action=Index}"); //Personel/koray/Index
            app.MapControllerRoute(
                name: "Default4",
                "anasayfa",
                new {controller="Home",action="Index"});
            app.Run();
        }
    }
}
