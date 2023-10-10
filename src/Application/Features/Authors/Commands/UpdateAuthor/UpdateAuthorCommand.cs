using MediatR;

namespace Application.Features.Authors.Commands.UpdateAuthor;

public class UpdateAuthorCommand: IRequest<bool>
{
    public UpdateAuthorCommand() {}
    
    public UpdateAuthorCommand(Guid id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public Guid Id { get; set; }
    
    public string FirstName { get; set; }

    public string LastName { get; set; }
}