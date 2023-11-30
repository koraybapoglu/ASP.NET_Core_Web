# Veri Doğrulama (Validations)

 ## Validations Nedir?

Veri doğrulaması (validations), gelen her verinin doğrudan içeri alınmaması, öncesinde belirli şartlara uygunluğunun kontrol edilmesi anlamına gelir. Bu doğrulama işlemi sonrasında veri içeri alınır.
Tanımı

Validation, bir değerin belirli şartlara uygun olup olmadığının kontrol edilmesidir. Bu kontroller, belirli koşullara ve amaçlara uygunluğun kontrol edilmesini içerir. Verinin, belirlenen koşullara uygun olup olmadığının kontrol edilmesi ve işleme tabi tutulması bu süreci oluşturur.
Validations Türleri

    Client Side Validation: Kullanıcı arayüzünde, istemci tarafında gerçekleştirilen doğrulama işlemleridir.
    Server Side Validation: Sunucu tarafında, sunucu uygulamasında gerçekleştirilen doğrulama işlemleridir.

## Önemi

Validation, hem istemci hem de sunucu tarafında paralel olarak uygulanmalıdır. Bu işlem, veri bütünlüğünü sağlar ve güvenliği artırır.

## Data Annotations Kullanımı

Validation işlemleri için, controller kısmında teker teker bütün propertylere validasyon işlemleri yazmak karmaşık ve maliyetli olabilir. Bunun yerine, validasyon işlemlerinin modelde data annotations kullanılarak yapılması daha tercih edilebilir.

## Nasıl Kullanılır?

Bu proje, veri doğrulama işlemlerinin modelde data annotations kullanılarak gerçekleştirildiği bir örnek içerir. Model sınıflarında ilgili property'ler için data annotations kullanarak, gelen verilerin kontrol edilmesi ve uygunluk durumunun sağlanması sağlanmıştır.
Kullanılan Teknolojiler

    ASP.NET Core
    Data Annotations
    Veri Doğrulama Mekanizmaları