using WebApiPlayground.Libraries.Domain.HealthCheck;

namespace WebApiPlayground.Features.Health;

public record HealthCheckRequest(string EchoMessageData);

public record HealthCheckResponse(string ResponseMessageData)
{
    public HealthCheckResponse FromDomain(HealthCheckProbe probeData)
    {
        return new HealthCheckResponse(probeData.Message);
    }
}