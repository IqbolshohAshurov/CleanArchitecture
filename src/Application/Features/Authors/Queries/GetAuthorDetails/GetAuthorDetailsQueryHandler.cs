using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Authors.Queries.GetAuthorDetails;

public class GetAuthorDetailsQueryHandler: IRequestHandler<GetAuthorDetailsQuery, AuthorDetailsViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAuthorDetailsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<AuthorDetailsViewModel> Handle(GetAuthorDetailsQuery query, CancellationToken ct)
    {
        var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == query.Id, ct);
        var authorVm = _mapper.Map<AuthorDetailsViewModel>(author);
        
        return authorVm;
    }
}