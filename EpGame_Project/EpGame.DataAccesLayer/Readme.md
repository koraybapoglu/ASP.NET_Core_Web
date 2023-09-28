# EpGame.DataAccessLayer Katmanı

Bu README dosyası, `EpGame.DataAccessLayer` katmanında yer alan yapıları ve bu katmanın görevlerini detaylı bir şekilde açıklar. Bu katman, veri erişimi (veritabanı işlemleri) ve veritabanı bağlantısı ile ilgili işlemleri içerir.

## Abstract Dosyası

`Abstract` dosyası, veritabanı işlemlerini soyutlamak ve her veri tablosu için bir arayüz (interface) tanımlamak için kullanılır. Bu arayüzler, genellikle temel CRUD (Create, Read, Update, Delete) işlemlerini içerir. Ayrıca, temel işlemlere ekstra özelleştirmeler yapmak için kullanılabilirler.

Örnek bir arayüz:

- `IProductRepository`: Ürün varlığına özgü işlemleri içerir. Temel CRUD işlemlerine ek olarak özel sorgular veya işlemler burada tanımlanabilir.

## Concrete Dosyası

`Concrete` dosyası, `Abstract` dosyasında tanımlanan arayüzleri (interface) uygulayan sınıfları içerir. Bu sınıflar, genellikle veritabanı işlemlerini doğrudan yaparlar ve farklı veritabanı teknolojileri ile uyumlu olabilirler.

Örnek bir sınıf:

- `EfProductRepository`: `IProductRepository` arayüzünü uygular ve Entity Framework kullanarak veri tabanı işlemlerini gerçekleştirir.

- `AdoNetProductRepository`: `IProductRepository` arayüzünü uygular ve ADO.NET kullanarak veri tabanı işlemlerini gerçekleştirir. Bu sınıf, farklı bir veritabanı teknolojisiyle çalışma yeteneği sağlar.

Bu yaklaşım, projenin gereksinimlerine ve kullanılan veritabanı teknolojilerine bağlı olarak farklı veritabanlarına kolayca geçiş yapabilme esnekliği sunar.


## DbContext Dosyası

`DbContext` sınıfı, veritabanı bağlantısını temsil eder ve veritabanına bağlanmak, veritabanından veri çekmek ve değişiklikleri kaydetmek için kullanılır. Veritabanı bağlantısı burada ayarlanır ve tüm işlemler için kullanılır.

## Mappings Dosyası

`Mappings` dosyası, veritabanı tabloları ile varlık (entity) sınıfları arasındaki eşleştirmeleri içerir. Bu dosya, hangi sınıfın hangi veritabanı tablosuna karşılık geldiğini ve alanların nasıl eşleştiğini tanımlar. Bu, ORM çerçevesi kullanılıyorsa önemlidir.

## Migrations Dosyası

`Migrations` dosyası, Code First yaklaşımı kullanıldığında veritabanında yapılan değişiklikleri takip eder. Bu değişiklikler, örneğin yeni bir tablo eklemek veya bir tabloya yeni bir sütun eklemek gibi veritabanı şemasındaki değişiklikleri içerir. Bu dosya ile veritabanı şeması sürüm kontrolü sağlanır.

Bu README dosyası, `EpGame.DataAccessLayer` katmanının yapılarını ve görevlerini detaylı bir şekilde açıklar. Projeye özgü ihtiyaçlarınıza göre bu açıklamaları düzenleyebilir ve daha fazla ayrıntı ekleyebilirsiniz.
