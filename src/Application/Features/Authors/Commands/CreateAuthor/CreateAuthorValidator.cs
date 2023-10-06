using FluentValidation;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreateAuthorValidator: AbstractValidator<CreateAuthorCommand>
{
    public CreateAuthorValidator()
    {
        RuleFor(x => x.FirstName).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.LastName).NotNull().NotEmpty().MaximumLength(30);
    }
}