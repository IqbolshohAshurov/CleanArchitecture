using Domain.Common;

namespace Domain.Entities;

public class Book: BaseEntity
{
    public string Name { get; set; }
    public int CountPage { get; set; }
    public string YearOfPublication { get; set; }
    public string Isbn { get; set; }
    public string? Description { get; set; }
    public string? Photo { get; set; }
    public byte Edition { get; set; }

    public Guid GenreId { get; set; }
    public Guid PublishingHouseId { get; set; }

    public Genre Genre { get; set; }
    public PublishingHouse PublishingHouse { get; set; }

    public ICollection<Author> Authors { get; set; } = new List<Author>();
    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
    public ICollection<Language> Languages { get; set; } = new List<Language>();
    public ICollection<BookLanguage> BookLanguages { get; set; } = new List<BookLanguage>();
}