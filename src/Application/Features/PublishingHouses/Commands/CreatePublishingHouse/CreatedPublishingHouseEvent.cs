using Domain.Entities;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatedPublishingHouseEvent: INotification
{
    public CreatedPublishingHouseEvent() { }

    public CreatedPublishingHouseEvent(PublishingHouse publishingHouse)
    {
        PublishingHouse = publishingHouse;
    }

    public PublishingHouse PublishingHouse { get; set; }
}