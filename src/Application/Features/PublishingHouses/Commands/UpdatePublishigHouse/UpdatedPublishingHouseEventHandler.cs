using MediatR;
using Microsoft.Extensions.Logging;
namespace Application.Features.PublishingHouses.Commands.UpdatePublishigHouse;

public class UpdatedPublishingHouseEventHandler: INotificationHandler<UpdatedPublishingHouseEvent>
{
    private readonly ILogger<UpdatedPublishingHouseEventHandler> _logger;

    public UpdatedPublishingHouseEventHandler(ILogger<UpdatedPublishingHouseEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UpdatedPublishingHouseEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Updated row from the Table PublishingHouse with type {nameof(notification)}");
        return Task.CompletedTask;
    }
}