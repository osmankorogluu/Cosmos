using Cosmos.Application.ViewModels.Books;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Application.Validators.Categories
{
    public class CreateCategoryValidator:AbstractValidator<CreateBook>
    {
        public CreateCategoryValidator()
        {
            RuleFor(b => b.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen Kategori adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(3)
                .WithMessage("Lütfen Kategori adını 3 ile 150 karakter arasında giriniz.");
        }
    }
}
