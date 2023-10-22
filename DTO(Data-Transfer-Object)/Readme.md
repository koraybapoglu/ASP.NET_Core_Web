# DTO (Data Transfer Object) Nedir?

DTO, "Data Transfer Object" kavramının kısaltmasıdır ve yazılım geliştirmenin bir parçası olarak sıkça karşılaşılan bir terimdir. Bu belge, DTO'nun ne olduğunu ve nasıl kullanıldığını anlamak için temel bilgiler sunar.

## DTO Nedir?

- **Data Transfer Object (Veri Aktarım Nesnesi)**, verilerin farklı sistemler veya bileşenler arasında iletilmesi veya taşınması için kullanılan bir yapıdır.
- DTO'lar, genellikle veritabanından alınan veya istemcilere gönderilen verileri temsil eder. Bu sayede veri aktarımı ve dönüşümü kolaylaşır.
- Kullanıcı arayüzleri ve veritabanı gibi farklı bileşenler arasında veri taşımanın yanı sıra, API'lerde de sıklıkla kullanılır.

## DTO Kullanmanın Faydaları

1. **Gereksiz Veri Taşınmasını Azaltır**: DTO'lar, yalnızca ihtiyaç duyulan verileri içerir, bu da gereksiz veri aktarımını önler ve ağ trafiğini azaltır.

2. **Veri Dönüşümü ve Biçimlendirme**: Veritabanından alınan veriyi, istemci gereksinimlerine uygun bir şekilde dönüştürmek veya biçimlendirmek için kullanılabilirler.

3. **İstemci ve Sunucu Bağımsızlığı**: DTO'lar, istemci ve sunucu tarafında farklı platformlar ve teknolojiler kullanıldığında bile veri paylaşımını kolaylaştırır.

## Örnek Kullanım

Aşağıda basit bir kullanıcı DTO örneği:

```csharp
public class UserDTO
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}

[HttpGet("users/{userId}")]
public IActionResult GetUser(int userId)
{
    // Kullanıcı verilerini veritabanından alın
    User user = userRepository.GetUserById(userId);

    // UserDTO'ya dönüştürerek istemciye iletilir
    UserDTO userDTO = new UserDTO
    {
        UserId = user.UserId,
        Username = user.Username,
        Email = user.Email,
        Age = user.Age
    };

    return Ok(userDTO);
}
