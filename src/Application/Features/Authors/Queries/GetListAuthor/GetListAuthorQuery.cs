using Application.Features.Authors.Queries.GetAuthors;
using MediatR;

namespace Application.Features.Authors.Queries.GetListAuthor;

public class GetListAuthorQuery: IRequest<IEnumerable<AuthorDetailsVm>>
{
    
}