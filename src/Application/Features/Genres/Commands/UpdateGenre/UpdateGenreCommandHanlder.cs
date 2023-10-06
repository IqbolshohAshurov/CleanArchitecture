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
    private readonly IValidator<UpdateGenreCommand> _validator;

    public UpdateGenreCommandHanlder(
        IApplicationDbContext context,
        IMapper mapper,
        IMediator mediator,
        IValidator<UpdateGenreCommand> validator)
    {
        _context = context;
        _mapper = mapper;
        _mediator = mediator;
        _validator = validator;
    }

    public async Task<bool> Handle(UpdateGenreCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid)
            return false;

        var genre = await _context.Genres.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        _mapper.Map(command, genre);
        await _context.SaveChangeAsync(ct);

        await _mediator.Publish(new UpdatedGenreEvent(genre), ct);
        return true;
    }
}