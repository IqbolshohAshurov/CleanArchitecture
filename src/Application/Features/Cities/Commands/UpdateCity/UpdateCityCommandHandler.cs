using Application.Common.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Cities.Commands.UpdateCity;

public class UpdateCityCommandHandler: IRequestHandler<UpdateCityCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public UpdateCityCommandHandler(
        IApplicationDbContext context,
        IMapper mapper,
        IMediator mediator)
    {
        _context = context;
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<bool> Handle(UpdateCityCommand command, CancellationToken ct)
    {
        
        var city = await _context.Cities.FirstOrDefaultAsync(x => x.Id == command.Id, ct);

        if (city is null)
            return false;
        
        _mapper.Map(command, city);
        await _context.SaveChangeAsync(ct);
        return true;
    }
}