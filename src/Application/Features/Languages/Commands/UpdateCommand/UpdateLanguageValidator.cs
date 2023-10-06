using System.Data;
using FluentValidation;
using MediatR;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdateLanguageValidator: AbstractValidator<UpdateLanguageCommand>
{
    public UpdateLanguageValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x => x.Name).NotNull().NotEmpty();
    }
}