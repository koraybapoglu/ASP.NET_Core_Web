
# Razor ve @ Operatörü Kullanımı

## Razor Nedir?

Razor, ASP.NET Core MVC'de .cshtml uzantılı dosyalarda kullanılan bir şablon motorudur. Bu motor, HTML ile birlikte C# kodlarını kullanarak dinamik içerik üretmeyi sağlar. Bu sayede sunucu tarafında çalışan kodlar, HTML sayfalarına entegre edilebilir.

## @ Operatörü Nedir?

@ işareti, Razor syntax'inde kullanılan bir operatördür. Razor içinde C# kodlarını belirtirken kullanılır. Bu operatör, sunucu tarafında çalışan C# kodlarını ayırmak ve HTML içine gömmek için kullanılır.

Örnek olarak:

<p>Merhaba, @Model.Name!</p>


Bu örnek, @ işaretiyle C# kodunun HTML içine gömülmesini sağlar.
Razor ile Değişken Oluşturma

Razor içinde değişkenler, C# blokları kullanılarak oluşturulabilir. Örneğin:

@{
    string metin = "asdsadsad";
}


Bu örnekte, metin adında bir değişken oluşturulmuş ve değeri "asdsadsad" olarak atanmıştır. Bu değişken daha sonra Razor sayfasında kullanılabilir.