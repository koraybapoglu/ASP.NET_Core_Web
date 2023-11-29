# Kullanıcıdan Veri Alma Yöntemleri - QueryString Üzerinden Veri Alma

QueryString, URL'nin sonundaki parametreleri ve değerleri taşıyan yapıdır. Genellikle güvenlik gerektirmeyen bilgilerin URL üzerinde iletilmesinde kullanılır.

Örnek bir URL:

https://www.webadresi.com/sehir/ankara?ilce=yenimahalle


Burada:
- `https://www.webadresi.com/sehir/ankara`: İsteğin genel adresi.
- `?`: URL ile QueryString'in başladığını belirtir.
- `ilce=yenimahalle`: QueryString'de parametre ve değerleri temsil eder.

QueryString, çeşitli istek türleriyle (GET, POST vb.) gönderilen verileri içerebilir. Güvenlik gerektirmeyen ve açıkça görüntülenen bilgiler, URL üzerinde QueryString ile aktarılabilir.

Bu yöntem, genellikle kullanıcıdan gelen parametreleri almak veya belirli bir sayfaya veya içeriğe yönlendirme yaparken belirli verileri taşımak için kullanılır. Özellikle kullanıcının seçtiği filtreleme, arama veya sıralama parametreleri gibi bilgiler URL üzerinden QueryString ile geçirilebilir.
