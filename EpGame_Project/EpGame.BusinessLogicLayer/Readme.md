# İş Mantığı Katmanında Loglama Kullanımı

Bu README dosyası, ASP.NET Core'da N katmanlı mimaride iş mantığı katmanında loglama işlemini nasıl gerçekleştireceğinizi açıklar. Loglama, uygulamanızın hata ayıklaması ve performans izlemesi için önemli bir araçtır.

## Adım 1: EpGameLog Servisini Kullanın

### 1.1. EpGameLog Servisini Ekleyin:

İş mantığı katmanında loglama yapmak için EpGameLog adında bir loglama servisi kullanıyoruz. Bu servisi projenize eklemelisiniz. Aşağıda, loglama servisini nasıl kullanacağınızı gösteren bir örnek bulunmaktadır.

```csharp
using EpGame.Core.BusinessLogicLayer.Logger;
using System;

public class CartManager : ICartService
{
    ICartDAL daL;

    public CartManager(ICartDAL CartDAL)
    {
        daL = CartDAL;
    }

    public bool Add(Cart entity)
    {
        try
        {
            return daL.Add(entity);
        }
        catch (Exception ex)
        {
            EpGameLog.AddLog(ex.Message, LogType.Error);
            return false;
        }
    }

    // Diğer iş mantığı metotları için aynı loglama yaklaşımını kullanabilirsiniz
}


##Adım 2: EpGameLog Servisi ile Loglama
2.1. Hata Durumlarında Loglama Ekleyin:

Her iş mantığı metodu içinde hata durumlarını yakalamak ve loglamak için try-catch bloklarını kullanabilirsiniz. Hata durumunda, EpGameLog servisi kullanılarak hata mesajı kaydedilir.

Örneğin, Add metodu için:


public bool Add(Cart entity)
{
    try
    {
        return daL.Add(entity);
    }
    catch (Exception ex)
    {
        EpGameLog.AddLog(ex.Message, LogType.Error);
        return false;
    }
}

2.2. Loglama Seviyelerini Özelleştirin:

LogType.Error parametresi, loglama servisine hatanın bir hata olduğunu belirten bir log seviyesi sağlar. İhtiyaca göre farklı log seviyelerini kullanabilirsiniz.
Adım 3: İş Mantığı Hizmetlerini Kullanın

Artık iş mantığı hizmetlerinizi kullanırken hata durumlarını loglayabilirsiniz. Bu loglar, uygulamanızın hata ayıklamasını ve performans izlemesini kolaylaştıracaktır.

Bu örnek, EpGameLog servisi kullanarak iş mantığı katmanında loglama yapmanızı açıklamaktadır. Projeye özgü ihtiyaçlarınıza göre loglama servisini daha fazla özelleştirebilirsiniz.
    

    
Bu README dosyası, iş mantığı katmanında loglama işlemini detaylı bir şekilde açıklamaktadır. Bu örnek üzerinden ihtiyacınıza uygun şekilde düzenlemeler yapabilirsiniz.



