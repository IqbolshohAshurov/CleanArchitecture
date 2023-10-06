using Domain.Entities;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.DeletePublishingHouse;

public class DeletedPublishingHouseEvent: INotification
{
    public PublishingHouse PublishingHouse { get; set; }

    public DeletedPublishingHouseEvent(PublishingHouse publishingHouse)
    {
        PublishingHouse = publishingHouse;
    }

    public DeletedPublishingHouseEvent()
    {
        
    }
}