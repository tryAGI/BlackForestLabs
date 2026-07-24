#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal sealed record Flux2KleinTryonInputsOptionSet(
    Option<string> Prompt,
                     Option<string> Person,
                     Option<string> Garment,
                     Option<int?> Seed,
                     Option<int?> SafetyTolerance,
                     Option<string?> WebhookUrl,
                     Option<string?> WebhookSecret)
{
    public static Flux2KleinTryonInputsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new Flux2KleinTryonInputsOptionSet(
                        Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"Text prompt for VTO generation.",
                    Required = true,
                },
                Person: new Option<string>($"--{normalizedPrefix}person")
                {
                    Description = @"Person image (maps internally to input_image).",
                    Required = true,
                },
                Garment: new Option<string>($"--{normalizedPrefix}garment")
                {
                    Description = @"Image of one more garments (maps internally to input_image_2).",
                    Required = true,
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"Optional seed for reproducibility.",
                },
                SafetyTolerance: new Option<int?>($"--{normalizedPrefix}safety-tolerance")
                {
                    Description = @"Tolerance level for input and output moderation. Between 0 and 5 for public use.",
                },
                WebhookUrl: new Option<string?>($"--{normalizedPrefix}webhook-url")
                {
                    Description = @"URL to receive webhook notifications",
                },
                WebhookSecret: new Option<string?>($"--{normalizedPrefix}webhook-secret")
                {
                    Description = @"Optional secret for webhook signature verification",
                }
        );
    }
}