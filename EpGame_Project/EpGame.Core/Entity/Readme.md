# BaseEntity (Temel Varlık Sınıfı)

BaseEntity, diğer varlık (entity) sınıflarının temelini oluşturan bir sınıftır ve genellikle her varlık sınıfında ortak olan özellikleri (kolonları) içerir. Bu sınıf, genellikle veritabanı tablolarındaki ID, Active (Aktiflik Durumu), CreatedTime (Oluşturulma Zamanı), ve UpdatedTime (Güncelleme Zamanı) gibi temel özellikleri içerir.
Özellikler (Properties)

    ID: Varlığın benzersiz kimlik numarasını temsil eden bir tamsayıdır. Genellikle bir veritabanı tablosunun anahtar sütunu olarak kullanılır.

    Active: Varlığın aktif olup olmadığını belirten bir mantıksal (boolean) değerdir. Bu özellik, genellikle bir varlığın silinmediğini veya devre dışı bırakılmadığını göstermek için kullanılır.

    CreatedTime: Varlığın oluşturulma zamanını temsil eden bir DateTime türündeki değerdir. Bu özellik, bir varlığın ne zaman oluşturulduğunu izlemek için kullanılır.

    UpdatedTime: Varlığın son güncelleme zamanını temsil eden bir DateTime türündeki değerdir. Bu özellik, bir varlığın ne zaman güncellendiğini izlemek için kullanılır.

## Kullanım

BaseEntity sınıfı, diğer varlık sınıflarının temel sınıfı olarak kullanılır. Örneğin, aşağıdaki gibi bir varlık sınıfı tanımlanabilir:

```csharp
using EpGame.Core.Entity;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
