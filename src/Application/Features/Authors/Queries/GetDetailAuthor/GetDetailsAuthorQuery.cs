using MediatR;

namespace Application.Features.Authors.Queries.GetDetailAuthor;

public class GetDetailsAuthorQuery: IRequest<AuthorDetailsViewModel>
{
    public GetDetailsAuthorQuery() { }

    public GetDetailsAuthorQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; init; }
}