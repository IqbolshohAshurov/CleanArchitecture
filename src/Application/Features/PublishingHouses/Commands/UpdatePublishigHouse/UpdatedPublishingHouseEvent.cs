using Domain.Entities;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatedPublishingHouseEvent: INotification
{
    public UpdatedPublishingHouseEvent() { }
    public UpdatedPublishingHouseEvent(PublishingHouse pubishingHouse)
    {
        PubishingHouse = pubishingHouse;
    }

    public PublishingHouse PubishingHouse { get; set; }
}