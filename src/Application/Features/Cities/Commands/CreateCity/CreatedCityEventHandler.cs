using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
namespace Application.Features.Cities.Commands.CreateCity;

public class CreatedCityEventHandler: INotificationHandler<CreatedCityEvent>
{
    private readonly ILogger<CreatedCityEventHandler> _logger;

    public CreatedCityEventHandler(ILogger<CreatedCityEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedCityEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Created new row in the table {nameof(notification)} with id = {notification.City.Id}");
        return Task.CompletedTask;
    }
}