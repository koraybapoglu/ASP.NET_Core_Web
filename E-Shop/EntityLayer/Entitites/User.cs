using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Adı")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        [EmailAddress(ErrorMessage ="E-mail formatı şeklinde Giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")] //VALIDATION İSLEMLERİ
        [Display(Name = "Şifre Tekrar")]
        [StringLength(50, ErrorMessage = "Max 50 karakter olmalıdır.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor.")]
        public string RePassword { get; set; }
        [StringLength(50, ErrorMessage = "Max 10 karakter olmalıdır.")]
        public string Role { get; set; }
    }
}
