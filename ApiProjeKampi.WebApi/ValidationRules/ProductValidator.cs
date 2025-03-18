using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Lütfen Ürün Adını Boş Geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("2 karakter girişi yapın");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("50 karakter girişi yapınız");

            RuleFor(x=>x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").LessThan(0).WithMessage("Ürün fiyatı negatif olamaz").GreaterThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz , değeri kontrol edin");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez");
        }

    }
}
