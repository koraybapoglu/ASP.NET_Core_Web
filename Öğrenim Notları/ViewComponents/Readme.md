# ViewComponent Nedir?

ViewComponent, ASP.NET Core MVC tarafından sunulan ve kullanıcı arayüzü bileşenlerini modüler bir şekilde oluşturmayı sağlayan bir yapıdır. PartialView'lar gibi tekrar kullanılabilir yapılar sunar, ancak daha fazla kontrol ve esneklik sağlar.

ViewComponent'ler, genellikle daha karmaşık ve dinamik bileşenlerin oluşturulmasında kullanılır. Örneğin, sayfa kenar çubuğu, menü, reklam banner'ı gibi parçalar ViewComponent olarak tasarlanabilir. Bu bileşenler, bir Controller içindeki iş mantığını içermeyip, kullanıcı arayüzüne özgü görüntü veya işlevsellik sağlar.

### Özellikleri:

- **Modülerlik ve Tekrar Kullanılabilirlik:** ViewComponent'ler, tekrar kullanılabilir yapıları destekler ve farklı sayfalarda veya bileşenlerde kullanılabilir.
  
- **Controller'dan Bağımsızlık:** Controller'a benzer şekilde kullanılabilir, ancak ViewComponent'ler Controller'dan daha özelleştirilebilir ve Controller'ın tek sorumluluk prensibine daha uygun bir yapı sunar. Veri hazırlama işlevselliğini kendisi üstlenebilir.

### Nasıl Kullanılır?

- ViewComponent'ler, `Invoke` metodu ile çalışır. Bu metod, ViewComponent'in çağrıldığında çalıştırılacak kodları içerir ve genellikle bir `IViewComponentResult` döndürür.

Örnek bir ViewComponent:

```csharp

using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;

namespace OrnekProje.ViewComponents
{
    public class HomeFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            List<FooterData> data = new List<FooterData> {
                new FooterData { Id=1, Name = "Koray", Surname = "Bapoğlu"},
                new FooterData { Id=2, Name = "Koray2", Surname = "Bapoğlu2"},
                new FooterData { Id=3, Name = "Koray3", Surname = "Bapoğlu3"}
            };
            return View(data);
        }
    }
}

Bu kod, Invoke metodunda belirli bir veri seti hazırlayarak bu veriyi ViewComponent çağrıldığında gösterecek olan bir View'e taşıyor.

ViewComponent'ler, kullanıcı arayüzü bileşenlerini modüler bir şekilde oluşturmanın yanı sıra, kodu daha modüler, yeniden kullanılabilir ve SOLID prensiplerine uygun bir şekilde yazmamızı sağlar.