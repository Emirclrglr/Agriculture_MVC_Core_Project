using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class GalleryValidator : AbstractValidator<Gallery>
    {
        public GalleryValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel Açıklamasını Boş Geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Yolunu Boş Geçemezsiniz");

            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Başlık En Fazla 30 Karakter İçerebilir");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Başlık En Az 8 Karakter İçermelidir");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Açıklama En Fazla 50 Karakter İçerebilir");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Açıklama En Az 20 Karakter İçermelidir");
        }
    }
}
