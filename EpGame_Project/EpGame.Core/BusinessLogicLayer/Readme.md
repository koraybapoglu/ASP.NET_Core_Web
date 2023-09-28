# EpGame.Core Katmanı İçinde Business Logic Layer

Bu README dosyası, `EpGame.Core` katmanında yer alan Business Logic Layer (İş Mantığı Katmanı) ile ilgili bazı önemli yapıları açıklamaktadır. Bu katman, genel iş mantığı, loglama ve genel hizmet arabirimleri gibi temel işlevselliği sağlar.

## Logger (Loglama)

Logger, uygulamanızın hata ayıklamasını ve performans izlemesini kolaylaştırmak için kullanılan bir loglama kütüphanesidir. İşte Logger hakkında daha fazla bilgi:

### Kullanım

```csharp
using System;
using System.IO;

namespace EpGame.Core.BusinessLogicLayer.Logger
{
    public class EpGameLog
    {
        public static void AddLog(string message, LogType Logtype)
        {
            FileStream file = new FileStream("EpGameLogs.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Log Türü: " + Logtype + " Hata Mesajı: " + message + " Log Tarihi:" + DateTime.Now);
            writer.Close();
        }
    }

    public enum LogType
    {
        Error,
        Warning,
        Info,
        Insert,
        Update,
        Delete,
        NotFound,
        NonValidation
    }
}


Logger, uygulamanızın çeşitli log seviyeleri (örneğin, hata, uyarı, bilgi) için mesajları kaydetmek için kullanılır. AddLog yöntemi, belirtilen mesajı ve log seviyesini bir metin dosyasına kaydeder.
IGenericService (Genel Hizmet Arabirimi)

IGenericService, genel iş mantığı hizmetleri sağlamak için kullanılan bir arabirimdir. Genellikle temel veritabanı işlemlerini (ekleme, silme, güncelleme, sorgulama) gerçekleştirmek için kullanılır.

using EpGame.Core.Entity;
using System;
using System.Collections.Generic;

namespace EpGame.Core.BusinessLogicLayer
{
    public interface IGenericService<TEntity> where TEntity : class, IBaseEntity, new()
    {
        bool Add(TEntity entity);
        bool Delete(TEntity entity);
        bool Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
    }
}

IGenericService, herhangi bir varlık sınıfı için genel işlem metotlarını içeren bir arabirimdir. Add, Delete, Update, GetAll, ve Get gibi temel metotları içerir.

Bu yapılar, EpGame.Core katmanında iş mantığı kodlarınızı daha organize etmek ve yeniden kullanılabilirliği artırmak için kullanılır. İhtiyacınıza göre bu yapıları projenize uyarlayabilir ve özelleştirebilirsiniz.



Bu README dosyası, `EpGame.Core` katmanındaki Business Logic Layer ile ilgili yapıları ve kullanımını açıklamaktadır. Projeye özgü ihtiyaçlarınıza göre bu açıklamaları düzenleyebilirsiniz.


