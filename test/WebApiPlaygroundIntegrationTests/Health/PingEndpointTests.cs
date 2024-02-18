using WebApiPlayground.Features.Health;

namespace WebApiPlaygroundIntegrationTests.Health;

public class PingEndpointTests(Fixture f, ITestOutputHelper o) : TestClass<Fixture>(f, o)
{
    [Fact]
    public async Task PingEndpoint_Echoes_RequestData()
    {
        // Arrange
        var fakeRequest = Fake.FakePingRequest();
        
        // Act
        var (rsp, res) = await Fixture.Client.POSTAsync<PingEndpoint, PingRequest, PingResponse>(fakeRequest);
        
        // Assert
        rsp.StatusCode.Should().Be(HttpStatusCode.OK);
        res.ResponseMessageData.Should().Be(fakeRequest.EchoMessageData);
    }
}