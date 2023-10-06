using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;
namespace Application.Features.Cities.Commands.CreateCity;

public class GreatedCityEventHandler: INotificationHandler<CreatedCityEvent>
{
    private readonly ILogger<GreatedCityEventHandler> _logger;

    public GreatedCityEventHandler(ILogger<GreatedCityEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedCityEvent notification, CancellationToken ct)
    {
        _logger.LogInformation($"Created new row in the table {typeof(City).Name} with id = {notification.City.Id}");
        return Task.CompletedTask;
    }
}