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
    private readonly IValidator<CreateLanguageCommand> _validator;

    public CreateLanguageCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<CreateLanguageCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<bool> Handle(CreateLanguageCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid)
            return false;

        var language = _mapper.Map<Language>(command);
        _context.Languages.Add(language);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new CreatedLanguageEvent(language));
        
        return true;
    }
}