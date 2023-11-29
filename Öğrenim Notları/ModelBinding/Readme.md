
# Model Binding Nedir?

ASP.NET Core'da Model Binding, web formlarından gelen kullanıcı verilerinin Controller'a parametre olarak bağlanması işlemidir. Bu, HTTP istekleriyle gelen verilerin, bir model sınıfına otomatik olarak eşlenerek, Controller Action'larına iletilmesini sağlar.

## Nasıl Çalışır?

Örneğin, kullanıcı bir form doldurur ve gönder butonuna basar. Bu, ilgili Controller Action'ını tetikler. Action içinde beklenen model sınıfı parametresi, form alanlarındaki verilerle otomatik olarak eşleşir.

public class UserController : Controller
{
    public IActionResult Register(UserModel user)
    {
        // UserModel, formdaki alanlarla eşlenerek Model Binding işlemi gerçekleşir
        // ...
    }
}

## Avantajları

    Tekrar Kodu Azaltır: Form verilerini elle almaktansa, Model Binding ile otomatik olarak bağlanır, kod tekrarını önler.
    Veri Doğruluğunu Sağlar: Form alanlarından gelen veriler, modelin özelliklerine uygunsa otomatik olarak atanır.
    Esnek ve Güvenli: Farklı veri tiplerini dönüştürme yeteneği sayesinde, verilerin doğru formatta işlenmesini sağlar.

## Kullanımı

    Form alanları, Controller Action'ının beklentiği model sınıfının özellikleriyle uyumlu olmalıdır.
    Model sınıfı, Controller Action'ının parametresi olarak kullanılır ve Model Binding işlemi otomatik olarak gerçekleşir.

Model Binding, formdaki verilerin doğrudan model sınıfına bağlanmasını sağlayarak, veri işleme sürecini kolaylaştırır ve kod temizliğini artırır.