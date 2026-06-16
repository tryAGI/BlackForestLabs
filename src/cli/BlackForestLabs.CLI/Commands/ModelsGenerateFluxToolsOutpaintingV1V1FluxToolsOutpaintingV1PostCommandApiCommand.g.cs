#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFluxToolsOutpaintingV1V1FluxToolsOutpaintingV1PostCommandApiCommand
{
    private static Option<string> InputImage { get; } = new(
        name: @"--input-image")
    {
        Description = @"Base64-encoded input (reference) image or HTTP(S) image URL.",
        Required = true,
    };

    private static Option<int> Width { get; } = new(
        name: @"--width")
    {
        Description = @"Target output width.",
        Required = true,
    };

    private static Option<int> Height { get; } = new(
        name: @"--height")
    {
        Description = @"Target output height.",
        Required = true,
    };

    private static Option<bool?> AutoCrop { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--auto-crop",
        description: @"If True, crop the input image to the canvas bounds when it extends beyond the edges. If False, an error is raised instead.");

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

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Experimental: optional text guidance for the outpainted region. The model may not strictly follow this prompt; the visual content of the input image is the primary signal. Leave unset for default behavior.",
    };

    private static Option<int?> ReferenceOffsetX { get; } = new(
        name: @"--reference-offset-x")
    {
        Description = @"Left offset (px) of the reference image's top-left corner on the output canvas. Negative values are allowed. None = center horizontally.",
    };

    private static Option<int?> ReferenceOffsetY { get; } = new(
        name: @"--reference-offset-y")
    {
        Description = @"Top offset (px) of the reference image's top-left corner on the output canvas. Negative values are allowed. None = center vertically.",
    };

    private static Option<global::BlackForestLabs.FluxOutpaintingInputsMode?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"Quality/speed trade-off. 'high' (default): highest-fidelity results, recommended whenever fine detail, prompt adherence, or consistency with complex content in the source image matters; slower. 'fast': significantly faster and well-suited for naturally extending most scenes (landscapes, backgrounds, textures, products); may produce lower fidelity in the extended region than 'high'.",
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
        var command = new Command(@"generate-flux-tools-outpainting-v1-v1-flux-tools-outpainting-v1-post", @"Outpaint or extend an image
Submits an outpainting task. The input image is placed on a (width, height) canvas at the given offset, and the surrounding region is generated by a FLUX outpainting model.");
                        command.Options.Add(InputImage);
                        command.Options.Add(Width);
                        command.Options.Add(Height);
                        command.Options.Add(AutoCrop);
                        command.Options.Add(SafetyTolerance);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(Prompt);
                        command.Options.Add(ReferenceOffsetX);
                        command.Options.Add(ReferenceOffsetY);
                        command.Options.Add(Mode);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.FluxOutpaintingInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var inputImage = parseResult.GetRequiredValue(InputImage);
                        var width = parseResult.GetRequiredValue(Width);
                        var height = parseResult.GetRequiredValue(Height);
                        var autoCrop = CliRuntime.WasSpecified(parseResult, AutoCrop) ? parseResult.GetValue(AutoCrop) : (__requestBase is { } __AutoCropBaseValue ? __AutoCropBaseValue.AutoCrop : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var referenceOffsetX = CliRuntime.WasSpecified(parseResult, ReferenceOffsetX) ? parseResult.GetValue(ReferenceOffsetX) : (__requestBase is { } __ReferenceOffsetXBaseValue ? __ReferenceOffsetXBaseValue.ReferenceOffsetX : default);
                        var referenceOffsetY = CliRuntime.WasSpecified(parseResult, ReferenceOffsetY) ? parseResult.GetValue(ReferenceOffsetY) : (__requestBase is { } __ReferenceOffsetYBaseValue ? __ReferenceOffsetYBaseValue.ReferenceOffsetY : default);
                        var mode = CliRuntime.WasSpecified(parseResult, Mode) ? parseResult.GetValue(Mode) : (__requestBase is { } __ModeBaseValue ? __ModeBaseValue.Mode : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFluxToolsOutpaintingV1V1FluxToolsOutpaintingV1PostAsync(
                                    inputImage: inputImage,
                                    width: width,
                                    height: height,
                                    autoCrop: autoCrop,
                                    safetyTolerance: safetyTolerance,
                                    outputFormat: outputFormat,
                                    prompt: prompt,
                                    referenceOffsetX: referenceOffsetX,
                                    referenceOffsetY: referenceOffsetY,
                                    mode: mode,
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