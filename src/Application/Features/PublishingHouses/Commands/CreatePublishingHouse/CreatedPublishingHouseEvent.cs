using Domain.Entities;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatedPublishingHouseEvent: INotification
{
    public PublishingHouse PublishingHouse { get; set; }

    public CreatedPublishingHouseEvent()
    {
        
    }

    public CreatedPublishingHouseEvent(PublishingHouse publishingHouse)
    {
        PublishingHouse = publishingHouse;
    }
}