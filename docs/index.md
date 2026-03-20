# BlackForestLabs

[![Nuget package](https://img.shields.io/nuget/vpre/BlackForestLabs)](https://www.nuget.org/packages/BlackForestLabs/)
[![dotnet](https://github.com/tryAGI/BlackForestLabs/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/BlackForestLabs/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/BlackForestLabs)](https://github.com/tryAGI/BlackForestLabs/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official BlackForestLabs OpenAPI specification](https://raw.githubusercontent.com/BlackForestLabs/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using BlackForestLabs;

using var client = new BlackForestLabsClient(apiKey);
```

<!-- EXAMPLES:START -->
### Get Credits
Basic example showing how to create a client and check your credits balance.

```csharp
using var client = new BlackForestLabsClient(apiKey);

// Check your remaining credits balance.
var response = await client.GetCreditsV1CreditsGetAsync();
```

### Image Generation
Generate an image using FLUX Pro 1.1 and poll for the result.

```csharp
using var client = new BlackForestLabsClient(apiKey);

// Submit an image generation request using FLUX Pro 1.1.
var response = await client.Models.FluxPro11V1FluxPro11PostAsync(
    prompt: "A serene mountain landscape at sunset",
    width: 1024,
    height: 768);

// The API returns a task ID. Poll for the result using GetResult.
var asyncResponse = response.Value1;
if (asyncResponse is not null)
{
    var result = await client.Utility.GetResultV1GetResultGetAsync(
        id: asyncResponse.Id);

}
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/BlackForestLabs/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/BlackForestLabs/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
