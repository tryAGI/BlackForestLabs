#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostCommandApiCommand
{
    private static Option<string> FinetuneId { get; } = new(
        name: @"--finetune-id")
    {
        Description = @"Name of the LoRA to use. For LoRAs from other organizations (public or shared), use the format 'org-id/lora-name'.",
        Required = true,
    };

    private static Option<double?> FinetuneStrength { get; } = new(
        name: @"--finetune-strength")
    {
        Description = @"Strength of the fine-tuned model. 0.0 means no influence, 1.0 means full influence. Allowed values up to 2.0",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"The prompt to use for image generation.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Optional seed for reproducibility. If not provided, a random seed will be used.",
    };

    private static Option<string?> AspectRatio { get; } = new(
        name: @"--aspect-ratio")
    {
        Description = @"Aspect ratio of the image between 21:9 and 9:21",
    };

    private static Option<int?> SafetyTolerance { get; } = new(
        name: @"--safety-tolerance")
    {
        Description = @"Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.",
    };

    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.",
    };

    private static Option<string?> ImagePrompt { get; } = new(
        name: @"--image-prompt")
    {
        Description = @"Optional image to remix in base64 format",
    };

    private static Option<double?> ImagePromptStrength { get; } = new(
        name: @"--image-prompt-strength")
    {
        Description = @"Blend between the prompt and the image prompt",
    };

    private static Option<bool?> PromptUpsampling { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--prompt-upsampling",
        description: @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation");

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"URL to receive webhook notifications",
    };

    private static Option<string?> WebhookSecret { get; } = new(
        name: @"--webhook-secret")
    {
        Description = @"Optional secret for webhook signature verification",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-bigblue-finetuned-v1-flux-pro11-ultra-finetuned-post", @"Generate an image with FLUX 1.1 [pro] finetune with ultra mode.
Submits an image generation task with FLUX 1.1 [pro] finetune with ultra mode.");
                        command.Options.Add(FinetuneId);
                        command.Options.Add(FinetuneStrength);
                        command.Options.Add(Prompt);
                        command.Options.Add(Seed);
                        command.Options.Add(AspectRatio);
                        command.Options.Add(SafetyTolerance);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(ImagePrompt);
                        command.Options.Add(ImagePromptStrength);
                        command.Options.Add(PromptUpsampling);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(WebhookSecret);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.FinetuneFluxUltraInput>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var finetuneId = parseResult.GetRequiredValue(FinetuneId);
                        var finetuneStrength = CliRuntime.WasSpecified(parseResult, FinetuneStrength) ? parseResult.GetValue(FinetuneStrength) : (__requestBase is { } __FinetuneStrengthBaseValue ? __FinetuneStrengthBaseValue.FinetuneStrength : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, AspectRatio) ? parseResult.GetValue(AspectRatio) : (__requestBase is { } __AspectRatioBaseValue ? __AspectRatioBaseValue.AspectRatio : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var imagePrompt = CliRuntime.WasSpecified(parseResult, ImagePrompt) ? parseResult.GetValue(ImagePrompt) : (__requestBase is { } __ImagePromptBaseValue ? __ImagePromptBaseValue.ImagePrompt : default);
                        var imagePromptStrength = CliRuntime.WasSpecified(parseResult, ImagePromptStrength) ? parseResult.GetValue(ImagePromptStrength) : (__requestBase is { } __ImagePromptStrengthBaseValue ? __ImagePromptStrengthBaseValue.ImagePromptStrength : default);
                        var promptUpsampling = CliRuntime.WasSpecified(parseResult, PromptUpsampling) ? parseResult.GetValue(PromptUpsampling) : (__requestBase is { } __PromptUpsamplingBaseValue ? __PromptUpsamplingBaseValue.PromptUpsampling : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, WebhookSecret) ? parseResult.GetValue(WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostAsync(
                                    finetuneId: finetuneId,
                                    finetuneStrength: finetuneStrength,
                                    prompt: prompt,
                                    seed: seed,
                                    aspectRatio: aspectRatio,
                                    safetyTolerance: safetyTolerance,
                                    outputFormat: outputFormat,
                                    imagePrompt: imagePrompt,
                                    imagePromptStrength: imagePromptStrength,
                                    promptUpsampling: promptUpsampling,
                                    webhookUrl: webhookUrl,
                                    webhookSecret: webhookSecret,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BlackForestLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}