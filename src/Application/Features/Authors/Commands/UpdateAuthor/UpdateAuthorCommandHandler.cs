using Application.Common.Interfaces;
using Application.Features.Authors.Commands.CreateAuthor;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdateAuthorCommandHandler: IRequestHandler<UpdateAuthorCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IValidator<UpdateAuthorCommand> _validator;

    public UpdateAuthorCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<UpdateAuthorCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<bool> Handle(UpdateAuthorCommand command, CancellationToken ct)
    {
        var valide = await _validator.ValidateAsync(command, ct);

        if (!valide.IsValid)
            return false;
        
        var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == command.Id, ct);
        _mapper.Map(command, author);
        await _context.SaveChangeAsync(ct);
        await _mediator.Publish(new UpdatedAuthorEvent(), ct);
        return true;
    }
}