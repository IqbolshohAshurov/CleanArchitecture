using System.Data;
using FluentValidation;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreateLanguageValidator: AbstractValidator<CreateLanguageCommand>
{
    public CreateLanguageValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty();
    }
}