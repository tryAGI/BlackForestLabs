#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFlux2ProV1Flux2ProPostCommandApiCommand
{
    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
    };
    private static readonly Flux2InputsOptionSet Flux2InputsOptionSetOptions = Flux2InputsOptionSet.Create();
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
        var command = new Command(@"generate-flux2-pro-v1-flux2-pro-post", @"Generate or edit an image with FLUX.2 [pro]
Submits an image generation or editing task with FLUX.2 [pro]. This is the recommended default model for image editing and generation. Supports text-to-image and image-to-image editing workflows.");
                        command.Options.Add(OutputFormat);                        command.Options.Add(Flux2InputsOptionSetOptions.Prompt);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage2);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage3);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage4);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage5);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage6);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage7);
                        command.Options.Add(Flux2InputsOptionSetOptions.InputImage8);
                        command.Options.Add(Flux2InputsOptionSetOptions.Seed);
                        command.Options.Add(Flux2InputsOptionSetOptions.Width);
                        command.Options.Add(Flux2InputsOptionSetOptions.Height);
                        command.Options.Add(Flux2InputsOptionSetOptions.SafetyTolerance);
                        command.Options.Add(Flux2InputsOptionSetOptions.WebhookUrl);
                        command.Options.Add(Flux2InputsOptionSetOptions.WebhookSecret);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux2Inputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);                        var prompt = parseResult.GetRequiredValue(Flux2InputsOptionSetOptions.Prompt);
                        var inputImage = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage) : (__requestBase is { } __InputImageBaseValue ? __InputImageBaseValue.InputImage : default);
                        var inputImage2 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage2) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage2) : (__requestBase is { } __InputImage2BaseValue ? __InputImage2BaseValue.InputImage2 : default);
                        var inputImage3 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage3) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage3) : (__requestBase is { } __InputImage3BaseValue ? __InputImage3BaseValue.InputImage3 : default);
                        var inputImage4 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage4) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage4) : (__requestBase is { } __InputImage4BaseValue ? __InputImage4BaseValue.InputImage4 : default);
                        var inputImage5 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage5) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage5) : (__requestBase is { } __InputImage5BaseValue ? __InputImage5BaseValue.InputImage5 : default);
                        var inputImage6 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage6) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage6) : (__requestBase is { } __InputImage6BaseValue ? __InputImage6BaseValue.InputImage6 : default);
                        var inputImage7 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage7) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage7) : (__requestBase is { } __InputImage7BaseValue ? __InputImage7BaseValue.InputImage7 : default);
                        var inputImage8 = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.InputImage8) ? parseResult.GetValue(Flux2InputsOptionSetOptions.InputImage8) : (__requestBase is { } __InputImage8BaseValue ? __InputImage8BaseValue.InputImage8 : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.Seed) ? parseResult.GetValue(Flux2InputsOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var width = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.Width) ? parseResult.GetValue(Flux2InputsOptionSetOptions.Width) : (__requestBase is { } __WidthBaseValue ? __WidthBaseValue.Width : default);
                        var height = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.Height) ? parseResult.GetValue(Flux2InputsOptionSetOptions.Height) : (__requestBase is { } __HeightBaseValue ? __HeightBaseValue.Height : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.SafetyTolerance) ? parseResult.GetValue(Flux2InputsOptionSetOptions.SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.WebhookUrl) ? parseResult.GetValue(Flux2InputsOptionSetOptions.WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, Flux2InputsOptionSetOptions.WebhookSecret) ? parseResult.GetValue(Flux2InputsOptionSetOptions.WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFlux2ProV1Flux2ProPostAsync(
                                    outputFormat: outputFormat,
                                    prompt: prompt,
                                    inputImage: inputImage,
                                    inputImage2: inputImage2,
                                    inputImage3: inputImage3,
                                    inputImage4: inputImage4,
                                    inputImage5: inputImage5,
                                    inputImage6: inputImage6,
                                    inputImage7: inputImage7,
                                    inputImage8: inputImage8,
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