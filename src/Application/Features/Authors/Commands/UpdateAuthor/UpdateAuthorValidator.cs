using System.Data;
using FluentValidation;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdateAuthorValidator: AbstractValidator<UpdateAuthorCommand>
{
    public UpdateAuthorValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x => x.FirstName).NotNull().NotEmpty();
        RuleFor(x => x.LastName).NotNull().NotEmpty();
    }
}