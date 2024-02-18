using FakeItEasy;
using WebApiPlayground.Libraries.Domain.Events;

namespace WebApiPlaygroundUnitTests.EventHandlers;

public class Tests(Fixture f, ITestOutputHelper o) : TestClass<Fixture>(f, o)
{
    [Fact]
    public async void PingRequestReceivedEventHandler_Executes_Successfully()
    {
        // Arrange
        var req = Fake.FakePingRequest();
        var fakeHandler = A.Fake<IEventHandler<PingRequestReceivedEvent>>();
        A.CallTo(() => fakeHandler.HandleAsync(A<PingRequestReceivedEvent>.Ignored, A<CancellationToken>.Ignored))
            .Returns(Task.CompletedTask)
            .Once();
        var evnt = Factory.CreateEvent(
            new[]
            {
                fakeHandler
            });
        
        // Act
        await evnt.PublishAsync();
        
        // Assert
        A.CallTo(() => fakeHandler.HandleAsync(A<PingRequestReceivedEvent>.Ignored, A<CancellationToken>.Ignored))
            .MustHaveHappenedOnceExactly();
    }
}