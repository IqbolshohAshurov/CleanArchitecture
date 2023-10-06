using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Languages.Queries.GetListQuery;

public class GetListLanguageQueryHandler: IRequestHandler<GetListLanguageQuery, IEnumerable<LanguageVm>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListLanguageQueryHandler(
        IApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LanguageVm>> Handle(GetListLanguageQuery query, CancellationToken ct)
    {
        var languageVms = await _context.Languages
            .AsNoTracking()
            .Select(x => _mapper.Map<LanguageVm>(x))
            .ToListAsync(ct);

        return languageVms;
    }

}