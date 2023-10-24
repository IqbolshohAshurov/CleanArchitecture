using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Genres.Queries.GetListGenre;

public class GetListGenreQueryHandler: IRequestHandler<GetListGenreQuery, IEnumerable<GenreViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListGenreQueryHandler(
        IApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GenreViewModel>> Handle(GetListGenreQuery query, CancellationToken ct)
    {
        var genreVms = await _context.Genres
            .AsNoTracking()
            .Select(x => _mapper.Map<GenreViewModel>(x))
            .ToListAsync(ct);

        return genreVms;
    }
}