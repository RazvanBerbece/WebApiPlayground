using WebApiPlayground.Libraries.Domain.Events;

namespace WebApiPlayground.Libraries.EventHandlers;

public class PingRequestReceivedEventHandler(ILogger<PingRequestReceivedEventHandler> logger)
    : IEventHandler<PingRequestReceivedEvent>
{
    private readonly ILogger _logger = logger;

    public Task HandleAsync(PingRequestReceivedEvent eventModel, CancellationToken ct)
    {
        _logger.LogInformation($"ping request received event received: [{eventModel.Data}] at [{eventModel.CreationTime}]");
        return Task.CompletedTask;
    }
}