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
    private readonly IValidator<UpdateCityCommand> _validator;

    public UpdateCityCommandHandler(
        IApplicationDbContext context,
        IMapper mapper,
        IMediator mediator,
        IValidator<UpdateCityCommand> validator)
    {
        _context = context;
        _mapper = mapper;
        _mediator = mediator;
        _validator = validator;
    }

    public async Task<bool> Handle(UpdateCityCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        
        if (!valide.IsValid)
            return false;
        var city = await _context.Cities.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        _mapper.Map(command, city);
        await _context.SaveChangeAsync(ct);
        return true;
    }
}