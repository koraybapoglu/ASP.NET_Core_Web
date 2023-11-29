# Kullanıcıdan Veri Alma Yöntemleri - Form Üzerinden Veri Alma

Kullanıcıdan veri almak için çeşitli yöntemler vardır ve bunlar ASP.NET Core MVC içinde kullanılabilir. Formlar aracılığıyla veri almak için farklı parametre türleri ve yöntemler kullanılabilir:
## IFormCollection Kullanımı


[HttpPost]
public IActionResult CreateProduct(IFormCollection datas)
{
    var value1 = datas["txtValue1"].ToString();
    var value2 = datas["txtValue2"].ToString();
    var value3 = datas["txtValue3"].ToString();

    // Verileri kullanarak işlemler yapılabilir
    return View();
}

## String Parametreleri ile Veri Alma


[HttpPost]
public IActionResult CreateProduct(string txtValue1, string txtValue2, string txtValue3)
{
    // Verileri kullanarak işlemler yapılabilir
    return View();
}

## Nesne Parametresi ile Veri Alma

public class Product
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}

[HttpPost]
public IActionResult CreateProduct(Product product)
{
    // product nesnesi içindeki verileri kullanarak işlemler yapılabilir
    return View();
}

## TagHelpers ile Form Oluşturma

html

<form asp-action="CreateProduct" asp-controller="Product" method="post">
    <input type="text" name="txtValue1" />
    <br />
    <input type="text" name="txtValue2" />
    <br />
    <input type="text" name="txtValue3" />
    <br />
    <button>Gönder</button>
</form>

veya

html

@model OrnekProje.Models.Product

<form asp-action="CreateProduct" asp-controller="Product" method="post">
    <input asp-for="ProductName" type="text" />
    <br />
    <input asp-for="Quantity" type="text" />
    <br />
    <button>Gönder</button>
</form>

Bu yöntemlerden herhangi biri, kullanıcının gönderdiği verileri Controller'da yakalamak ve işlemek için kullanılabilir. İhtiyaca ve tercihe bağlı olarak farklı yöntemler kullanılabilir.