# Get Credits

Basic example showing how to create a client and check your credits balance.

This example assumes `using BlackForestLabs;` is in scope and `apiKey` contains your BlackForestLabs API key.

```csharp
using var client = new BlackForestLabsClient(apiKey);

// Check your remaining credits balance.
var response = await client.GetCreditsV1CreditsGetAsync();
```