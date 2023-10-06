using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreatedAuthorEvent: INotification
{
    public Author Author { get; set; }

    public CreatedAuthorEvent()
    {
        
    }

    public CreatedAuthorEvent(Author author)
    {
        Author = author;
    }
}