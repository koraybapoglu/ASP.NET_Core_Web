using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name ="Ad")]
        [StringLength(50,ErrorMessage ="Max 50 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
