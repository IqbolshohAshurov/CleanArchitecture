namespace Application.Features.Genres.Queries.GetListGenre;

public class GenreVm
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public GenreVm()
    {
        
    }

    public GenreVm(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}