using EntitiyLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("KATEGORİ ADI BOŞ GEÇİLEMEZ");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("KATEGORİ ADI EN AZ 3 KARAKTER OLMALI");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("KATEGORİ ADI 30 KARAKTERDEN FAZLA OLAMAZ");

        }
    }
}
