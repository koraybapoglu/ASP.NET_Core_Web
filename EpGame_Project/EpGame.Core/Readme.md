# EpGame.Core Katmanı

Bu README dosyası, `EpGame.Core` katmanının temel işlevselliğini ve içeriğini özetler. Core katmanı, uygulamanın merkezi iş mantığını ve paylaşılan bileşenleri içerir.

## DataAccesLayer (Veri Erişim Katmanı)

`DataAccesLayer` dosyası, veritabanı işlemlerini gerçekleştirmek için kullanılan `IRepository` arabirimini içerir. Bu arabirim, temel veritabanı işlemlerini (ekleme, silme, güncelleme, sorgulama) tanımlar ve üst katmanlarda kullanılır.

## BusinessLogicLayer (İş Mantığı Katmanı)

`BusinessLogicLayer` dosyası, uygulamanın iş mantığını oluşturan iki ana bileşeni içerir:
- `Logger`: Uygulamanın hata ayıklamasını ve performans izlemesini kolaylaştırmak için kullanılan bir loglama kütüphanesidir. İş mantığı katmanında hata durumlarını yakalamak ve loglamak için kullanılır.
- `IGenericService`: Genel iş mantığı hizmetlerini sağlamak için kullanılan bir arabirimdir. Genellikle temel veritabanı işlemlerini (ekleme, silme, güncelleme, sorgulama) gerçekleştirmek için kullanılır.

## EntityLayer (Varlık Katmanı)

`EntityLayer` dosyası, veritabanı tablolarına karşılık gelen `BaseEntity` sınıfını içerir. `BaseEntity`, tüm Entity sınıflarının ortak özelliklerini (örneğin, ID, aktif durumu, oluşturma tarihi, güncelleme tarihi) içerir ve üst katmanlarda kullanılır.

Bu README dosyası, `EpGame.Core` katmanının temel bileşenlerini ve bu bileşenlerin üst katmanlarda nasıl kullanıldığını özetlemektedir.
