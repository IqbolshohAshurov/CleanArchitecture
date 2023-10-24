using MediatR;

namespace Application.Features.Books.Commands.UpdateBook;

public class UpdateBookCommand: IRequest<bool>
{
    public UpdateBookCommand() {}

    public UpdateBookCommand(Guid id,
        string name,
        int countPage,
        string yearOfPublication,
        string isbn,
        string? description,
        string? photo,
        byte edition,
        Guid genreId,
        Guid publishingHouseId)
    {
        Id = id;
        Name = name;
        CountPage = countPage;
        YearOfPublication = yearOfPublication;
        Isbn = isbn;
        Description = description;
        Photo = photo;
        Edition = edition;
        GenreId = genreId;
        PublishingHouseId = publishingHouseId;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

    public int CountPage { get; set; }

    public string YearOfPublication { get; set; }

    public string Isbn { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public byte Edition { get; set; }

    public Guid GenreId { get; set; }

    public Guid PublishingHouseId { get; set; }
}