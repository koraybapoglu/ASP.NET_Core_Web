# MVC Mimarisini Uygulamaya Eklemek

ASP.NET Core uygulamasında MVC mimarisini kullanabilmek için Controller ve View yapılandırmalarının eklenmesi gerekmektedir. Bunun için ilk adım olarak, bu servis uygulamaya eklenir:

builder.Services.AddControllersWithViews();

Bu adım sayesinde uygulama, MVC davranışını sergileyebilecektir.

app.UseRouting(); middleware'i, gelen isteğin rotasını belirler.

## Action Nedir?

Controller sınıfları içerisinde istekleri karşılayan metotlara "action" metot denir. Tanımlanan tüm metotlar action metot olarak kabul edilir.

## View Dosyaları

View dosyaları, genellikle .cshtml uzantılı dosyalardır. Bu dosyalar, C# ve HTML'i birleştirerek oluşturulan Razor sayfalarıdır.

Controller içerisinden farklı bir view döndürmek istiyorsak, şöyle bir yöntem kullanabiliriz:

ViewResult result = View("ornekresult");
return result;

Bu kod parçası, farklı bir view'i döndürmek için kullanılabilir.