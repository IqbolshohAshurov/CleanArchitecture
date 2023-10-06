using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreateAuthorCommandHandler: IRequestHandler<CreateAuthorCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IValidator<CreateAuthorCommand> _validator;

    public CreateAuthorCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<CreateAuthorCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<bool> Handle(CreateAuthorCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid)
            return false;

        var author = _mapper.Map<Author>(command); 
        _context.Authors.Add(author);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new CreatedAuthorEvent(), ct);
        return true;
    }
}