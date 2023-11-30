# ModelMetadataType Kullanımı

ModelMetadataType, bir model sınıfının metadata (veri açıklamaları) tanımlarını ayırmak için kullanılan bir özelliktir. Bu özellik, model sınıfının veri doğrulama ve görüntüleme amacıyla kullanılan metadata bilgilerini, ayrı bir metadata sınıfında tutarak kodun daha okunabilir ve yönetilebilir olmasını sağlar.
Amaç

    Model sınıflarının daha düzenli ve okunabilir olmasını sağlamak.
    Veri doğrulama (validation) işlemlerini ve görüntüleme için kullanılan meta verileri ayrı bir sınıfta toplamak.
    Kod tekrarını önlemek ve bakımı kolaylaştırmak.

## Kullanım

ModelMetadataType özelliği, aşağıdaki adımlarla kullanılır:

    Model Sınıfı: Veri modelini temsil eden bir sınıf oluşturulur.

    Metadata Sınıfı: ModelMetadataType özelliği ile model sınıfına ait metadata sınıfı oluşturulur.

    Kullanımı: Model sınıfı üzerinden işlemler yapılırken metadata sınıfındaki doğrulama kuralları ve diğer meta veriler kullanılır.

## Avantajları

    Veri modeli ve metadata ayrı ayrı yönetilir, karmaşıklık azalır.
    Kod tekrarı önlenir, bakım ve geliştirme kolaylaşır.
    Veri doğrulama ve görüntüleme ile ilgili bilgileri tek bir yerden kontrol etmek mümkün olur.

### Kullanılan Teknolojiler

    ASP.NET Core