#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsFlux3ImageV1Flux3ImagePostCommandApiCommand
{
    private static Option<string> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Free-form prompt describing the image.",
        Required = true,
    };

    private static Option<global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>?> Images { get; } = new(
        name: @"--images")
    {
        Description = @"Optional reference image(s) the prompt edits or draws from; each is an http(s) URL or base64, one to 10 total.",
    };

    private static Option<global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>?> AspectRatio { get; } = new(
        name: @"--aspect-ratio")
    {
        Description = @"Output aspect ratio. Under `auto` a ratio the prompt asks for wins, otherwise the output keeps the first reference image's framing; without references the prompt decides, else 1:1.",
    };

    private static Option<global::BlackForestLabs.Flux3ImageInputsResolution?> Resolution { get; } = new(
        name: @"--resolution")
    {
        Description = @"Image resolution class, an equal-pixel-area tier: `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.",
    };

    private static Option<int?> SafetyTolerance { get; } = new(
        name: @"--safety-tolerance")
    {
        Description = @"Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest.",
    };

    private static Option<bool?> Grounding { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--grounding",
        description: @"When true (default) the prompt may be grounded in external research: web search and image search. When false, both are off.");

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Endpoint version. `latest` (default) serves the current release; dated pinnable release tags are added here as they are published.",
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
        var command = new Command(commandName ?? @"flux3-image-v1-flux3-image-post", @"Generate an image with FLUX 3.
Submits an image generation task with FLUX 3.");
                        command.Options.Add(Prompt);
                        command.Options.Add(Images);
                        command.Options.Add(AspectRatio);
                        command.Options.Add(Resolution);
                        command.Options.Add(SafetyTolerance);
                        command.Options.Add(Grounding);
                        command.Options.Add(Version);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux3ImageInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var prompt = parseResult.GetRequiredValue(Prompt);
                        var images = CliRuntime.WasSpecified(parseResult, Images) ? parseResult.GetValue(Images) : (__requestBase is { } __ImagesBaseValue ? __ImagesBaseValue.Images : default);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, AspectRatio) ? parseResult.GetValue(AspectRatio) : (__requestBase is { } __AspectRatioBaseValue ? __AspectRatioBaseValue.AspectRatio : default);
                        var resolution = CliRuntime.WasSpecified(parseResult, Resolution) ? parseResult.GetValue(Resolution) : (__requestBase is { } __ResolutionBaseValue ? __ResolutionBaseValue.Resolution : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, SafetyTolerance) ? parseResult.GetValue(SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var grounding = CliRuntime.WasSpecified(parseResult, Grounding) ? parseResult.GetValue(Grounding) : (__requestBase is { } __GroundingBaseValue ? __GroundingBaseValue.Grounding : default);
                        var version = CliRuntime.WasSpecified(parseResult, Version) ? parseResult.GetValue(Version) : (__requestBase is { } __VersionBaseValue ? __VersionBaseValue.Version : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.Flux3ImageV1Flux3ImagePostAsync(
                                    prompt: prompt,
                                    images: images,
                                    aspectRatio: aspectRatio,
                                    resolution: resolution,
                                    safetyTolerance: safetyTolerance,
                                    grounding: grounding,
                                    version: version,
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