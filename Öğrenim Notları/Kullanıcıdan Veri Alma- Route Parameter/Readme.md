# Kullanıcıdan Veri Alma Yöntemleri - Route Parameter Üzerinden Veri Alma

Route parametreleri, URL'nin belirli bir bölümünde bulunan ve sunucuya gönderilen bilgileri temsil eder. Bu parametreler, URL yapısına gömülüdür ve genellikle belirli bir sayfaya veya içeriğe doğrudan erişim sağlar.

Örnek bir route parametresi içeren URL:

/user/max


Bu URL'de `max`, `/user/` bölümünde bulunan bir parametre olarak adlandırılır. Route parametreleri, QueryString'den farklı olarak URL yapısına gömülü oldukları için daha gizlidir ve açıkça görüntülenmezler.

Route parametreleri, genellikle sunucuya belirli bir kaynağa erişim talep ederken kullanılır. Örneğin, bir kullanıcı adı gibi belirli bir kaynak için talepte bulunulurken URL içindeki bu parametreler kullanılabilir. Özellikle URL yapısını daha temiz ve anlaşılır hale getirmek, aynı zamanda sunucu tarafında istenilen kaynağa doğrudan erişimi kolaylaştırmak için route parametreleri tercih edilebilir.

QueryString ile Route Parameter arasındaki fark, QueryString'de verilerin da