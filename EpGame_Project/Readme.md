# EPGAME Projesi

## Proje Hakkında

EPGAME Projesi, Steam benzeri bir oyun satış platformunu web uygulaması olarak sunan bir projedir. Bu proje, oyunseverlere oyun satın alma, oyunları kütüphaneye ekleme, inceleme yazma ve daha birçok özellik sunar. Proje, ASP.NET Core, Entity Framework Core, N Katmanlı Mimarİ ve ADO.NET gibi teknolojileri kullanarak geliştirilmiştir.

## Kullanılan Teknolojiler

EPGAME Projesi aşağıdaki teknolojileri kullanmaktadır:

- **ASP.NET Core**: Web uygulaması geliştirmek için kullanılan açık kaynaklı bir çerçeve. MVC ve API'lar oluşturmak için idealdir.

- **Entity Framework Core**: Veritabanı işlemlerini kolaylaştıran bir ORM (Object-Relational Mapping) çerçevesi. Veritabanı tablolarını .NET nesneleriyle eşleştirmenizi sağlar.

- **N Katmanlı Mimarİ**: Projeyi katmanlara bölmek ve kodu düzenli tutmak için kullanılan bir mimari yaklaşım. Core, Data Access Layer (Veri Erişim Katmanı) ve Entity Layer (Entity Katmanı) gibi katmanlar içerir.

- **ADO.NET**: Veritabanı işlemlerini yürütmek için kullanılan bir teknoloji. Özellikle özelleştirilmiş veritabanı işlemleri gerektiren durumlarda kullanışlıdır.

## Proje Katmanları

Projede kullanılan katmanlar şunlardır:

### Core Katmanı

- **Core Katmanı Nedir?**:
  Üst katmanlara geçiş için temel yapıyı sağlayan katmandır.

- **İçeriği**:
  - **Business Logic Layer Dosyası**: İş mantığını içeren sınıfları içerir.
  - **Data Access Layer Dosyası**: Veritabanı işlemlerini yöneten sınıfları içerir.
  - **Entity Dosyası**: Ortak özellikleri içeren entity sınıflarını içerir.

### Data Access Layer (Veri Erişim Katmanı)

Data Access Layer, projenin veritabanı işlemlerini yönettiği katmandır. Bu katmanda bulunan `DbContext` dosyası, veritabanı bağlantısını ve veri tablolarını temsil eder. Bu sayede Entity Framework Core'un sağladığı Migration işlemleri ile veritabanını güncellemek mümkün olur.

Data Access Layer içinde iki önemli dosya bulunur:

- **Abstract Dosyası**: Her bir veritabanı tablosuna karşılık gelen temel CRUD (Create, Read, Update, Delete) işlemlerinin arayüzlerini içerir. Bu arayüzler, Core Katmanı'nda bulunan Data Access Layer Dosyası'ndaki `IRepository` arayüzünden türetilir. Böylece tüm tablo işlemleri için temel CRUD işlemleri otomatik olarak gelir.

- **Concrete Dosyası**: Veritabanı işlemlerini gerçekleştiren sınıfları içerir. Her bir tabloya karşılık gelen sınıflar, burada kullanılan teknolojiye göre uyarlanır ve işlemler bu sınıflar üzerinden yürütülür.

- **Mapping Dosyası**: Veritabanı tabloları ile .NET entity sınıfları arasındaki ilişkiyi tanımlayan dosyadır. Bu dosyada, her bir tablonun alanları ile .NET property'leri arasındaki eşleştirmeler bulunur. Bu sayede veri çekme ve kaydetme işlemleri sorunsuz bir şekilde gerçekleştirilir.

Bu yapı sayesinde, projede birden fazla veritabanı teknolojisi kullanılabilmesi için çoklu teknoloji desteği sağlanır. Veritabanı işlemleri temel CRUD işlemleri ile sınırlı kalmaz, özelleştirilmiş işlemler de bu katmanda yönetilir.

## Lisans

Bu proje Ücretsiz olarak kullanıma sunulmuştur.
