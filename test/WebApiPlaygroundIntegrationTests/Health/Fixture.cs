namespace WebApiPlaygroundIntegrationTests.Health;

public class Fixture(IMessageSink s) : TestFixture<Program>(s);