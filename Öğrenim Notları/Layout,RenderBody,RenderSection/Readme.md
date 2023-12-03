# Layout Yapılanması ve İçeriği

## Layout Nedir?

Web sayfalarında kullanılan tekrar eden yapıların ortak bir şablonu olan ve sayfadan sayfaya aynı kalabilen header, footer gibi bölümleri içeren yapıdır. Değişmeyen kısımları tek bir yerde yönetmek ve kullanıcılara tutarlı bir deneyim sunmak için kullanılır.

## RenderBody Methodu Nedir?

Layout içerisindeki o an render edilen view'in içeriğini yerleştiren bir fonksiyondur. Bu method, o an render edilen view'in içeriğinin layout içinde hangi alana yerleştirileceğini belirtir.

## RenderSection Methodu Nedir?

Layout içinde isimlendirilmiş bölümler oluşturarak, ihtiyaç halinde o bölümlere view'lerden gelen içerikleri yerleştirmemizi sağlar. Genellikle script veya stil referansları gibi view'ler arasında farklılık gösteren alanlarda kullanılır.

Örneğin, farklı view'lerde farklı script dosyalarına ihtiyaç varsa, bu dosyaları view'lerde değil, belirli isimlerle tanımlanan bölümlerde layout içinde kullanmak daha etkili olabilir.
