using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdatedAuthorEvent: INotification
{
    public UpdatedAuthorEvent() {}

    public UpdatedAuthorEvent(Author author) => Author = author;
    
    public Author Author { get; set; }
}