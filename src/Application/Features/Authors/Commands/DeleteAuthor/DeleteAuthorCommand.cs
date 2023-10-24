using MediatR;

namespace Application.Features.Authors.Commands.DeleteAuthor;

public class DeleteAuthorCommand: IRequest<bool>
{
    public DeleteAuthorCommand() {}

    public DeleteAuthorCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}