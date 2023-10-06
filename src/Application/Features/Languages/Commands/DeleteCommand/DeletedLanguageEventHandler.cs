using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Languages.Commands.DeleteCommand;

public class DeletedLanguageEventHandler: INotificationHandler<DeletedLanguageEvent>
{
    private readonly ILogger<DeletedLanguageEventHandler> _logger;

    public DeletedLanguageEventHandler(ILogger<DeletedLanguageEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DeletedLanguageEvent notify, CancellationToken ct)
    {
        _logger.LogInformation($"Deleted row in the table {typeof(Language)}.Name");
        return Task.CompletedTask;
    }
}