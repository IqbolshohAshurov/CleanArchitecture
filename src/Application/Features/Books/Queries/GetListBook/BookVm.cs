namespace Application.Features.Books.Queries.GetListBook;

public class BookVm
{
    public string Name { get; set; }

    public int CountPage { get; set; }

    public string YearOfPublication { get; set; }

    public string Isbn { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public byte Edition { get; set; }
}