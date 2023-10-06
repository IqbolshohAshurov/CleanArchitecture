using FluentValidation;

namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatePublishingHouseValidator: AbstractValidator<UpdatePublishingHouseCommand>
{
    public UpdatePublishingHouseValidator()
    {
        RuleFor(x => x.Id).NotNull().NotEmpty();
        RuleFor(x => x.CityId).NotNull().NotEmpty();
        RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(50);
    }
}