using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdatedLanguageEvent: INotification
{
    public Language Language { get; set; }

    public UpdatedLanguageEvent(Language language)
    {
        Language = language;
    }

    public UpdatedLanguageEvent()
    {
        
    }
}