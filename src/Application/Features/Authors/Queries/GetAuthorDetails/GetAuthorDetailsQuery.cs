using MediatR;

namespace Application.Features.Authors.Queries.GetAuthorDetails;

public class GetAuthorDetailsQuery: IRequest<AuthorDetailsViewModel>
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