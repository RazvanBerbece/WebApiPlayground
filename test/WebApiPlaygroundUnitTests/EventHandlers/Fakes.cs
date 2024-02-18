using Bogus;
using WebApiPlayground.Features.Health;

namespace WebApiPlaygroundUnitTests.EventHandlers;

static class Fakes
{
    internal static PingRequest FakePingRequest(this Faker f)
        => new(f.Lorem.Paragraphs());
}