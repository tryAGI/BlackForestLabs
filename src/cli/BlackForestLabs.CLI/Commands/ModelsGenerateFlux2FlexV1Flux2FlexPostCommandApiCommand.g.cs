#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFlux2FlexV1Flux2FlexPostCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Text prompt for image generation.",
        Required = true,
    };

    private static Option<bool?> PromptUpsampling { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--prompt-upsampling",
        description: @"Whether to use prompt upsampling.");

    private static Option<string?> InputImage { get; } = new(
        name: @"--input-image")
    {
        Description = @"Path to the input image.",
    };

    private static Option<string?> InputImage2 { get; } = new(
        name: @"--input-image-2")
    {
        Description = @"Path to the second input image.",
    };

    private static Option<string?> InputImage3 { get; } = new(
        name: @"--input-image-3")
    {
        Description = @"Path to the third input image.",
    };

    private static Option<string?> InputImage4 { get; } = new(
        name: @"--input-image-4")
    {
        Description = @"Path to the fourth input image.",
    };

    private static Option<string?> InputImage5 { get; } = new(
        name: @"--input-image-5")
    {
        Description = @"Path to the fifth input image.",
    };

    private static Option<string?> InputImage6 { get; } = new(
        name: @"--input-image-6")
    {
        Description = @"Path to the sixth input image.",
    };

    private static Option<string?> InputImage7 { get; } = new(
        name: @"--input-image-7")
    {
        Description = @"Path to the seventh input image.",
    };

    private static Option<string?> InputImage8 { get; } = new(
        name: @"--input-image-8")
    {
        Description = @"Path to the eighth input image.",
    };

    private static Option<string?> InputImageBlobPath { get; } = new(
        name: @"--input-image-blob-path")
    {
        Description = @"Blob path to the input image.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Optional seed for reproducibility.",
    };

    private static Option<int?> Width { get; } = new(
        name: @"--width")
    {
        Description = @"Width of the image",
    };

    private static Option<int?> Height { get; } = new(
        name: @"--height")
    {
        Description = @"Height of the image",
    };

    private static Option<double?> Guidance { get; } = new(
        name: @"--guidance")
    {
        Description = @"Guidance scale for image generation. High guidance scales improve prompt adherence at the cost of reduced realism.",
    };

    private static Option<int?> Steps { get; } = new(
        name: @"--steps")
    {
        Description = @"Number of steps for image generation. Higher steps lead to more detailed and realistic images.",
    };

    private static Option<int?> SafetyTolerance { get; } = new(
        name: @"--safety-tolerance")
    {
        Description = @"Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.",
    };

    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
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
        var command = new Command(@"generate-flux2-flex-v1-flux2-flex-post", @"Generate or edit an image with FLUX.2 [FLEX] (recommended for editing)
Submits an image generation or editing task with FLUX.2 [FLEX]. This is a recommended model for image editing and generation. Supports flexible text-to-image and image-to-image editing workflows.");
                        command.Options.Add(Prompt);
                        command.Options.Add(PromptUpsampling);
                        command.Options.Add(InputImage);
                        command.Options.Add(InputImage2);
                        command.Options.Add(InputImage3);
                        command.Options.Add(InputImage4);
                        command.Options.Add(InputImage5);
                        command.Options.Add(InputImage6);
                        command.Options.Add(InputImage7);
                        command.Options.Add(InputImage8);
                        command.Options.Add(InputImageBlobPath);
                        command.Options.Add(Seed);
                        command.Options.Add(Width);
                        command.Options.Add(Height);
                        command.Options.Add(Guidance);
                        command.Options.Add(Steps);
                        command.Options.Add(SafetyTolerance);
                        command.Options.Add(OutputFormat);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux2FlexInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var promptUpsampling = CliRuntime.WasSpecified(parseResult, PromptUpsampling) ? parseResult.GetValue(PromptUpsampling) : (__requestBase is { } __PromptUpsamplingBaseValue ? __PromptUpsamplingBaseValue.PromptUpsampling : default);
                        var inputImage = CliRuntime.WasSpecified(parseResult, InputImage) ? parseResult.GetValue(InputImage) : (__requestBase is { } __InputImageBaseValue ? __InputImageBaseValue.InputImage : default);
                        var inputImage2 = CliRuntime.WasSpecified(parseResult, InputImage2) ? parseResult.GetValue(InputImage2) : (__requestBase is { } __InputImage2BaseValue ? __InputImage2BaseValue.InputImage2 : default);
                        var inputImage3 = CliRuntime.WasSpecified(parseResult, InputImage3) ? parseResult.GetValue(InputImage3) : (__requestBase is { } __InputImage3BaseValue ? __InputImage3BaseValue.InputImage3 : default);
                        var inputImage4 = CliRuntime.WasSpecified(parseResult, InputImage4) ? parseResult.GetValue(InputImage4) : (__requestBase is { } __InputImage4BaseValue ? __InputImage4BaseValue.InputImage4 : default);
                        var inputImage5 = CliRuntime.WasSpecified(parseResult, InputImage5) ? parseResult.GetValue(InputImage5) : (__requestBase is { } __InputImage5BaseValue ? __InputImage5BaseValue.InputImage5 : default);
                        var inputImage6 = CliRuntime.WasSpecified(parseResult, InputImage6) ? parseResult.GetValue(InputImage6) : (__requestBase is { } __InputImage6BaseValue ? __InputImage6BaseValue.InputImage6 : default);
                        var inputImage7 = CliRuntime.WasSpecified(parseResult, InputImage7) ? parseResult.GetValue(InputImage7) : (__requestBase is { } __InputImage7BaseValue ? __InputImage7BaseValue.InputImage7 : default);
                        var inputImage8 = CliRuntime.WasSpecified(parseResult, InputImage8) ? parseResult.GetValue(InputImage8) : (__requestBase is { } __InputImage8BaseValue ? __InputImage8BaseValue.InputImage8 : default);
                        var inputImageBlobPath = CliRuntime.WasSpecified(parseResult, InputImageBlobPath) ? parseResult.GetValue(InputImageBlobPath) : (__requestBase is { } __InputImageBlobPathBaseValue ? __InputImageBlobPathBaseValue.InputImageBlobPath : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var width = CliRuntime.WasSpecified(parseResult, Width) ? parseResult.GetValue(Width) : (__requestBase is { } __WidthBaseValue ? __WidthBaseValue.Width : default);
                        var height = CliRuntime.WasSpecified(parseResult, Height) ? parseResult.GetValue(Height) : (__requestBase is { } __HeightBaseValue ? __HeightBaseValue.Height : default);
                        var guidance = CliRuntime.WasSpecified(parseResult, Guidance) ? parseResult.GetValue(Guidance) : (__requestBase is { } __GuidanceBaseValue ? __GuidanceBaseValue.Guidance : default);
                        var steps = CliRuntime.WasSpecified(parseResult, Steps) ? parseResult.GetValue(Steps) : (__requestBase is { } __StepsBaseValue ? __StepsBaseValue.Steps : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, WebhookSecret) ? parseResult.GetValue(WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFlux2FlexV1Flux2FlexPostAsync(
                                    prompt: prompt,
                                    promptUpsampling: promptUpsampling,
                                    inputImage: inputImage,
                                    inputImage2: inputImage2,
                                    inputImage3: inputImage3,
                                    inputImage4: inputImage4,
                                    inputImage5: inputImage5,
                                    inputImage6: inputImage6,
                                    inputImage7: inputImage7,
                                    inputImage8: inputImage8,
                                    inputImageBlobPath: inputImageBlobPath,
                                    seed: seed,
                                    width: width,
                                    height: height,
                                    guidance: guidance,
                                    steps: steps,
                                    safetyTolerance: safetyTolerance,
                                    outputFormat: outputFormat,
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