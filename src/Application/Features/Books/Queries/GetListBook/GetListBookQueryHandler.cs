using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Queries.GetListBook;

public class GetListBookQueryHandler: IRequestHandler<GetListBookQuery, IEnumerable<BookViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListBookQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BookViewModel>> Handle(GetListBookQuery query, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .AsNoTracking()
            .Select(x => _mapper.Map<BookViewModel>(x))
            .ToListAsync(cancellationToken);
        return book;
    }
    
}