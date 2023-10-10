# Admin Paneli Uygulaması

Bu proje, basit bir Admin Paneli uygulamasının n katmanlı mimari kullanılarak geliştirilmiş halini içermektedir. Bu uygulama, CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmek için Entity Framework Core, ASP.NET Core Web API ve ASP.NET Core MVC teknolojilerini kullanmaktadır.

## Kullanım

Bu uygulama, aşağıdaki temel CRUD işlemlerini yönetmek için kullanılır:

- Admin Ekleme
- Admin Güncelleme
- Admin Silme
- Tüm Adminleri Getirme
- Admini E-posta Adresi ile Getirme

## Teknolojiler

- ASP.NET Core
- Entity Framework Core
- Razor Pages
- Bootstrap
- ve diğerleri

## Katmanlı Mimarisi

Bu uygulama, n katmanlı bir mimariye sahiptir ve kodları organize etmek için şu katmanları içerir:

- **Admin.MVC:** MVC uygulaması, kullanıcı arayüzünü temsil eder.
- **Admin.API:** Web API uygulaması, verileri sunar ve iş mantığı işlemlerini gerçekleştirir.
- **Admin.BusinessLogicLayer:** İş mantığı işlemlerini yönetir.
- **Admin.DataAccesLayer:** Veritabanı işlemlerini gerçekleştirir.
- **Admin.EntityLayer:** Veritabanı tablolarının model sınıflarını içerir.

## Katkıda Bulunma

1. Bu depoyu fork edin.
2. Yeni bir özellik ekleyin veya hata düzeltmeleri yapın.
3. Değişikliklerinizi bir pull isteği olarak gönderin.
4. İnceleme ve onay işleminden sonra değişikliklerinizi ana depoya birleştiririz.

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için [LICENSE.md](LICENSE.md) dosyasına bakın.
