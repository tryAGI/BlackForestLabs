namespace BlackForestLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BlackForestLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BFL_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("BFL_API_KEY environment variable is not found.");

        var client = new BlackForestLabsClient(apiKey);
        
        return client;
    }
}
