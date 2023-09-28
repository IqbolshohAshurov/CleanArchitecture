using Application.Common.Models;
using MediatR;

namespace Application.Features.Books.Commands.CreateBook;

public class CreateBookCommand: IRequest<bool>
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
}