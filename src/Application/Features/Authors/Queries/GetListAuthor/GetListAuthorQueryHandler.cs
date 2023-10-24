using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Authors.Queries.GetListAuthor;

public class GetListAuthorQueryHandler: IRequestHandler<GetListAuthorQuery, IEnumerable<AuthorDetailsViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListAuthorQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AuthorDetailsViewModel>> Handle(GetListAuthorQuery query, CancellationToken ct)
    {
        var authorVms = await _context.Authors
            .AsNoTracking()
            .Select(a => _mapper.Map<AuthorDetailsViewModel>(a))
            .ToListAsync(ct);
        return authorVms;
    }
}