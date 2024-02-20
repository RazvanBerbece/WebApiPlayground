using FluentValidation;

namespace WebApiPlayground.Features.Health;

public class PingEndpointValidator : Validator<PingRequest>
{
    public PingEndpointValidator()
    {
        RuleFor(x => x.EchoMessageData)
            .NotEmpty()
            .WithMessage("'echoMessageData' string data is required");
    }
}