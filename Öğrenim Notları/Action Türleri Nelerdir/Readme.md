# Action Tipleri ASP.NET Core MVC'de

## ViewResult Nedir?

Response olarak bir View dosyasını (.cshtml) render etmemizi sağlayan bir Action türüdür. Kullanıcıya görüntü sunmak için kullanılır.

## PartialViewResult Nedir?

Yine bir View dosyasını render etmemizi sağlayan bir Action türüdür. Temel farkı, client tabanlı yapılan AJAX isteklerinde daha çok kullanıma yatkın olmasıdır.

## JsonResult Nedir?

Üretilen veriyi JSON formatına dönüştürüp döndüren bir Action türüdür. Genellikle web servislerinde veya AJAX tabanlı isteklerde kullanılır.

## EmptyResult Nedir?

Bazı durumlarda, gelen istekler sonucunda herhangi bir şey döndürmek istemeyebiliriz. Bu tür durumlarda EmptyResult Action türü kullanılabilir.

## ActionResult Nedir?

Gelen bir istek sonucunda geriye döndürülecek Action türlerinin değişkenlik gösterebildiği durumlarda kullanılır. ActionResult, tüm Action tiplerini karşılayan ana türdür ve genellikle çoklu durumlar için kullanılır.

---

Bu açıklamalar, ASP.NET Core MVC içindeki Action tiplerini ve her birinin farklı kullanım amaçlarını açıklamaktadır. ActionResult, tüm Action tiplerini kapsar ve değişkenlik gösterebilen durumlarda kullanılır.
