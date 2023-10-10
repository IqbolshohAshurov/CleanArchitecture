using System.Drawing;
using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatePublishingHouseCommandHandler: IRequestHandler<CreatePublishingHouseCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public CreatePublishingHouseCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<bool> Handle(CreatePublishingHouseCommand command, CancellationToken ct)
    {
        if(command is null) 
            return false;

        var publishingHouse = _mapper.Map<PublishingHouse>(command);
        _context.PublishingHouses.Add(publishingHouse);
        await _context.SaveChangeAsync(ct);

        await _mediator.Publish(new CreatedPublishingHouseEvent(publishingHouse), ct);
        
        return true;
    }
}