#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsFluxPro10FillFinetunedV1FluxPro10FillFinetunedPostCommandApiCommand
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

    private static Option<string> Image { get; } = new(
        name: @"--image")
    {
        Description = @"A Base64-encoded string representing the image you wish to modify. Can contain alpha mask if desired.",
        Required = true,
    };

    private static Option<string?> Mask { get; } = new(
        name: @"--mask")
    {
        Description = @"A Base64-encoded string representing a mask for the areas you want to modify in the image. The mask should be the same dimensions as the image and in black and white. Black areas (0%) indicate no modification, while white areas (100%) specify areas for inpainting. Optional if you provide an alpha mask in the original image. Validation: The endpoint verifies that the dimensions of the mask match the original image.",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"The description of the changes you want to make. This text guides the inpainting process, allowing you to specify features, styles, or modifications for the masked area.",
    };

    private static Option<int?> Steps { get; } = new(
        name: @"--steps")
    {
        Description = @"Number of steps for the image generation process",
    };

    private static Option<bool?> PromptUpsampling { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--prompt-upsampling",
        description: @"Whether to perform upsampling on the prompt. If active, automatically modifies the prompt for more creative generation");

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Optional seed for reproducibility",
    };

    private static Option<double?> Guidance { get; } = new(
        name: @"--guidance")
    {
        Description = @"Guidance strength for the image generation process",
    };

    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.",
    };

    private static Option<int?> SafetyTolerance { get; } = new(
        name: @"--safety-tolerance")
    {
        Description = @"Tolerance level for input and output moderation. Between 0 and 6, 0 being most strict, 6 being least strict.",
    };

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
        var command = new Command(@"flux-pro10-fill-finetuned-v1-flux-pro10-fill-finetuned-post", @"Generate an image with FLUX.1 Fill [pro] finetune using an input image and mask.
Submits an image generation task with the FLUX.1 Fill [pro] finetune model using an input image and mask. Mask can be applied to alpha channel or submitted as a separate image.");
                        command.Options.Add(FinetuneId);
                        command.Options.Add(FinetuneStrength);
                        command.Options.Add(Image);
                        command.Options.Add(Mask);
                        command.Options.Add(Prompt);
                        command.Options.Add(Steps);
                        command.Options.Add(PromptUpsampling);
                        command.Options.Add(Seed);
                        command.Options.Add(Guidance);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(SafetyTolerance);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.FinetuneFluxProFillInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var finetuneId = parseResult.GetRequiredValue(FinetuneId);
                        var finetuneStrength = CliRuntime.WasSpecified(parseResult, FinetuneStrength) ? parseResult.GetValue(FinetuneStrength) : (__requestBase is { } __FinetuneStrengthBaseValue ? __FinetuneStrengthBaseValue.FinetuneStrength : default);
                        var image = parseResult.GetRequiredValue(Image);
                        var mask = CliRuntime.WasSpecified(parseResult, Mask) ? parseResult.GetValue(Mask) : (__requestBase is { } __MaskBaseValue ? __MaskBaseValue.Mask : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var steps = CliRuntime.WasSpecified(parseResult, Steps) ? parseResult.GetValue(Steps) : (__requestBase is { } __StepsBaseValue ? __StepsBaseValue.Steps : default);
                        var promptUpsampling = CliRuntime.WasSpecified(parseResult, PromptUpsampling) ? parseResult.GetValue(PromptUpsampling) : (__requestBase is { } __PromptUpsamplingBaseValue ? __PromptUpsamplingBaseValue.PromptUpsampling : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var guidance = CliRuntime.WasSpecified(parseResult, Guidance) ? parseResult.GetValue(Guidance) : (__requestBase is { } __GuidanceBaseValue ? __GuidanceBaseValue.Guidance : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, WebhookSecret) ? parseResult.GetValue(WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.FluxPro10FillFinetunedV1FluxPro10FillFinetunedPostAsync(
                                    finetuneId: finetuneId,
                                    finetuneStrength: finetuneStrength,
                                    image: image,
                                    mask: mask,
                                    prompt: prompt,
                                    steps: steps,
                                    promptUpsampling: promptUpsampling,
                                    seed: seed,
                                    guidance: guidance,
                                    outputFormat: outputFormat,
                                    safetyTolerance: safetyTolerance,
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