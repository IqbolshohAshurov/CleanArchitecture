using Application.Common.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdateLanguageCommandHandler: IRequestHandler<UpdateLanguageCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UpdateLanguageCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task<bool> Handle(UpdateLanguageCommand command, CancellationToken ct)
    {
        if(command is null)
            return false;

        var language = await _context.Languages.FirstOrDefaultAsync(x => x.Id == command.Id, ct);

        _mapper.Map(command, language);

        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new UpdatedLanguageEvent(language), ct);

        return true;
    }
}