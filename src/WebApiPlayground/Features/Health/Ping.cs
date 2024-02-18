using WebApiPlayground.Libraries.Domain.Events;

namespace WebApiPlayground.Features.Health;

public class PingEndpoint(ILogger<PingEndpoint> logger) : Endpoint<PingRequest, PingResponse>
{
    public override void Configure()
    {
        Post("/api/ping");
        AllowAnonymous();
    }

    public override async Task HandleAsync(PingRequest req, CancellationToken ct)
    {
        logger.LogInformation("Handling POST PingEndpoint");
        
        await PublishAsync(new PingRequestReceivedEvent
        {
            Data = req.EchoMessageData
        }, cancellation: ct);
        
        await SendOkAsync(new PingResponse(req.EchoMessageData), cancellation: ct);
    }
}