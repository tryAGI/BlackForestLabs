/*
order: 20
title: Image Generation
slug: image-generation

Generate an image using FLUX Pro 1.1 and poll for the result.
*/

namespace BlackForestLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ImageGeneration()
    {
        using var client = GetAuthenticatedClient();

        //// Submit an image generation request using FLUX Pro 1.1.
        var response = await client.Models.FluxPro11V1FluxPro11PostAsync(
            prompt: "A serene mountain landscape at sunset",
            width: 1024,
            height: 768);

        Assert.IsNotNull(response);

        //// The API returns a task ID. Poll for the result using GetResult.
        var asyncResponse = response.Value1;
        if (asyncResponse is not null)
        {
            var result = await client.Utility.GetResultV1GetResultGetAsync(
                id: asyncResponse.Id);

            Assert.IsNotNull(result);
        }
    }
}
