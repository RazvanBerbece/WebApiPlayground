namespace WebApiPlaygroundUnitTests.EventHandlers;

public class Fixture(IMessageSink s) : TestFixture<Program>(s);