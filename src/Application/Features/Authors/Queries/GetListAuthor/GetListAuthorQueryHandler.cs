using Application.Common.Interfaces;
using Application.Features.Authors.Queries.GetAuthors;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Authors.Queries.GetListAuthor;

public class GetListAuthorQueryHandler: IRequestHandler<GetListAuthorQuery, IEnumerable<AuthorDetailsVm>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListAuthorQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AuthorDetailsVm>> Handle(GetListAuthorQuery query, CancellationToken ct)
    {
        var authorList = await _context.Authors.AsNoTracking().ToListAsync(ct);
        var authorVm = authorList.Select(a => _mapper.Map<AuthorDetailsVm>(a));//.ToList();
        //var authorVm = _mapper.Map<AuthorDetailsVm>(authorList);
        return authorVm;
    }
}