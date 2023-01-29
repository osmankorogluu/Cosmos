using Cosmos.Application.ViewModels.Books;
using Cosmos.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Application.Validators.Books
{
    public class CreateBookValidator: AbstractValidator<CreateBook>
    {
        public CreateBookValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen kitap adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(3)
                .WithMessage("Lütfen kitap adını 3 ile 150 karakter arasında giriniz.");
            RuleFor(b => b.Writer)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen yazar adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(3)
                .WithMessage("Lütfen yazar adını 3 ile 150 karakter arasında giriniz.");

            RuleFor(b => b.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Kitap Fiyatını Boş Geçmeyiniz")
                .Must(b => b >= 0)
                .WithMessage("Fiyat Bilgisi negatif olmaz");

            RuleFor(b => b.NumberPages)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Kitap sayfasını Boş Geçmeyiniz")
                .Must(b => b >= 0)
                .WithMessage("kitap sayfa sayısı negatif olmaz");

             RuleFor(b => b.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Stok bilgisini boş geçmeyiniz")
                .Must(b => b >= 0)
                .WithMessage("Stok bilgisi negatif olmaz");
        }
    }
}
