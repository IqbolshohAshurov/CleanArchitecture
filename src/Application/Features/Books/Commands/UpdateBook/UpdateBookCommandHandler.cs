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
    private readonly IMediator _mediator;

    public UpdateBookCommandHandler(
        IApplicationDbContext context,
        IMapper mapper,
        IMediator mediator)
    {
        _context = context;
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<bool> Handle(UpdateBookCommand command, CancellationToken ct)
    {
        var book = await _context.Books.FirstOrDefaultAsync(x=> x.Id == command.Id, ct);
        if (book is null)
            return false;

        _mapper.Map(command, book);
        await _mediator.Publish(new UpdatedBookEvent(book), ct);
        await _context.SaveChangeAsync(ct);
        
        return true;
    }
}