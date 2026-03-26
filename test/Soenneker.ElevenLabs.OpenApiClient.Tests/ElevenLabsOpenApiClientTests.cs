using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ElevenLabs.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ElevenLabsOpenApiClientTests : FixturedUnitTest
{
    public ElevenLabsOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
