# ViewStart ve ViewImports Dosyaları

Bu belge, ASP.NET Core MVC projesindeki _ViewStart ve _ViewImports dosyalarının kullanımını açıklar.

## _ViewStart Dosyası

_ViewStart dosyası, tüm view'lerin ortak özelliklerini içeren bir dosyadır. Genellikle Views klasörü altında _ViewStart.cshtml olarak oluşturulur. Temel amacı, tüm view'lerde kullanılacak ortak çalışmaları tanımlamaktır.

Örneğin, layout tanımlaması gibi genel özellikler _ViewStart dosyasında belirtilebilir.

@{
    Layout = "_Layout";
}


Burada _Layout isimli bir layout dosyasının tüm view'lerde kullanılmasını sağlarız.

## _ViewImports Dosyası

_ViewImports dosyası, Razor sayfaları için kütüphane ve namespace tanımlamalarını merkezi bir şekilde yapmamızı sağlar. Views klasörü altında _ViewImports.cshtml olarak oluşturulur.

Örneğin, model tanımlamaları veya tag yardımcılarını (tag helpers) merkezi olarak burada belirtebiliriz.

@using MyProject.Models
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

Yukarıdaki örnek, Models klasöründeki modellere erişimi ve tag helper'ları projenin diğer view'lerinde kullanmayı sağlar.

Bu dosyaları düzenleyerek, proje genelindeki view'lerde ortak tanımlamaları kullanmak ve tekrarı önlemek mümkündür.