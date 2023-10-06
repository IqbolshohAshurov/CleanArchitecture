using MediatR;

namespace Application.Features.Books.Queries.GetBookById;

public class GetBookByIdQuery: IRequest<BookVm>
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