using WebApiPlayground.Features.Health;

namespace WebApiPlaygroundIntegrationTests.Health;

public class PingEndpointTests(Fixture f, ITestOutputHelper o) : TestClass<Fixture>(f, o)
{
    [Fact]
    public async Task PingEndpoint_Returns500_ForInvalidRequestData()
    {
        // Arrange
        var fakeRequest = Fake.FakeInvalidPingRequest();
        
        // Act
        var (rsp, res) = await Fixture.Client.POSTAsync<PingEndpoint, PingRequest, ErrorResponse>(fakeRequest);
        
        // Assert
        rsp.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        res.Message.Should().Be("One or more errors occurred!");
        res.Errors.Count.Should().Be(1);
        res.Errors.First().Value.Should().Equal("'echoMessageData' string data is required");
    }
    
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