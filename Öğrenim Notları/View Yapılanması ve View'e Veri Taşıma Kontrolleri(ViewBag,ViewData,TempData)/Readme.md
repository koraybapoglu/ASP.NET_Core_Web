# ASP.NET Core MVC Veri Taşıma Yöntemleri

Bu proje, ASP.NET Core MVC'de Controller'dan View'e veri aktarımı için farklı yöntemleri göstermektedir.

## Model Bazlı Veri Gönderimi

Model nesneleri, Controller'dan View'e veri aktarımını sağlar. Strongly-typed bir model kullanılarak veriler taşınır. Örnek bir kullanım:

public IActionResult Index()
{
    var model = new SampleModel { /* ... */ };
    return View(model);
}

## Veri Taşıma Kontrolleri

### ViewBag

Dinamik bir yapı kullanarak Controller'dan View'e veri aktarımı yapılır:

public IActionResult Index()
{
    ViewBag.Message = "Merhaba!";
    return View();
}

### ViewData

Key-value çiftleriyle çalışan ViewData, Controller'dan View'e veri aktarmak için kullanılır:

public IActionResult Index()
{
    ViewData["Key"] = "Value";
    return View();
}

### TempData

İstekler arası geçici veri aktarımını sağlar ve tarayıcı çerezlerini kullanır:

public IActionResult Index()
{
    TempData["Message"] = "Geçici Mesaj";
    return RedirectToAction("AnotherAction");
}

Dikkat Edilmesi Gerekenler

    ViewBag ve ViewData dinamik veri taşıma yöntemleridir ve tip güvenliği sağlamazlar.
    TempData, geçici olarak veri taşıma ve bir istekten diğerine veri aktarma yeteneği sunar.

Bu yöntemler arasında seçim yaparken, uygulamanın gereksinimleri, veri taşıma sürekliliği ve tip güvenliği gibi faktörler göz önünde bulundurulmalıdır.