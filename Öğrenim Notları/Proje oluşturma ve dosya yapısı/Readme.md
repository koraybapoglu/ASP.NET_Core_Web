# ASP.NET Core Uygulamaları Hakkında Bilgi

ASP.NET Core uygulamaları, temelde bir tür console uygulaması olarak düşünülebilir. Ancak, .NET 6.0 ve sonrası projelerde, geleneksel olarak kullanılan `Startup.cs` dosyası kaldırılmıştır. Bunun yerine, yapılandırma ve hizmet ekleme işlemleri `Program.cs` dosyası altında toplanmıştır.

## Program.cs Dosyası

`Program.cs`, ASP.NET Core uygulamasının başlangıç noktasını temsil eder. Bu dosya içinde, uygulamanın sunucusunu (localhost) ayağa kaldırdığı ve belirli yapılandırma işlemlerinin yapıldığı yerdir.

## Servis Kavramı

`builder.Services` kısmında yapılan konfigürasyonlar, uygulamada kullanılacak olan servisleri eklediğimiz ve yapılandırdığımız bölümdür. Servisler, belirli işlevlere odaklanmış ve o işlevin sorumluluğunu üstlenmiş kütüphaneler ya da sınıflardır.

### Servis = Module = Kütüphane

## appsettings.json Dosyası

`appsettings.json`, yazılımlarda genel olarak uygulamanın her yerinde kullanılacak metinsel değerleri tutmak için kullanılır. Örneğin, veritabanı bağlantı stringi gibi değerler, her yerde ayrı ayrı belirlemek yerine bu dosya içinde saklanabilir.

Bu dosya, uygulamanın yapılandırma ayarlarını barındırır ve genellikle bu tür metinsel değerlerin saklanması için tercih edilir.

---

Bu README dosyası, ASP.NET Core uygulamaları ve bazı temel kavramlar hakkında genel bir bilgilendirme içermektedir. Projenizdeki yapılandırma ve hizmet eklemesiyle ilgili detaylı bilgileri `Program.cs` dosyası içerisinde bulabilirsiniz.
