#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal sealed record Flux2KleinInputsOptionSet(
    Option<string?> User,
                     Option<string> Prompt,
                     Option<string?> InputImage,
                     Option<string?> InputImage2,
                     Option<string?> InputImage3,
                     Option<string?> InputImage4,
                     Option<int?> Seed,
                     Option<int?> Width,
                     Option<int?> Height,
                     Option<int?> SafetyTolerance,
                     Option<string?> WebhookUrl,
                     Option<string?> WebhookSecret)
{
    public static Flux2KleinInputsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new Flux2KleinInputsOptionSet(
                        User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"Opaque identifier for the end user supplied by the calling platform.",
                },
                Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"Text prompt for image generation.",
                    Required = true,
                },
                InputImage: new Option<string?>($"--{normalizedPrefix}input-image")
                {
                    Description = @"Path to the input image.",
                },
                InputImage2: new Option<string?>($"--{normalizedPrefix}input-image-2")
                {
                    Description = @"Path to the second input image.",
                },
                InputImage3: new Option<string?>($"--{normalizedPrefix}input-image-3")
                {
                    Description = @"Path to the third input image.",
                },
                InputImage4: new Option<string?>($"--{normalizedPrefix}input-image-4")
                {
                    Description = @"Path to the fourth input image.",
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"Optional seed for reproducibility.",
                },
                Width: new Option<int?>($"--{normalizedPrefix}width")
                {
                    Description = @"Width of the image",
                },
                Height: new Option<int?>($"--{normalizedPrefix}height")
                {
                    Description = @"Height of the image",
                },
                SafetyTolerance: new Option<int?>($"--{normalizedPrefix}safety-tolerance")
                {
                    Description = @"Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.",
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