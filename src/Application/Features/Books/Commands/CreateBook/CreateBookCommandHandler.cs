using Application.Common.Interfaces;
using Application.Common.Models;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.Features.Books.Commands.CreateBook;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IValidator<CreateBookCommand> _validator;
    
    public CreateBookCommandHandler(
        IApplicationDbContext context,
        IMediator mediator,
        IMapper mapper,
        IValidator<CreateBookCommand> validator)
    {
        _context = context;
        _mediator = mediator;
        _mapper = mapper;
        _validator = validator;
    }

    public  async Task<bool> Handle(CreateBookCommand command, CancellationToken cancellationToken)
    {
        var bookValidate = await _validator.ValidateAsync(command, cancellationToken);

        if (!bookValidate.IsValid)
            return false;

        var book = _mapper.Map<Book>(command);
        _context.Books.Add(book);
        await _mediator.Publish(new CreatedBookEvent(book),cancellationToken);
        await _context.SaveChangeAsync(cancellationToken);

        return true;
    }
}