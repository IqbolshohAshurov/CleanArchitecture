using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreCommandHandler: IRequestHandler<CreateGenreCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IValidator<CreateGenreCommand> _validator;

    public CreateGenreCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<CreateGenreCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<bool> Handle(CreateGenreCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid)
            return false;

        var genre = _mapper.Map<Genre>(command);
        _context.Genres.Add(genre);
        await _context.SaveChangeAsync(ct);
        return true;
    }
}