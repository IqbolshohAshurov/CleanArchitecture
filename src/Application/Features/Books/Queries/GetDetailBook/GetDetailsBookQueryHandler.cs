using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Queries.GetDetailBook;

public class GetDetailsBookQueryHandler: IRequestHandler<GetDetailsBookQuery, BookViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetDetailsBookQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BookViewModel> Handle(GetDetailsBookQuery query, CancellationToken ct)
    {
        var book = await _context.Books
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == query.Id, ct);
        
        var bookVm = _mapper.Map<BookViewModel>(book);

        return bookVm;
    }
}