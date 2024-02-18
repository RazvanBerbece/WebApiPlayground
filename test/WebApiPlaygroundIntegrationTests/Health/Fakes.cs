using Bogus;
using WebApiPlayground.Features.Health;

namespace WebApiPlaygroundIntegrationTests.Health;

static class Fakes
{
    internal static PingRequest FakePingRequest(this Faker f)
        => new(f.Lorem.Paragraphs());
}