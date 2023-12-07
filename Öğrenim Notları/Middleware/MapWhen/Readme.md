# MapWhen Metodu

`MapWhen`, ASP.NET Core uygulamalarında gelen isteklerin belirli bir koşulu sağlaması durumunda middleware'leri eklemek için kullanılan bir yöntemdir.

Bu metod, bir lambda ifadesiyle birlikte kullanılır. Bu lambda ifadesi, bir `HttpContext` nesnesini alır ve koşulu değerlendirir. Eğer koşul doğruysa, belirtilen middleware'leri ekler.

`MapWhen`, istek özelliklerine bağlı olarak dinamik bir şekilde middleware'leri eklemek için kullanışlı bir yöntemdir.
