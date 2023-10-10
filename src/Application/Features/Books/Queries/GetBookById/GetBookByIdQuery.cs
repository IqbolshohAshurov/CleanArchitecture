using MediatR;

namespace Application.Features.Books.Queries.GetBookById;

public class GetBookByIdQuery: IRequest<BookViewModel>
{
    public GetBookByIdQuery() { }

    public GetBookByIdQuery(Guid id) => Id = id;
    
    public Guid Id { get; init; }
}