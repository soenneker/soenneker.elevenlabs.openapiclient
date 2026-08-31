[![](https://img.shields.io/nuget/v/soenneker.elevenlabs.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.elevenlabs.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.elevenlabs.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.elevenlabs.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.elevenlabs.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.elevenlabs.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.elevenlabs.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.elevenlabs.openapiclient/actions/workflows/codeql.yml)

# Soenneker.ElevenLabs.OpenApiClient

A Kiota-generated .NET client for the ElevenLabs API.

## Installation

```bash
dotnet add package Soenneker.ElevenLabs.OpenApiClient
```

## Create a client

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.ElevenLabs.OpenApiClient;

var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.elevenlabs.io/")
};
httpClient.DefaultRequestHeaders.Add("xi-api-key", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new ElevenLabsOpenApiClient(adapter);
```

The HTTP client supplies authentication, so the Kiota adapter uses `AnonymousAuthenticationProvider` to avoid adding a second authorization mechanism.

## Make a request

```csharp
var response = await client.V1.Voices.GetAsync(
    cancellationToken: cancellationToken);
```

Endpoints are grouped beneath `V1`, `V2`, and `Docs`. Generated request and response models live under `Soenneker.ElevenLabs.OpenApiClient.Models`.

The source is generated. Put custom construction and application behavior outside this package so regeneration does not overwrite it. `Soenneker.ElevenLabs.OpenApiClientUtil` provides cached client construction for applications using service registration.
