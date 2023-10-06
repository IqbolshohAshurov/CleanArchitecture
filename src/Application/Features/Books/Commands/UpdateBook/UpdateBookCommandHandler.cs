using Application.Common.Interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Commands.UpdateBook;

public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly IValidator<UpdateBookCommand> _validator;
    private readonly IMediator _mediator;

    public UpdateBookCommandHandler(
        IApplicationDbContext context,
        IMapper mapper,
        IValidator<UpdateBookCommand> validator,
        IMediator mediator)
    {
        _context = context;
        _mapper = mapper;
        _validator = validator;
        _mediator = mediator;
    }

    public async Task<bool> Handle(UpdateBookCommand command, CancellationToken ct)
    {
        var book = await _context.Books.AsQueryable().FirstOrDefaultAsync(x=> x.Id == command.Id, ct);
        var valide = await _validator.ValidateAsync(command, ct);
        if (!valide.IsValid)
            return false;

        _mapper.Map(command, book);
        await _mediator.Publish(new UpdatedBookEvent(book), ct);
        await _context.SaveChangeAsync(ct);
        
        return true;
    }
}