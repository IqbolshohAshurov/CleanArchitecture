namespace Application.Features.Genres.Queries.GetListGenre;

public class GenreViewModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public GenreViewModel()
    {
        
    }

    public GenreViewModel(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}