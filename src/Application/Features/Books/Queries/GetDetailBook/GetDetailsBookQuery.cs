using MediatR;

namespace Application.Features.Books.Queries.GetDetailBook;

public class GetDetailsBookQuery: IRequest<BookViewModel>
{
    public GetDetailsBookQuery() { }

    public GetDetailsBookQuery(Guid id) => Id = id;
    
    public Guid Id { get; init; }
}