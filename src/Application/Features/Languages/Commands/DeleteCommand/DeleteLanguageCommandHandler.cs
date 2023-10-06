using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Application.Features.Languages.Commands.DeleteCommand;

public class DeleteLanguageCommandHandler: IRequestHandler<DeleteLanguageCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;

    public DeleteLanguageCommandHandler(
        IApplicationDbContext context,
        IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<bool> Handle(DeleteLanguageCommand command, CancellationToken ct)
    {
        var language = await _context.Languages.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        if (language is null)
            return false;

        _context.Languages.Remove(language);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new DeletedLanguageEvent(language), ct);

        return true;
    }
}