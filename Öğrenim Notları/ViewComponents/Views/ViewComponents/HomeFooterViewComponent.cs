using Microsoft.AspNetCore.Mvc;
using OrnekProje.Models;

namespace OrnekProje.ViewComponents
{
    public class HomeFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            List<FooterData> data = new List<FooterData> {
            new FooterData { Id=1, Name = "Koray", Surname = "Bapoğlu"},
            new FooterData { Id=2, Name = "Koray2", Surname = "Bapoğlu2"},
            new FooterData { Id=3, Name = "Koray3", Surname = "Bapoğlu3"}
            };
            return View(data);
        }
    }
}
