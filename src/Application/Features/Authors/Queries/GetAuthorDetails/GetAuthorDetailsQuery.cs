using MediatR;

namespace Application.Features.Authors.Queries.GetAuthorDetails;

public class GetAuthorDetailsQuery: IRequest<AuthorDetailsViewModel>
{
    public GetAuthorDetailsQuery() { }

    public GetAuthorDetailsQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; init; }
}