using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.PublishingHouses.Queries.GetListPublishingHouse;

public class GetListPublishingHouseQueryHandler: IRequestHandler<GetListPublishingHouseQuery, IEnumerable<PublishingHouseViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetListPublishingHouseQueryHandler(
        IApplicationDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PublishingHouseViewModel>> Handle(GetListPublishingHouseQuery query, CancellationToken ct)
    {
        var publishingHouseVms = await _context.PublishingHouses
            .AsNoTracking()
            .Select(x => _mapper.Map<PublishingHouseViewModel>(x))
            .ToListAsync(ct);

        return publishingHouseVms;

    }
}