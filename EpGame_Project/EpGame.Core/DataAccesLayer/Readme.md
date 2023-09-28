# EpGame.Core Katmanı İçinde DataAccessLayer

Bu README dosyası, `EpGame.Core` katmanında yer alan DataAccessLayer (Veri Erişim Katmanı) ile ilgili önemli yapıları ve kullanımı hakkında bilgi sunmaktadır. Bu katman, veritabanı işlemleri için temel işlevselliği sağlar.

## IRepository (Veritabanı Erişim Arabirimi)

IRepository, veritabanı işlemleri gerçekleştirmek için kullanılan bir arabirimdir. Genellikle CRUD (Create, Read, Update, Delete) işlemlerini soyutlamak ve veri erişimini daha kolay hale getirmek için kullanılır.

### Kullanım

IRepository'i kullanmak için `EpGame.Core.DataAccesLayer` namespace'ini ve `IRepository` arabirimini ekleyin. Ardından, bu arabirimi uygulayan veya miras alan sınıflar oluşturabilirsiniz.

Bu açıklama, `EpGame.Core` katmanındaki `DataAccessLayer` içinde bulunan `IRepository` arabirimi hakkında temel bilgileri sunar. Projeye özgü ihtiyaçlarınıza göre bu açıklamaları düzenleyebilirsiniz.

```csharp
using EpGame.Core.DataAccesLayer;

public class MyEntityRepository : IRepository<MyEntity>
{
    // IRepository'den gelen metotları uygulayın
}




