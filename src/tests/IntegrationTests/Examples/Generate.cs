/*
order: 10
title: Get Credits
slug: get-credits

Basic example showing how to create a client and check your credits balance.
*/

namespace BlackForestLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetCredits()
    {
        using var client = GetAuthenticatedClient();

        //// Check your remaining credits balance.
        var response = await client.GetCreditsV1CreditsGetAsync();

        Assert.IsNotNull(response);
    }
}
