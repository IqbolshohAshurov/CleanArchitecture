using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.Cities.Commands.CreateCity;

public class CreateCityCommandHandler: IRequestHandler<CreateCityCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public CreateCityCommandHandler(
        IApplicationDbContext context,
        IMapper mapper,
        IMediator mediator)
    {
        _context = context;
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<bool> Handle(CreateCityCommand command, CancellationToken ct)
    {
        if (command is null)
            return false;
        
        var city = _mapper.Map<City>(command);
        _context.Cities.Add(city);
        await _context.SaveChangeAsync(ct);

        await _mediator.Publish(new CreatedCityEvent(city));
        return true;
    }
}