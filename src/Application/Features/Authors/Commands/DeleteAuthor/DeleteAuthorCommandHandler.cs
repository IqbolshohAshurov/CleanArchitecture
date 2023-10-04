using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Authors.Commands.DeleteAuthor;

public class DeleteAuthorCommandHandler: IRequestHandler<DeleteAuthorCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;

    public DeleteAuthorCommandHandler(
        IApplicationDbContext context,
        IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<bool> Handle(DeleteAuthorCommand command, CancellationToken ct)
    {
        var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        if (author is null)
            
            return false;
        _context.Authors.Remove(author);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new DeletedAuthorEvent(), ct);
        
        return true;
    }
}