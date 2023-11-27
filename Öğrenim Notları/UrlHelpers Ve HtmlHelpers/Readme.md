# URLHelpers ve HTMLHelpers

## URLHelpers Nedir?

URLHelpers, ASP.NET Core MVC uygulamalarında URL oluşturmak için kullanılan yardımcı metotları içeren bir sınıftır. Bazı temel metotları şunlardır:

### Action Metodu

Url.Action("Index", "Product", new { id = 5 })

Bu metot, verilen Controller ve Action'a ait URL oluşturur. Örneğin, /Product/Index/5 gibi bir URL döndürebilir.

### ActionLink Metodu

Url.ActionLink("Index", "Product", new { id = 5 })

Bu metot, verilen Controller ve Action'a ait URL oluşturur ve HTML formatında bir link oluşturur. Örneğin, <a href="https://localhost:5001/Product/Index/5">...</a> gibi bir link oluşturabilir.

### HTMLHelpers Nedir?

HTMLHelpers, HTML etiketlerini sunucu tabanlı olarak oluşturmamızı sağlayan yardımcı metotları barındıran bir yapıdır. Temel amaçları şunlardır:

    View'leri render etme
    ViewContext, TempData, ViewData, ViewBag gibi özelliklere erişme
    Veri taşıma kontrollerini yönetme

### HtmlPartial Metodu

Html.Partial("_PartialView", model)

Bu metot, belirtilen bir View'i render etmeye yarar. Bir Controller'dan gönderilen model/data ile bir View içinde farklı bir View'in render edilmesine olanak tanır.

### HtmlRenderPartial Metodu

Html.RenderPartial("_PartialView", model)


Bu metot, HtmlPartial'a benzer bir şekilde bir View'i render etmeye yarar. Ancak HtmlPartial'a göre daha hızlıdır.

### HtmlActionLink Metodu

Html.ActionLink("Link Text", "Action", "Controller", new { id = 5 }, null)

Bu metot, bir Action ve Controller'a ait bir link oluşturur. HTML formatında bir <a> etiketi üretir.

Bu README dosyası, URLHelpers ve HTMLHelpers'ın ne olduğunu ve temel metotlarını açıklamaktadır.