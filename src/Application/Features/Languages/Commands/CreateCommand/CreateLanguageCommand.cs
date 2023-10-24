using MediatR;

namespace Application.Features.Languages.Commands.CreateCommand;

public class CreateLanguageCommand: IRequest<bool>
{
    public CreateLanguageCommand() { }

    public CreateLanguageCommand(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    
}