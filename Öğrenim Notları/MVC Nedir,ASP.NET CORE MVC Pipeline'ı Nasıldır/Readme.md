# MVC Nedir? (Model-View-Controller)

MVC, birbirinden bağımsız üç katmanı esas alan bir mimari desendir. Microsoft, bu desen üzerine oturtulmuş ASP.NET Core MVC mimarisini geliştirmiştir.

## Model Nedir?

İşlenecek olan veriyi temsil eden katmandır. Genellikle veritabanı işlemlerinin yapıldığı katman olarak düşünülebilir.

## View Nedir?

İsteğe bağlı olarak elde edilen verileri görselleştiren, görüntüleyen katmandır. HTML, CSS, JavaScript, Razor, resim, müzik, video gibi görsel çıktıları sağlar.

## Controller Nedir?

Gelen istekleri karşılayan ve içeriğine göre gerekli model işlemlerini üstlenen katmandır. Algoritmaları, servisleri, veritabanını vb. çağırarak, istenilen veriyi üretmekten ve bu veriyi view ile görselleştirmekten sorumludur.

### Nasıl Çalışır?

Web ortamında, kullanıcı (client) bir istekte bulunur ve bu istek Controller kısmına yönlendirilir. Eğer veritabanına ihtiyaç varsa veya veriler dış kaynaklardan alınacaksa ya da bir model kullanılacaksa, istek Model kısmına yönlendirilir.

Bu istek sonucunda elde edilen veriler Controller tarafına yönlendirilir. Eğer bu veriler kullanıcıya yönlendirilecekse, Controller View kısmına verileri gönderir.

View'den gelen sonuç tekrar Controller'a gönderilir ve Controller'dan kullanıcıya gönderim sağlanır.

Eğer bir veritabanına ihtiyaç yoksa, veriler dış kaynaklardan alınmayacaksa ya da bir model kullanılmayacaksa, Controller Model kısmına gitmez.

Eğer bir görüntü döndürmeye ihtiyaç yoksa, Controller View kısmına gitmez.

---

Bu README dosyası, Model-View-Controller (MVC) yapısını ve web ortamında nasıl çalıştığını genel hatlarıyla açıklamaktadır. MVC'nin çalışma prensipleri ve katmanları hakkında detaylı bilgi edinmek için projenizdeki uygulamayı inceleyebilirsiniz.
