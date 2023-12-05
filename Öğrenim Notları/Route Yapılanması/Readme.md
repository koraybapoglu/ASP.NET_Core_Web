# Derinlemesine Route Yapılanması

## Route Nedir?

Route, bir HTTP isteğinin bir MVC Controller Action'ına eşlenmesini sağlayan bir URL desenidir. ASP.NET Core MVC'de routing, gelen isteği doğru Controller ve Action'a yönlendirmek için kullanılır. Bu, istemci isteğine göre hangi Controller'ın ve Action'ın çalıştırılacağını belirler.

## DefaultControllerRoute Ayarlama

ASP.NET Core MVC'de, varsayılan bir Controller ve Action belirleyebilirsiniz. Bu, uygulama açıldığında hangi Controller ve Action'ın çalışacağını tanımlar.

Örneğin:

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

Bu, varsayılan olarak "Home" Controller'ının "Index" Action'ını çalıştırır. Eğer URL'de belirtilen Controller veya Action bulunamazsa, bu varsayılan olarak çalışır.
MapControllerRoute ile Custom Route Ayarlama

MapControllerRoute metodu, Controller ve Action'ları belirli bir desene göre eşlemek için kullanılır. Bu, özel URL yapılandırmalarını tanımlamak için kullanışlıdır.

Örneğin:

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "custom",
        pattern: "myroute/{controller}/{action}/{id?}");
});

Bu, "/myroute" ön eki ile Controller ve Action'ları eşleştirecektir.
Route Constraints

Route Constraints, URL desenlerine uygulanan kısıtlamalardır. Bu, URL'nin belirli bir formatta olmasını veya belirli bir değere sahip olmasını sağlar.

Örneğin:

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "constraint",
        pattern: "{controller}/{action}/{id:int}");
});

Bu, "id" parametresinin sadece tam sayı olmasını zorlar.
Custom Constraints

Kendi özel Route Constraints'lerinizi oluşturabilirsiniz. Bu, URL desenlerini özelleştirmenize ve daha fazla kontrol sağlamanıza olanak tanır.

Örneğin:

public class CustomConstraint : IRouteConstraint
{
    public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        // Kendi kısıtlama mantığınızı buraya ekleyin
        return true;
    }
}

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "customConstraint",
        pattern: "{controller}/{action}/{id:customConstraint}");
});

Bu, "id" parametresinin özel bir kısıtlamaya sahip olmasını sağlar. Kendi kısıtlama mantığınızı Match metodunda tanımlayabilirsiniz.