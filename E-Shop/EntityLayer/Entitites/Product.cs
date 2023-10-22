using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Stok")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Popüler")]
        public bool Popular { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Onay")]
        public bool IsApproved { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Resim")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Adet")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
