using Application.Common.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Genres.Commands.DeleteGenre;

public class DeleteGenreCommandHandler: IRequestHandler<DeleteGenreCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;

    public DeleteGenreCommandHandler(
        IApplicationDbContext context,
        IMediator mediator
        )
    {
        _context = context;
        _mediator = mediator;
    }

    public async Task<bool> Handle(DeleteGenreCommand command, CancellationToken ct)
    {
        var genre = await _context.Genres.FirstOrDefaultAsync(x => x.Id == command.Id, ct);

        if (genre == null)
            return false;

        _context.Genres.Remove(genre);
        _context.SaveChangeAsync(ct);

        await _mediator.Publish(new DeletedGenreEvent(genre), ct);
        return true;
        
        
    }
}