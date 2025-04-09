using ApiProjectCamp.WebApi.Entities;
using FluentValidation;

namespace ApiProjectCamp.WebApi.ValidationRulers
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Ürün adı boş geçilemez.")
                .MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapınız.")
                .MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapılmalıdır.");

            RuleFor(x => x.ProductPrice)
                .NotEmpty().WithMessage("Ürün fiyatı boş geçilemez")
                .GreaterThan(0).WithMessage("Ürün Fiyatı Negatif olamaz")
                .LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz");

            RuleFor(x => x.ProductDescription)
                .NotEmpty().WithMessage("Ürün açıklaması boş geçilemez.");
                
        }
    }
}
