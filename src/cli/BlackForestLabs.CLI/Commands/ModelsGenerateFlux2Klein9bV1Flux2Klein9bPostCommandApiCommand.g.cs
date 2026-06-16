#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFlux2Klein9bV1Flux2Klein9bPostCommandApiCommand
{
    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
    };
    private static readonly Flux2KleinInputsOptionSet Flux2KleinInputsOptionSetOptions = Flux2KleinInputsOptionSet.Create();
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
        var command = new Command(@"generate-flux2-klein9b-v1-flux2-klein9b-post", @"Generate or edit an image with FLUX.2 [klein] 9B
Submits an image generation or editing task with FLUX.2 [klein] 9B. Sub-second inference with open weights, balancing quality and speed.");
                        command.Options.Add(OutputFormat);                        command.Options.Add(Flux2KleinInputsOptionSetOptions.Prompt);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.InputImage);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.InputImage2);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.InputImage3);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.InputImage4);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.Seed);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.Width);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.Height);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.SafetyTolerance);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.WebhookUrl);
                        command.Options.Add(Flux2KleinInputsOptionSetOptions.WebhookSecret);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux2KleinInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);                        var prompt = parseResult.GetRequiredValue(Flux2KleinInputsOptionSetOptions.Prompt);
                        var inputImage = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.InputImage) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.InputImage) : (__requestBase is { } __InputImageBaseValue ? __InputImageBaseValue.InputImage : default);
                        var inputImage2 = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.InputImage2) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.InputImage2) : (__requestBase is { } __InputImage2BaseValue ? __InputImage2BaseValue.InputImage2 : default);
                        var inputImage3 = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.InputImage3) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.InputImage3) : (__requestBase is { } __InputImage3BaseValue ? __InputImage3BaseValue.InputImage3 : default);
                        var inputImage4 = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.InputImage4) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.InputImage4) : (__requestBase is { } __InputImage4BaseValue ? __InputImage4BaseValue.InputImage4 : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.Seed) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var width = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.Width) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.Width) : (__requestBase is { } __WidthBaseValue ? __WidthBaseValue.Width : default);
                        var height = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.Height) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.Height) : (__requestBase is { } __HeightBaseValue ? __HeightBaseValue.Height : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.SafetyTolerance) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.WebhookUrl) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, Flux2KleinInputsOptionSetOptions.WebhookSecret) ? parseResult.GetValue(Flux2KleinInputsOptionSetOptions.WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFlux2Klein9bV1Flux2Klein9bPostAsync(
                                    outputFormat: outputFormat,
                                    prompt: prompt,
                                    inputImage: inputImage,
                                    inputImage2: inputImage2,
                                    inputImage3: inputImage3,
                                    inputImage4: inputImage4,
                                    seed: seed,
                                    width: width,
                                    height: height,
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