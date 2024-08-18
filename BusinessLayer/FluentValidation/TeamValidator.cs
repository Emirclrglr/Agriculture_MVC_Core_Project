using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            // Rule for name
            RuleFor(x=>x.PersonName).NotEmpty().WithMessage("Personel Adı ve Soyadı Boş Geçilemez");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Personel Adı ve Soyadı Minimum 5 Karakter İçermek Zorundadır");

            // Rule For Title
            RuleFor(x => x.PersonTitle).NotEmpty().WithMessage("Personel Unvanı Boş Geçilemez");
            RuleFor(x => x.PersonTitle).MinimumLength(3).WithMessage("Personel Unvanı Minimum 3 Karakter İçermek Zorundadır");

            // Rule For Image
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolu Boş Geçilemez");
            

        }
    }
}
