using Application.Common.Interfaces;
using Application.Common.Models.DTOs.BookDTOs;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Books.Queries.GetBookById;

public class GetBookByIdQueryHandler: IRequestHandler<GetBookByIdQuery, BookDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetBookByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BookDto> Handle(GetBookByIdQuery query, CancellationToken ct)
    {
        var book = await _context.Books.AsNoTracking().AsQueryable().FirstOrDefaultAsync(x => x.Id == query.Id);
        var bookDto = _mapper.Map<BookDto>(book);

        return bookDto;
    }
}