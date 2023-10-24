using System.Runtime.InteropServices.ComTypes;
using Application.Common.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatePublishingHouseCommandHandler: IRequestHandler<UpdatePublishingHouseCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UpdatePublishingHouseCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<bool> Handle(UpdatePublishingHouseCommand command, CancellationToken ct)
    {
        if(command is null)
            return false;
        
        var publishingHouse = await _context.PublishingHouses
            .FirstOrDefaultAsync(x => x.Id == command.Id);
        _mapper.Map(command, publishingHouse);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new UpdatedPublishingHouseEvent(publishingHouse), ct);
        
        return true;
    }
}