# ASP.NET Core `Use` Metodu

`Use` metodu, bir ASP.NET Core uygulamasında middleware'lerin eklenmesi için kullanılan bir yapıdır. Bu metot, belirli bir middleware'i uygulama akışına dahil eder ve o middleware'in işlevini gerçekleştirmesini sağlar.

## `Use` Metodu Nedir?

`Use` metodu, middleware'leri uygulama akışına eklemek için kullanılır. Her bir `Use` metodu, gelen HTTP isteklerini işleyebilecek ve bir sonraki middleware'e geçiş yapabilecek bir bileşen ekler.

`Use` metodu, devreye girdikten sonra sıradaki middleware'i çağırabilir ve işlevini tamamladıktan sonra devam edebilir. Yani, bir middleware işlevi tamamlandıktan sonra bir sonraki middleware'e geçiş yapabilir ve ardından o noktadan devam edebilir.


![Çıktı Ekranı](https://github.com/koraybapoglu/ASP.NET_Core_Web/tree/main/%C3%96%C4%9Frenim%20Notlar%C4%B1/Middleware/Use%20Methodu/Use.png)