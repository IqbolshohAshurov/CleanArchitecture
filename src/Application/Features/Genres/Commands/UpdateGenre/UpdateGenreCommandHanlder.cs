using Application.Common.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Genres.Commands.UpdateGenre;

public class UpdateGenreCommandHanlder: IRequestHandler<UpdateGenreCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public async Task<bool> Handle(UpdateGenreCommand command, CancellationToken ct)
    {
        if(command is null)
            return false;

        var genre = await _context.Genres.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        _mapper.Map(command, genre);
        await _context.SaveChangeAsync(ct);

        await _mediator.Publish(new UpdatedGenreEvent(genre), ct);
        return true;
    }

    public UpdateGenreCommandHanlder(
        IApplicationDbContext context,
        IMapper mapper,
        IMediator mediator)
    {
        _context = context;
        _mapper = mapper;
        _mediator = mediator;
    }
}