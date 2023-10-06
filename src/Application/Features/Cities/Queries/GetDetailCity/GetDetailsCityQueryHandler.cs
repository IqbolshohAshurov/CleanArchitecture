using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Cities.Queries.GetDetailCity;

public class GetDetailsCityQueryHandler: IRequestHandler<GetDetailsCityQuery, CityVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetDetailsCityQueryHandler(
        IApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CityVm> Handle(GetDetailsCityQuery query, CancellationToken ct)
    {
        var city = await _context.Cities
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == query.Id, ct);

        var cityVm = _mapper.Map<CityVm>(city);
        return cityVm;
    }
}