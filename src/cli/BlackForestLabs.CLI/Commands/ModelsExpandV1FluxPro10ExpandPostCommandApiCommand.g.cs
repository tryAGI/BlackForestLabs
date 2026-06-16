#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsExpandV1FluxPro10ExpandPostCommandApiCommand
{
    private static Option<string> Image { get; } = new(
        name: @"--image")
    {
        Description = @"A Base64-encoded string representing the image you wish to expand.",
        Required = true,
    };

    private static Option<int?> Top { get; } = new(
        name: @"--top")
    {
        Description = @"Number of pixels to expand at the top of the image",
    };

    private static Option<int?> Bottom { get; } = new(
        name: @"--bottom")
    {
        Description = @"Number of pixels to expand at the bottom of the image",
    };

    private static Option<int?> Left { get; } = new(
        name: @"--left")
    {
        Description = @"Number of pixels to expand on the left side of the image",
    };

    private static Option<int?> Right { get; } = new(
        name: @"--right")
    {
        Description = @"Number of pixels to expand on the right side of the image",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"The description of the changes you want to make. This text guides the expansion process, allowing you to specify features, styles, or modifications for the expanded areas.",
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
        var command = new Command(@"expand-v1-flux-pro10-expand-post", @"Expand an image by adding pixels on any side.
Submits an image expansion task that adds the specified number of pixels to any combination of sides (top, bottom, left, right) while maintaining context.");
                        command.Options.Add(Image);
                        command.Options.Add(Top);
                        command.Options.Add(Bottom);
                        command.Options.Add(Left);
                        command.Options.Add(Right);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.FluxProExpandInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var image = parseResult.GetRequiredValue(Image);
                        var top = CliRuntime.WasSpecified(parseResult, Top) ? parseResult.GetValue(Top) : (__requestBase is { } __TopBaseValue ? __TopBaseValue.Top : default);
                        var bottom = CliRuntime.WasSpecified(parseResult, Bottom) ? parseResult.GetValue(Bottom) : (__requestBase is { } __BottomBaseValue ? __BottomBaseValue.Bottom : default);
                        var left = CliRuntime.WasSpecified(parseResult, Left) ? parseResult.GetValue(Left) : (__requestBase is { } __LeftBaseValue ? __LeftBaseValue.Left : default);
                        var right = CliRuntime.WasSpecified(parseResult, Right) ? parseResult.GetValue(Right) : (__requestBase is { } __RightBaseValue ? __RightBaseValue.Right : default);
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


                                var response = await client.Models.ExpandV1FluxPro10ExpandPostAsync(
                                    image: image,
                                    top: top,
                                    bottom: bottom,
                                    left: left,
                                    right: right,
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