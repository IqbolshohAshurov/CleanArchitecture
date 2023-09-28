using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Commands.DeleteBook;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public DeleteBookCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteBookCommand command, CancellationToken ct)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        if (book is null)
            return false;
        
        _context.Books.Remove(book);
        await _context.SaveChangeAsync(ct);
        return true;
    }
}