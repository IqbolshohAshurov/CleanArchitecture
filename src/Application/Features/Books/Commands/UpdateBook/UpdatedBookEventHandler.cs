using System.Reflection.Metadata;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Books.Commands.UpdateBook;

public class UpdatedBookEventHandler: INotificationHandler<UpdatedBookEvent>
{
    private readonly ILogger<UpdatedBookEventHandler> _logger;

    public UpdatedBookEventHandler(ILogger<UpdatedBookEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(UpdatedBookEvent command, CancellationToken ct)
    {
        _logger.LogInformation($"Updated was concrete row with id = {command.Book.Id}");
        return Task.CompletedTask;
    }
}