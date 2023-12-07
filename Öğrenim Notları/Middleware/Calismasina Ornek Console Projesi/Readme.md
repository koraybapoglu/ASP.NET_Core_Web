# Middleware Çalışma Örneği

Bu basit C# programı, bir middleware zinciri mantığını göstermek için oluşturulmuştur. Program, `Middleware1`, `Middleware2` ve `Middleware3` adında üç farklı işlevi olan basit middleware'leri simüle eder.

## Nasıl Çalışır?

Bu program, bir kullanıcı isteği (User Request) simüle etmektedir. İstek geldiğinde, `Middleware1` ilk olarak devreye girer. Ardından, işlem adımları şu şekilde gerçekleşir:

1. Kullanıcı talebi (User Request) ortaya çıkar.
2. `Middleware1` işlemlerine başlar ve "Request Geldi" bildirimini gösterir.
3. `Middleware1` işlemi tamamlanmadan önce `Middleware2` tetiklenir.
4. `Middleware2` işlemleri başlar ve ardından `Middleware3`'ü tetikler.
5. `Middleware3` işlemleri tamamlanır ve `Middleware2`'ye geri döner.
6. `Middleware2` işlemleri tamamlanır.
7. `Middleware1` işlemi tamamlanır ve son olarak "Response Döndürüldü !" bildirimi yapılır.

Bu sıra, bir middleware zincirini simüle eder. Her bir middleware, işlem adımlarını sırayla gerçekleştirir ve bir sonraki adıma geçmeden önce önceki middleware'in işlemlerini tamamlar.

Bu basit örnek, middleware kavramını ve işlevini daha iyi anlamak için bir simülasyon sunmaktadır.

<img src="https://github.com/koraybapoglu/ASP.NET_Core_Web/tree/main/%C3%96%C4%9Frenim%20Notlar%C4%B1/Middleware/Calismasina%20Ornek%20Console%20Projesi/img.png" alt="alt text" width="320" height="180">