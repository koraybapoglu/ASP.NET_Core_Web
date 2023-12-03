# Serverdaki Validationları Client Tabanlı Uygulamak

Bu süreci başlatmak için aşağıdaki adımları takip etmeniz gerekiyor:

## Gerekli Kütüphanelerin Yüklenmesi

- `jquery` kütüphanesi
- `jquery-validate` kütüphanesi
- `jquery-validation-unobtrusive` kütüphanesi

### Kütüphanelerin Eklenmesi

Eğer `wwwroot` dizini yoksa, `wwwroot` içerisine ekleyebilirsiniz. Bu kütüphaneleri eklemek için:

1. `wwwroot` oluşturun (eğer yoksa).
2. `wwwroot` içerisine kütüphane dosyalarını ekleyin.

### Kütüphane Yükleme İşlemi

1. `wwwroot` içerisine gidin.
2. Add => Add Client-Side Library seçeneğine gidin.
3. İlgili kütüphaneleri aratarak yükleyin.

## View'e Eklenmesi

Validation işlemlerinin gerçekleştirildiği view'e ilgili `min.js` dosyalarını ekleyin.

## Otomatik Dinamik Validasyon İşlemi

ASP.NET Core'daki model binding mekanizması, bu kütüphaneleri view'e eklediğinizde, server tabanlı validation işlemlerini otomatik olarak client tabanlı hale getirir. Böylece, ekstra bir işlem yapmadan validation işlemlerini dinamik olarak uygulamış olursunuz.

Bu adımları takip ederek serverdaki validation işlemlerini kolayca client tabanlı olarak uygulayabilirsiniz.
