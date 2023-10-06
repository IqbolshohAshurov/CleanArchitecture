using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Cities.Commands.UpdateCity;

public class UpdateCityValidator: AbstractValidator<UpdateCityCommand>
{
    public UpdateCityValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x => x.Name).NotNull().NotEmpty();
    }
}