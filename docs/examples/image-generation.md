# Image Generation

Generate an image using FLUX Pro 1.1 and poll for the result.

This example assumes `using BlackForestLabs;` is in scope and `apiKey` contains your BlackForestLabs API key.

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