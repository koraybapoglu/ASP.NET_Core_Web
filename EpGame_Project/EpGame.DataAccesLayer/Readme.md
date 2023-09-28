# EpGame.DataAccessLayer Katmanı

Bu README dosyası, `EpGame.DataAccessLayer` katmanındaki yapıları ve bu katmanın görevlerini detaylı bir şekilde açıklar. Bu katman, veri erişimi (veritabanı işlemleri) ve veritabanı bağlantısı ile ilgili işlemleri içerir.

## Abstract Dosyası

`Abstract` dosyası, veritabanı işlemlerini soyutlamak ve her veri tablosu için bir arayüz (interface) tanımlamak için kullanılır. Bu arayüzler, genellikle temel CRUD (Create, Read, Update, Delete) işlemlerini içerir. Ayrıca, temel işlemlere ekstra özelleştirmeler yapmak için kullanılabilirler.

## Concrete Dosyası

`Concrete` dosyası, `Abstract` dosyasında tanımlanan arayüzleri (interface) uygulayan sınıfları içerir. Bu sınıflar, genellikle veritabanı işlemlerini doğrudan yaparlar. 

## DbContext Dosyası

`DbContext` sınıfı, veritabanı bağlantısını temsil eder ve veritabanına bağlanmak, veritabanından veri çekmek ve değişiklikleri kaydetmek için kullanılır.

## Mappings Dosyası

`Mappings` dosyası, veritabanı tabloları ile varlık (entity) sınıfları arasındaki eşleştirmeleri içerir. Bu dosya, hangi sınıfın hangi veritabanı tablosuna karşılık geldiğini tanımlar.

## Migrations Dosyası

`Migrations` dosyası, veritabanında yapılan değişiklikleri (örneğin, yeni bir tablo eklemek veya bir tabloya yeni bir sütun eklemek) takip eder ve veritabanı şemasını güncellemek için kullanılır.

Bu README dosyası, `EpGame.DataAccessLayer` katmanının yapılarını ve görevlerini açıklar. Projeye özgü ihtiyaçlarınıza göre bu açıklamaları düzenleyebilirsiniz.
