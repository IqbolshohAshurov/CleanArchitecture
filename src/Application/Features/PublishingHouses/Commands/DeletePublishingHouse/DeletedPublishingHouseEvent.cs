using Domain.Entities;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.DeletePublishingHouse;

public class DeletedPublishingHouseEvent: INotification
{
    public DeletedPublishingHouseEvent() { }
 
    public DeletedPublishingHouseEvent(PublishingHouse publishingHouse)
    {
        PublishingHouse = publishingHouse;
    }

    public PublishingHouse PublishingHouse { get; set; }
}