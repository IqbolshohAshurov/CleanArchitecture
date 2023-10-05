using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.PublishingHouses.Commands.CreatePublishingHouse;

public class CreatedPublishingHouseEventHandler: INotificationHandler<CreatedPublishingHouseEvent>
{
    private readonly ILogger<CreatedPublishingHouseEventHandler> _logger;

    public CreatedPublishingHouseEventHandler(ILogger<CreatedPublishingHouseEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedPublishingHouseEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Added new row to the table PublishingHouse from type {nameof(notification)}");
        return Task.CompletedTask;
    }
}