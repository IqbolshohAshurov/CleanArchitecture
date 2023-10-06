using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Genres.Queries.GetDetailGenre;

public class GetDetailsGenreQueryHandler: IRequestHandler<GetDetailsGenreQuery, GenreVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetDetailsGenreQueryHandler(
        IApplicationDbContext context,
        IMapper mapper
    )
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GenreVm> Handle(GetDetailsGenreQuery query, CancellationToken ct)
    {
        var genre = await _context.Genres
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == query.Id, ct);

        var genreVm = _mapper.Map<GenreVm>(genre);
        return genreVm;
    }
}