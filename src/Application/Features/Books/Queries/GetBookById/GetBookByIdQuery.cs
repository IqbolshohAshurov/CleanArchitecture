using Application.Common.Models.DTOs.BookDTOs;
using MediatR;

namespace Application.Features.Books.Queries.GetBookById;

public class GetBookByIdQuery: IRequest<BookDto>
{
    public Guid Id { get; init; }

    public GetBookByIdQuery()
    {
        
    }
    
    public GetBookByIdQuery(Guid id)
    {
        Id = id;
    }
}