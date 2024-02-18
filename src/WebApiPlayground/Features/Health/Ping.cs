using WebApiPlayground.Libraries.Domain.Events;

namespace WebApiPlayground.Features.Health;

public class PingEndpoint(ILogger<PingEndpoint> logger) : Endpoint<HealthCheckRequest, HealthCheckResponse>
{
    public override void Configure()
    {
        Post("/api/ping");
        AllowAnonymous();
    }

    public override async Task HandleAsync(HealthCheckRequest req, CancellationToken ct)
    {
        logger.LogInformation("Handle POST PingEndpoint");
        
        await PublishAsync(new PingRequestReceivedEvent
        {
            Data = req.EchoMessageData
        }, cancellation: ct);
        
        await SendOkAsync(new HealthCheckResponse(req.EchoMessageData), cancellation: ct);
    }
}