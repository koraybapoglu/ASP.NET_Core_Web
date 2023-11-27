# ASP.NET Core MVC - ViewModel ve Tuple ile Veri Gönderimi

Bu projede, ASP.NET Core MVC kullanarak Controller'dan View'e veri aktarımı yapmak için ViewModel ve Tuple kullanımını içermektedir.

## ViewModel ile Veri Gönderimi

ViewModel, Controller ve View arasında veri taşıma işlemi için özel olarak oluşturulan bir modeldir. 

- **Controller**
    - `UserProductViewModel` adında bir ViewModel sınıfı oluşturulur.
    - Controller içinde ViewModel oluşturulur ve View'e gönderilir.
  
- **View**
    - `@model OrnekProje.Models.ViewModel.UserProductViewModel` ile ViewModel belirtilir.
    - ViewModel içindeki verilere `Model.PropertyName` kullanarak erişilir.

## Tuple ile Veri Gönderimi

Tuple, farklı tipteki verileri tek bir yapıda taşımak için kullanılır.

- **Controller**
    - `Tuple` kullanarak farklı veri türlerini birleştirir ve View'e gönderir.
  
- **View**
    - Tuple'dan gelen verilere, `@Model.Item1` ve `@Model.Item2` ile erişilir.

ViewModel, tip güvenliği sağlar ve kodun anlaşılabilirliğini artırırken, Tuple daha basit senaryolar için tercih edilebilir.

