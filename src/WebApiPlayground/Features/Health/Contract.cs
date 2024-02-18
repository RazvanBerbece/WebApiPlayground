using WebApiPlayground.Libraries.Domain.HealthCheck;

namespace WebApiPlayground.Features.Health;

public record PingRequest(string EchoMessageData);

public record PingResponse(string ResponseMessageData)
{
    public PingResponse FromDomain(HealthCheckProbe probeData)
    {
        return new PingResponse(probeData.Message);
    }
}