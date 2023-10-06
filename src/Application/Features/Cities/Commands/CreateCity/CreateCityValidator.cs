using System.Data;
using FluentValidation;

namespace Application.Features.Cities.Commands.CreateCity;

public class CreateCityValidator: AbstractValidator<CreateCityCommand>
{
    public CreateCityValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(50);
    }
}