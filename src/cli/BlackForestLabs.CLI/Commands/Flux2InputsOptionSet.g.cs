#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal sealed record Flux2InputsOptionSet(
    Option<string> Prompt,
                     Option<bool?> DisablePup,
                     Option<string?> InputImage,
                     Option<string?> InputImage2,
                     Option<string?> InputImage3,
                     Option<string?> InputImage4,
                     Option<string?> InputImage5,
                     Option<string?> InputImage6,
                     Option<string?> InputImage7,
                     Option<string?> InputImage8,
                     Option<int?> Seed,
                     Option<int?> Width,
                     Option<int?> Height,
                     Option<int?> SafetyTolerance,
                     Option<string?> WebhookUrl,
                     Option<string?> WebhookSecret)
{
    public static Flux2InputsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new Flux2InputsOptionSet(
                        Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"Text prompt for image generation.",
                    Required = true,
                },
                DisablePup: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}disable-pup", description: @"Disable automatic prompt upsampling for this request. FLUX.2 [pro] and [max] apply prompt upsampling by default; set this to true to generate from your prompt exactly as written."),
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
                InputImage5: new Option<string?>($"--{normalizedPrefix}input-image-5")
                {
                    Description = @"Path to the fifth input image.",
                },
                InputImage6: new Option<string?>($"--{normalizedPrefix}input-image-6")
                {
                    Description = @"Path to the sixth input image.",
                },
                InputImage7: new Option<string?>($"--{normalizedPrefix}input-image-7")
                {
                    Description = @"Path to the seventh input image.",
                },
                InputImage8: new Option<string?>($"--{normalizedPrefix}input-image-8")
                {
                    Description = @"Path to the eighth input image.",
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
                    Description = @"Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.",
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