using MediatR;

namespace Application.Features.Cities.Queries.GetListCity;

public class GetListCityQuery: IRequest<IEnumerable<CityVm>> { }