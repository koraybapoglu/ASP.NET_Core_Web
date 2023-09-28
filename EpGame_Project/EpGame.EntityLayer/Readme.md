# EpGame.Entity Katmanı

Bu README dosyası, `EpGame.Entity` katmanında bulunan yapıları ve bu katmandaki Entity sınıflarının kullanımını açıklar. `EpGame.Entity` katmanı, veritabanı tablolarına karşılık gelen varlık (entity) sınıflarını içerir.

## Entities Dosyası

`Entities` dosyası, veritabanında her bir tabloya karşılık gelen C# sınıflarını içerir. Bu sınıflar, tablo alanlarını ve ilişkileri temsil eder. Ayrıca, bu sınıflar genellikle `EpGame.Core.Entity` katmanındaki `BaseEntity` sınıfından kalıtım alır. Bu sayede ortak alanlar, her sınıf için ayrı ayrı yazılmaz.

## BaseEntity Sınıfı

`BaseEntity` sınıfı, tüm Entity sınıflarının ortak özelliklerini içerir. Bu özellikler, genellikle her varlıkta (entity) bulunan alanlar olan ID, aktif durumu, oluşturma tarihini ve güncelleme tarihini temsil eder. `BaseEntity` sınıfı `EpGame.Core` katmanında bulunmaktadır.

Bu README dosyası, `EpGame.Entity` katmanındaki Entity sınıflarının ve `BaseEntity` sınıfının yapısını ve kullanımını özetlemektedir. Projeye özgü ihtiyaçlarınıza göre bu açıklamaları düzenleyebilirsiniz.
