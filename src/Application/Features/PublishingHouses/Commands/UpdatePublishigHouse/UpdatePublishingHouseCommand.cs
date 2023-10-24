using MediatR;

namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatePublishingHouseCommand: IRequest<bool>
{
    public UpdatePublishingHouseCommand() { }

    public UpdatePublishingHouseCommand(Guid id, string name, Guid cityId)
    {
        Id = id;
        Name = name;
        CityId = cityId;
    }

    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public Guid CityId { get; set; }
}