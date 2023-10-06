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
    private readonly IValidator<UpdatePublishingHouseCommand> _validator;

    public UpdatePublishingHouseCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<UpdatePublishingHouseCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<bool> Handle(UpdatePublishingHouseCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid)
            return false;
        var publishingHouse = await _context.PublishingHouses
            .FirstOrDefaultAsync(x => x.Id == command.Id);
        _mapper.Map(command, publishingHouse);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new UpdatedPublishingHouseEvent(publishingHouse), ct);
        return true;
    }
}