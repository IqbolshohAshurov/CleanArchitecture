using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Commands.DeleteBook;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;

    public DeleteBookCommandHandler(IApplicationDbContext context, IMediator mediator)
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<bool> Handle(DeleteBookCommand command, CancellationToken ct)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        if (book is null)
            return false;
        
        _context.Books.Remove(book);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new DeletedBookEvent(book), ct);

        return true;
    }
}