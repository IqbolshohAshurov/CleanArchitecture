using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Cities.Queries.GetListCity;

public class GetListCityQueryHandler: IRequestHandler<GetListCityQuery, IEnumerable<CityVm>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListCityQueryHandler(
        IApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CityVm>> Handle(GetListCityQuery query, CancellationToken ct)
    {
        var cityVms = await _context.Cities
            .AsNoTracking()
            .Select(x => _mapper.Map<CityVm>(x))
            .ToListAsync(ct);

        return cityVms;
    }
}