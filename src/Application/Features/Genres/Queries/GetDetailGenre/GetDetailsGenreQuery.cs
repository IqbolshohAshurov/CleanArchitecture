using MediatR;

namespace Application.Features.Genres.Queries.GetDetailGenre;

public class GetDetailsGenreQuery: IRequest<GenreViewModel>
{
    public Guid Id { get; set; }

    public GetDetailsGenreQuery() { }

    public GetDetailsGenreQuery(Guid id)
    {
        Id = id;
    }
}