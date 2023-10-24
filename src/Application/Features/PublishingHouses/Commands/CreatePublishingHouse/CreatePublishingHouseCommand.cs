using MediatR;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatePublishingHouseCommand: IRequest<bool>
{
    public CreatePublishingHouseCommand() { }

    public CreatePublishingHouseCommand(string name, Guid cityId)
    {
        Name = name;
        CityId = cityId;
    }

    public string Name { get; set; }
    
    public Guid CityId { get; set; }
}