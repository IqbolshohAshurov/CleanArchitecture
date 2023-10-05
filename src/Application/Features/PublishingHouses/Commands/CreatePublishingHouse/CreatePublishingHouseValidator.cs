using FluentValidation;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatePublishingHouseValidator: AbstractValidator<CreatePublishingHouseCommand>
{
    public CreatePublishingHouseValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(50);
    }
}