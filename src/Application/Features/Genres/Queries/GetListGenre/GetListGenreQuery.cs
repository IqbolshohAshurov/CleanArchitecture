using MediatR;

namespace Application.Features.Genres.Queries.GetListGenre;

public class GetListGenreQuery: IRequest<IEnumerable<GenreVm>> { }