using Domain.Entities;
using MediatR;

namespace Application.Features.Authors.Commands.DeleteAuthor;

public class DeletedAuthorEvent: INotification
{
    public DeletedAuthorEvent(){}
    
    public DeletedAuthorEvent(Author author) => Author = author;
    
    public Author Author { get; set; }
}