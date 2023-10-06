using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Languages.Queries.GetDetailQuery;

public class GetDetailsLanguageQueryHandler: IRequestHandler<GetDetailsLanguageQuery, LanguageVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetDetailsLanguageQueryHandler(
        IApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<LanguageVm> Handle(GetDetailsLanguageQuery query, CancellationToken ct)
    {
        var languageVm = await _context.Languages
            .AsNoTracking()
            .Select(x => _mapper.Map<LanguageVm>(x))
            .FirstOrDefaultAsync(ct);

        return languageVm;
    }
}