using MediatR;

namespace Application.Features.Authors.Commands.DeleteAuthor;

public class DeleteAuthorCommand: IRequest<bool>
{
    public Guid Id { get; set; }

    public DeleteAuthorCommand()
    {
        
    }
    
    public DeleteAuthorCommand(Guid id)
    {
        Id = id;
    }
}