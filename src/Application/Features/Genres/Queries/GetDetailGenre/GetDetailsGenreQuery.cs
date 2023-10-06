using MediatR;

namespace Application.Features.Genres.Queries.GetDetailGenre;

public class GetDetailsGenreQuery: IRequest<GenreVm>
{
    public Guid Id { get; set; }

    public GetDetailsGenreQuery() { }

    public GetDetailsGenreQuery(Guid id)
    {
        Id = id;
    }
}