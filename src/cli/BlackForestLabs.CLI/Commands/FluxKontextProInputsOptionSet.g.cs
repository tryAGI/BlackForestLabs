#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal sealed record FluxKontextProInputsOptionSet(
    Option<string> Prompt,
                     Option<string?> InputImage,
                     Option<string?> InputImage2,
                     Option<string?> InputImage3,
                     Option<string?> InputImage4,
                     Option<int?> Seed,
                     Option<string?> AspectRatio,
                     Option<string?> WebhookUrl,
                     Option<string?> WebhookSecret,
                     Option<bool?> PromptUpsampling,
                     Option<int?> SafetyTolerance)
{
    public static FluxKontextProInputsOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new FluxKontextProInputsOptionSet(
                        Prompt: new Option<string>($"--{normalizedPrefix}prompt")
                {
                    Description = @"Text prompt for image generation.",
                    Required = true,
                },
                InputImage: new Option<string?>($"--{normalizedPrefix}input-image")
                {
                    Description = @"Base64 encoded image or URL to use with Kontext.",
                },
                InputImage2: new Option<string?>($"--{normalizedPrefix}input-image-2")
                {
                    Description = @"Base64 encoded image or URL to use with Kontext. *Experimental Multiref*",
                },
                InputImage3: new Option<string?>($"--{normalizedPrefix}input-image-3")
                {
                    Description = @"Base64 encoded image or URL to use with Kontext. *Experimental Multiref*",
                },
                InputImage4: new Option<string?>($"--{normalizedPrefix}input-image-4")
                {
                    Description = @"Base64 encoded image or URL to use with Kontext. *Experimental Multiref*",
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"Optional seed for reproducibility.",
                },
                AspectRatio: new Option<string?>($"--{normalizedPrefix}aspect-ratio")
                {
                    Description = @"Aspect ratio of the image between 21:9 and 9:21",
                },
                WebhookUrl: new Option<string?>($"--{normalizedPrefix}webhook-url")
                {
                    Description = @"URL to receive webhook notifications",
                },
                WebhookSecret: new Option<string?>($"--{normalizedPrefix}webhook-secret")
                {
                    Description = @"Optional secret for webhook signature verification",
                },
                PromptUpsampling: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}prompt-upsampling", description: @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation."),
                SafetyTolerance: new Option<int?>($"--{normalizedPrefix}safety-tolerance")
                {
                    Description = @"Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.",
                }
        );
    }
}