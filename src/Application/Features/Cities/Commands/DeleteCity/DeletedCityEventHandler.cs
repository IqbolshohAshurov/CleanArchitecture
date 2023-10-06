using Application.Features.Cities.Commands.CreateCity;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Cities.Commands.DeleteCity;

public class DeletedCityEventHandler: INotificationHandler<CreatedCityEvent>
{
    private readonly ILogger<DeletedCityEventHandler> _logger;

    public DeletedCityEventHandler(ILogger<DeletedCityEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(CreatedCityEvent notify, CancellationToken ct)
    {
        _logger.LogInformation($"Deleted row in the table {typeof(City).Name}");
        return Task.CompletedTask;
    }
}