using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.PublishingHouses.Commands.DeletePublishingHouse;

public class DeletedPublishingHouseEventHandler : INotificationHandler<DeletedPublishingHouseEvent>
{
    private readonly ILogger<DeletedPublishingHouseEventHandler> _logger;

    public DeletedPublishingHouseEventHandler(ILogger<DeletedPublishingHouseEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DeletedPublishingHouseEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Deleted row from the table PublishingHouse with type {nameof(notification)}");
        return Task.CompletedTask;
    }

}