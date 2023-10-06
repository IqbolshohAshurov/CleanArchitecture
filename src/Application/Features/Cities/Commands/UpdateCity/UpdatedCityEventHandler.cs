using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Cities.Commands.UpdateCity;

public class UpdatedCityEventHandler: INotificationHandler<UpdatedCityEvent>
{
    private readonly ILogger<UpdatedCityEventHandler> _logger;

    public UpdatedCityEventHandler(ILogger<UpdatedCityEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UpdatedCityEvent notify, CancellationToken ct)
    {
        _logger.LogInformation($"Updated row in the table {typeof(City).Name}");
        return Task.CompletedTask;
    }
}