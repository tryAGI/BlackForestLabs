#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsFlux3ImageKleinV1Flux3ImageKleinPostCommandApiCommand
{
    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"Opaque identifier for the end user supplied by the calling platform.",
    };

    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Free-form prompt describing the image.",
        Required = true,
    };

    private static Option<global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>?> Images { get; } = new(
        name: @"--images")
    {
        Description = @"Optional reference image(s), each an http(s) URL or base64, one to 10 total. The first is the image being edited and sets the default output size.",
    };

    private static Option<global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio?, string>?> AspectRatio { get; } = new(
        name: @"--aspect-ratio")
    {
        Description = @"Output aspect ratio, as in flux-3-image. `auto` (default): for edits, the first reference's exact aspect; for text-to-image, a ratio picked from the prompt (prompt rewrite, else ratio keywords, else 16:9) at the requested tier. Ignored when width and height are set.",
    };

    private static Option<global::BlackForestLabs.Flux3ImageKleinInputsResolution?> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"Equal-area size tier, as in flux-3-image: `768sq`, `1k`, `1.5k`, `2k` or `4k`. Omitted: `1k` for text-to-image; for edits the first reference's own size, or its nearest tier when aspect_ratio is set. Ignored when width and height are set.",
    };

    private static Option<int?> Width { get; } = new(
        name: @"--width")
    {
        Description = @"Exact output width in pixels, [64, 6256]; set together with height. Overrides resolution and aspect_ratio.",
    };

    private static Option<int?> Height { get; } = new(
        name: @"--height")
    {
        Description = @"Exact output height in pixels, [64, 6256]; width x height at most 16822272 pixels (16.8 MP, the largest 4k bin).",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Seed for reproducibility; random when omitted.",
    };

    private static Option<int?> SafetyTolerance { get; } = new(
        name: @"--safety-tolerance")
    {
        Description = @"Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.",
    };

    private static Option<global::BlackForestLabs.Flux3ImageKleinInputsOutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Output image format: `jpeg` (default) or `png`.",
    };

    private static Option<int?> Steps { get; } = new(
        name: @"--steps")
    {
        Description = @"Denoising steps (default 16).",
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

                    private static string FormatResponse(ParseResult parseResult, global::BlackForestLabs.AsyncResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlackForestLabs.AsyncResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"flux3-image-klein-v1-flux3-image-klein-post", @"Generate an image with FLUX 3 Image Klein.
Submits a text-to-image or image editing task with FLUX 3 Image Klein.");
                        command.Options.Add(User);
                        command.Options.Add(Prompt);
                        command.Options.Add(Images);
                        command.Options.Add(AspectRatio);
                        command.Options.Add(Resolution);
                        command.Options.Add(Width);
                        command.Options.Add(Height);
                        command.Options.Add(Seed);
                        command.Options.Add(SafetyTolerance);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(Steps);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux3ImageKleinInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var user = CliRuntime.WasSpecified(parseResult, User) ? parseResult.GetValue(User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var images = CliRuntime.WasSpecified(parseResult, Images) ? parseResult.GetValue(Images) : (__requestBase is { } __ImagesBaseValue ? __ImagesBaseValue.Images : default);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, AspectRatio) ? parseResult.GetValue(AspectRatio) : (__requestBase is { } __AspectRatioBaseValue ? __AspectRatioBaseValue.AspectRatio : default);
                        var resolution = CliRuntime.WasSpecified(parseResult, Resolution) ? parseResult.GetValue(Resolution) : (__requestBase is { } __ResolutionBaseValue ? __ResolutionBaseValue.Resolution : default);
                        var width = CliRuntime.WasSpecified(parseResult, Width) ? parseResult.GetValue(Width) : (__requestBase is { } __WidthBaseValue ? __WidthBaseValue.Width : default);
                        var height = CliRuntime.WasSpecified(parseResult, Height) ? parseResult.GetValue(Height) : (__requestBase is { } __HeightBaseValue ? __HeightBaseValue.Height : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var steps = CliRuntime.WasSpecified(parseResult, Steps) ? parseResult.GetValue(Steps) : (__requestBase is { } __StepsBaseValue ? __StepsBaseValue.Steps : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.Flux3ImageKleinV1Flux3ImageKleinPostAsync(
                                    user: user,
                                    prompt: prompt,
                                    images: images,
                                    aspectRatio: aspectRatio,
                                    resolution: resolution,
                                    width: width,
                                    height: height,
                                    seed: seed,
                                    safetyTolerance: safetyTolerance,
                                    outputFormat: outputFormat,
                                    steps: steps,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::BlackForestLabs.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}