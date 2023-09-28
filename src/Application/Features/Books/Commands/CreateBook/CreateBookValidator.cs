using FluentValidation;

namespace Application.Features.Books.Commands.CreateBook;

public class CreateBookValidator: AbstractValidator<CreateBookCommand>
{
    public CreateBookValidator()
    {
        RuleFor(b => b.Name).NotNull().NotEmpty();
        RuleFor(b => b.CountPage).NotNull().NotEmpty().LessThanOrEqualTo(10000);
        RuleFor(b => b.Isbn).NotNull().NotEmpty();
    }
}