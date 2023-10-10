using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Languages.Queries.GetDetailQuery;

public class GetDetailsLanguageQueryHandler: IRequestHandler<GetDetailsLanguageQuery, LanguageViewModel>
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

    public async Task<LanguageViewModel> Handle(GetDetailsLanguageQuery query, CancellationToken ct)
    {
        var language = await _context.Languages
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == query.Id, ct);
        var languageVm = _mapper.Map<LanguageViewModel>(language);
        
        return languageVm;
    }
}