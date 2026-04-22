using Soenneker.Tests.HostedUnit;

namespace Soenneker.ElevenLabs.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ElevenLabsOpenApiClientTests : HostedUnitTest
{
    public ElevenLabsOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
