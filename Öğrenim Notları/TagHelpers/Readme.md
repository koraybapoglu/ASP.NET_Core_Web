# Tag Helpers

## TagHelper Nedir?

TagHelper'lar, ASP.NET Core ile birlikte gelen yapılar olup HTML işaretlerini daha okunabilir, anlaşılabilir ve geliştirilebilir bir şekilde oluşturmamızı sağlar. Bu yapılar, HTMLHelpers'ların yerine geçer ve viewlerde kod maliyetini azaltarak HTML üretme sürecini kolaylaştırır.

## HtmlHelper ve TagHelper Arasındaki Farklar

- **Maliyet Azaltma**: TagHelper'lar, HTMLHelpers'ların sunucu tarafında HTML nesneleri oluşturmasının getirdiği maliyeti azaltır.
- **Okunabilirlik ve Geliştirilebilirlik**: HtmlHelpers'lar programatik yapılarla çalıştığından, tasarımcıların çalışmasını zorlaştırabilir. TagHelper'lar ise HTML benzeri yapılarıyla daha okunabilir ve tasarımcılar için daha kullanılabilir hale getirir.

## Temel TagHelper Örnekleri

### Form TagHelper

<form asp-action="Index" asp-controller="Product" method="post"></form>

### Input TagHelper

html

<input type="text" asp-for="PropertyName"></input>

### Cache TagHelper

html

<cache>
    Cache=@DateTime.Now
</cache>
<br />
@DateTime.Now

### Partial TagHelper

TagHelper'lar arasında Partial de bulunur ve HTMLHelpers'daki Partial'ın yerine kullanılır.

Bu README dosyası, TagHelper'ların ne olduğunu ve temel örneklerini açıklamaktadır.