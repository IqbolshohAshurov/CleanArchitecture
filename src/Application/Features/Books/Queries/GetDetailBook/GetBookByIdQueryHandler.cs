using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Queries.GetBookById;

public class GetBookByIdQueryHandler: IRequestHandler<GetBookByIdQuery, BookVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetBookByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BookVm> Handle(GetBookByIdQuery query, CancellationToken ct)
    {
        var book = await _context.Books
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == query.Id, ct);
        var bookDto = _mapper.Map<BookVm>(book);

        return bookDto;
    }
}