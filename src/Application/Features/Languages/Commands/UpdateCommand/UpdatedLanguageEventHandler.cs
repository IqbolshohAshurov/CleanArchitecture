using Application.Features.Cities.Commands.UpdateCity;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Languages.Commands.UpdateCommand;

public class UpdatedLanguageEventHandler: INotificationHandler<UpdatedLanguageEvent>
{
    private readonly ILogger<UpdatedLanguageEventHandler> _logger;

    public UpdatedLanguageEventHandler(ILogger<UpdatedLanguageEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UpdatedLanguageEvent notify, CancellationToken ct)
    {
        _logger.LogInformation($"Updated row in the table {nameof(notify)}");
        return Task.CompletedTask;
    }
}