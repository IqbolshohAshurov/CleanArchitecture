using Domain.Entities;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatedPublishingHouseEvent: INotification
{
    public PublishingHouse PubishingHouse { get; set; }

    public UpdatedPublishingHouseEvent()
    {
        
    }

    public UpdatedPublishingHouseEvent(PublishingHouse pubishingHouse)
    {
        PubishingHouse = pubishingHouse;
    }
}