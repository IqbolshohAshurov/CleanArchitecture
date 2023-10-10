using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreateLanguageCommandHandler: IRequestHandler<CreateLanguageCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public CreateLanguageCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<bool> Handle(CreateLanguageCommand command, CancellationToken ct)
    {
        if(command is null)
            return false;

        var language = _mapper.Map<Language>(command);
        _context.Languages.Add(language);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new CreatedLanguageEvent(language));
        
        return true;
    }
}