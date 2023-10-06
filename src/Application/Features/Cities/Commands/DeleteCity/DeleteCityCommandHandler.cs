using System.Data;
using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Cities.Commands.DeleteCity;

public class DeleteCityCommandHandler: IRequestHandler<DeleteCityCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;

    public DeleteCityCommandHandler(
        IApplicationDbContext context,
        IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<bool> Handle(DeleteCityCommand command, CancellationToken ct)
    {
        var city = await _context.Cities.FirstOrDefaultAsync(x => x.Id == command.Id, ct);

        if (city is null)
            return false;

        _context.Cities.Remove(city);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new DeletedCityEvent(city));
        
        return true;
    }
}