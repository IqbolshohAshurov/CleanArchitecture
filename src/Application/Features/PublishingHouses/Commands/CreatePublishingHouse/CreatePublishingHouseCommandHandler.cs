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
    private readonly IValidator<CreatePublishingHouseCommand> _validator;

    public CreatePublishingHouseCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<CreatePublishingHouseCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<bool> Handle(CreatePublishingHouseCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid) 
            return false;

        var publishingHouse = _mapper.Map<PublishingHouse>(command);
        _context.PublishingHouses.Add(publishingHouse);
        await _context.SaveChangeAsync(ct);

        await _mediator.Publish(new CreatedPublishingHouseEvent(), ct);
        
        return true;
    }
}