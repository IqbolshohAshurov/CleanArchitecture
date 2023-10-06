using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;

public class GetDetailsPublishingHouseQueryHandler: IRequestHandler<GetDetailsPublishingHouseQuery, PublishingHouseVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetDetailsPublishingHouseQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PublishingHouseVm> Handle(GetDetailsPublishingHouseQuery query, CancellationToken ct)
    {
        // var publishingHouse = await _context.PublishingHouses.FirstOrDefaultAsync(x => x.Id == query.Id);
        // var publishingHouseVm = _mapper.Map<PublishingHouseVm>(publishingHouse);
        
        var publishingHouseVm =
            await _context.PublishingHouses.AsNoTracking()
                .Select(x => _mapper.Map<PublishingHouseVm>(x))
                .FirstOrDefaultAsync(ct);//.ToListAsync();
        
        return publishingHouseVm;
    }
}