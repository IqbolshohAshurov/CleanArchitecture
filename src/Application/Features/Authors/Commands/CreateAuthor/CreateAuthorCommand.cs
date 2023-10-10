using MediatR;

namespace Application.Features.Authors.Commands.CreateAuthor;

public class CreateAuthorCommand: IRequest<bool>
{
    public CreateAuthorCommand() { }

    public CreateAuthorCommand(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}