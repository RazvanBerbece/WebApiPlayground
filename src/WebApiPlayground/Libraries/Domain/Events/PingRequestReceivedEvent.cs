namespace WebApiPlayground.Libraries.Domain.Events;

public class PingRequestReceivedEvent: IEvent
{
    public string Data { get; set; }
}