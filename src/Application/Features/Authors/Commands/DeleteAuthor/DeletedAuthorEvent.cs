using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.DeleteAuthor;

public class DeletedAuthorEvent: INotification
{
    public Author Author { get; set; }

    public DeletedAuthorEvent()
    {
        
    }

    public DeletedAuthorEvent(Author author)
    {
        Author = author;
    }
}