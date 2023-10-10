using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.PublishingHouses.Queries.GetDetailsPublishingHouse;

public class GetDetailsPublishingHouseQueryHandler: IRequestHandler<GetDetailsPublishingHouseQuery, PublishingHouseViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetDetailsPublishingHouseQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PublishingHouseViewModel> Handle(GetDetailsPublishingHouseQuery query, CancellationToken ct)
    {
        var publishingHouse =
            await _context.PublishingHouses.AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == query.Id, ct);
        var publishingHouseVm = _mapper.Map<PublishingHouseViewModel>(publishingHouse);
            
        return publishingHouseVm;
    }
}