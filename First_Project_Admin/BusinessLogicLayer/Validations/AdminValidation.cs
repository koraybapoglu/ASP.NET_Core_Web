using Admin.DataAccesLayer;
using Admin.EntityLayer.POCO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BusinessLogicLayer.Validations
{
    public class AdminValidation : AbstractValidator<Admins>
    {
        IAdminDAL DaL;
        public AdminValidation(IAdminDAL DAL)
        {
            RuleFor(x => x.ID).NotNull().WithMessage("ID Alanı Boş Geçilemez.");
            RuleFor(x => x.UserName).NotNull().WithMessage("Kullanıcı Adı Boş Geçilemez.");
            RuleFor(x => x.Password).NotNull().WithMessage("Parola Alanı Boş Geçilemez");
            DaL = DAL;
        }
    }
}
