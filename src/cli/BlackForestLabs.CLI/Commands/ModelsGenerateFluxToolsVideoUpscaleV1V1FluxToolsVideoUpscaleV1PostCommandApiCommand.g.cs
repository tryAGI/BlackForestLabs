#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostCommandApiCommand
{
    private static Option<string> InputVideo { get; } = new(
        name: @"--input-video")
    {
        Description = @"The clip to upscale: base64-encoded mp4 (max 50MB) or an http(s) URL. The upscale covers the first 20 seconds; a clip slightly over that is upscaled up to the 20 second mark, and one well over is rejected. At most 2560x1440 (3.7 megapixels) per frame: this endpoint upscales toward 4K, so downscale a larger source before submitting it.",
        Required = true,
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Optional description of the clip's content, steering the enhanced detail. Leave empty for a neutral upscale.",
    };

    private static Option<int?> Creativity { get; } = new(
        name: @"--creativity")
    {
        Description = @"Upscale behavior: 0 preserves the source precisely; 1 allows creative detail enhancement.",
    };

    private static Option<double?> UpscaleFactor { get; } = new(
        name: @"--upscale-factor")
    {
        Description = @"Output scaling relative to the source resolution, between 1.5 and 3. The output preserves the source aspect ratio and is capped at a 13.75 MP frame: very large sources are upscaled by less than the requested factor.",
    };

    private static Option<int?> SafetyTolerance { get; } = new(
        name: @"--safety-tolerance")
    {
        Description = @"Tolerance level for harm moderation, between 0 and 4 with 0 the strictest. It bounds every harm class on the prompt, which is screened before any generation, and on the delivered frames, which are withheld when their sexual-content level exceeds what the tolerance allows. Sexual is capped at level 3 and hate at level 2 regardless of the requested tolerance.",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"URL to receive the result callback.",
    };

    private static Option<string?> WebhookSecret { get; } = new(
        name: @"--webhook-secret")
    {
        Description = @"Secret echoed in the webhook signature header.",
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
        var command = new Command(@"generate-flux-tools-video-upscale-v1-v1-flux-tools-video-upscale-v1-post", @"Upscale a video with FLUX 3.
Submits a video upscaling task: 1.5x-3x super-resolution of the source clip (up to 2560x1440 in, 13.75 MP output frames). The upscale covers the first 20 seconds of the source; clips well past that are rejected. `creativity` selects precise source-faithful upscaling (0) or creative detail enhancement (1).");
                        command.Options.Add(InputVideo);
                        command.Options.Add(Prompt);
                        command.Options.Add(Creativity);
                        command.Options.Add(UpscaleFactor);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux3VideoUpscaleInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var inputVideo = parseResult.GetRequiredValue(InputVideo);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var creativity = CliRuntime.WasSpecified(parseResult, Creativity) ? parseResult.GetValue(Creativity) : (__requestBase is { } __CreativityBaseValue ? __CreativityBaseValue.Creativity : default);
                        var upscaleFactor = CliRuntime.WasSpecified(parseResult, UpscaleFactor) ? parseResult.GetValue(UpscaleFactor) : (__requestBase is { } __UpscaleFactorBaseValue ? __UpscaleFactorBaseValue.UpscaleFactor : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, WebhookSecret) ? parseResult.GetValue(WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFluxToolsVideoUpscaleV1V1FluxToolsVideoUpscaleV1PostAsync(
                                    inputVideo: inputVideo,
                                    prompt: prompt,
                                    creativity: creativity,
                                    upscaleFactor: upscaleFactor,
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