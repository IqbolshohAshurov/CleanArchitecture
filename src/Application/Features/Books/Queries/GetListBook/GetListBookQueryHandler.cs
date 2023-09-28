using Application.Common.Interfaces;
using Application.Common.Models.DTOs.BookDTOs;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Queries.GetListBook;

public class GetListBookQueryHandler: IRequestHandler<GetListBookQuery, IEnumerable<BookDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListBookQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BookDto>> Handle(GetListBookQuery query, CancellationToken cancellationToken)
    {
        var book = await _context.Books.AsNoTracking().AsQueryable().Select(x => _mapper.Map<BookDto>(x)).ToListAsync(cancellationToken);
        return book;
    }
    
}