using Domain.Common;

namespace Domain.Entities;

public class Language: BaseEntity
{
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; } = new List<Book>();
    public ICollection<BookLanguage> BookLanguages { get; set; } = new List<BookLanguage>();

}