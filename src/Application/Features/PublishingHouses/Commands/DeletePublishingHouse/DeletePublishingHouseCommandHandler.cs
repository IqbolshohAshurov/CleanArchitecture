using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.PublishingHouses.Commands.DeletePublishingHouse;

public class DeletePublishingHouseCommandHandler: IRequestHandler<DeletePublishingHouseCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;

    public DeletePublishingHouseCommandHandler(
        IApplicationDbContext context,
        IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<bool> Handle(DeletePublishingHouseCommand command, CancellationToken ct)
    {
        var publishingHouse = await _context.PublishingHouses.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        
        if(publishingHouse.Id == null)
            return false;
        
        _context.PublishingHouses.Remove(publishingHouse);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new DeletedPublishingHouseEvent(), ct);
        return true;
        
    } 
}