using MediatR;

namespace Application.Features.Authors.Queries.GetAuthors;

public class GetAuthorDetailsQuery: IRequest<AuthorDetailsVm>
{
    public Guid Id { get; init; }

    public GetAuthorDetailsQuery()
    {
        
    }

    public GetAuthorDetailsQuery(Guid id)
    {
        Id = id;
    }
}