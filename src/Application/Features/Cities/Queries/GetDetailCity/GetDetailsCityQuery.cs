using MediatR;

namespace Application.Features.Cities.Queries.GetDetailCity;

public class GetDetailsCityQuery: IRequest<CityViewModel>
{
    public Guid Id { get; set; }

    public GetDetailsCityQuery() { }

    public GetDetailsCityQuery(Guid id)
    {
        Id = id;
    }
}