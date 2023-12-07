# Custom Middleware Nedir?

Custom middleware, ASP.NET Core uygulamalarında isteklerin işlenmesi ve yanıtların oluşturulması sırasında araya giren özelleştirilmiş kod parçalarıdır. Bu middleware'ler, HTTP istekleriyle ilgili işleri yapmak veya istekler üzerinde değişiklikler yapmak için kullanılır.

Bu middleware'ler, HTTP isteklerini ele alarak gelen istekleri işleyebilir, HTTP yanıtlarını değiştirebilir veya gelen istekler üzerinde özelleştirilmiş işlemler gerçekleştirebilir.

Özel bir middleware oluşturmak için genellikle `RequestDelegate` tipinde bir metot alır ve `InvokeAsync` veya `Invoke` yöntemlerini içerir. Bu yöntem, gelen istekleri işler ve sonraki middleware'e iletebilir veya yanıt üretebilir.

Custom middleware'ler, uygulama içindeki farklı aşamalarda isteği ele almak için kullanılabilir. Örneğin, isteğin başına veya sonuna özel bir işlem eklemek için kullanılabilir.

Bu özelleştirilmiş ara katmanlar, ASP.NET Core uygulamalarının esnekliğini artırır ve genellikle tekrar kullanılabilir şekilde tasarlanabilir.

Özetle, custom middleware'ler, HTTP istekleri ve yanıtları üzerinde özelleştirilmiş işlemler gerçekleştirmek için kullanılan özel kod parçalarıdır ve ASP.NET Core uygulamalarında güçlü bir araçtır.

![Çıktı Ekranı](https://github.com/koraybapoglu/ASP.NET_Core_Web/tree/main/%C3%96%C4%9Frenim%20Notlar%C4%B1/Middleware/Custom%20Middleware/Custom.png)