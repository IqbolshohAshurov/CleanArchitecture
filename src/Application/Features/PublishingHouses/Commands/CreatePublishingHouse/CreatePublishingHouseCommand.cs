using MediatR;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatePublishingHouseCommand: IRequest<bool>
{
    public string Name { get; set; }
    
    public Guid CityId { get; set; }

    public CreatePublishingHouseCommand()
    {
        
    }

    public CreatePublishingHouseCommand(string name, Guid cityId)
    {
        Name = name;
        CityId = cityId;
    }
}