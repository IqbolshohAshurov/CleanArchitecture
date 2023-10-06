using MediatR;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdateLanguageCommand: IRequest<bool>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
}