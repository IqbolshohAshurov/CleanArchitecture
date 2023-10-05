using MediatR;

namespace Application.Features.PublishingHouses.Commands.DeletePublishingHouse;

public class DeletePublishingHouseCommand: IRequest<bool>
{
    public Guid Id { get; set; }

    public DeletePublishingHouseCommand()
    {
        
    }

    public DeletePublishingHouseCommand(Guid id)
    {
        this.Id = id;
    }
}