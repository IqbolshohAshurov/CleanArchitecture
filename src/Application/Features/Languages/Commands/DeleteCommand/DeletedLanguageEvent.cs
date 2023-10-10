using Domain.Entities;
using MediatR;

namespace Application.Features.Languages.Commands.DeleteCommand;

public class DeletedLanguageEvent: INotification
{
    public DeletedLanguageEvent() { }

    public DeletedLanguageEvent(Language language)
    {
        Language = language;
    }

    public Language Language { get; set; }
}