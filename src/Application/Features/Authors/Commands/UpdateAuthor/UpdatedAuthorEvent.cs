using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdatedAuthorEvent: INotification
{
    public Author Author { get; set; }

    public UpdatedAuthorEvent(Author author)
    {
        Author = author;
    }

    public UpdatedAuthorEvent()
    {
        
    }
}