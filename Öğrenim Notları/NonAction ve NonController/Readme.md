# NonAction ve NonController Öznitelikleri

## NonAction Nedir?

Controller içerisinde `[NonAction]` özniteliği ile işaretlenen fonksiyonlar, dışarıdan gelen isteklere karşılık vermezler. Bu fonksiyonlar sadece operatif yani iş mantığı yürüten, operasyonel metotlardır. Yani, bu öznitelikle işaretlenmiş bir fonksiyon, bir HTTP isteği karşılamak için kullanılmaz; ancak işlemler gerçekleştirebilir veya diğer metotlar içinde kullanılabilir.

## NonController Nedir?

`[NonController]` özniteliği, bir sınıfın bir Controller olmadığını belirtir. Yani, normal şartlarda ASP.NET Core MVC'de bir Controller olarak kabul edilecek bir sınıfın, bu özniteliği kullanarak Controller olarak kabul edilmemesini sağlar. Bu öznitelik, bir sınıfın Controller olarak tanımlanmasını önler.

---

Bu README dosyası, ASP.NET Core MVC içinde kullanılan `[NonAction]` ve `[NonController]` özniteliklerini açıklıyor. `[NonAction]` ile işaretlenen fonksiyonlar dışarıdan gelen isteklere karşılık vermezken, `[NonController]` özniteliği bir sınıfın Controller olarak kabul edilmemesini sağlar.
