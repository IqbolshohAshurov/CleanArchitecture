using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdatedLanguageEvent: INotification
{
    public UpdatedLanguageEvent()
    {
        
    }

    public UpdatedLanguageEvent(Language language)
    {
        Language = language;
    }

    public Language Language { get; set; }
}