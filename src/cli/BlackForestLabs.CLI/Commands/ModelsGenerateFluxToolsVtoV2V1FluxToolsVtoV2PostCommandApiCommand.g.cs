#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFluxToolsVtoV2V1FluxToolsVtoV2PostCommandApiCommand
{
    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
    };
    private static readonly Flux2KleinTryonInputsOptionSet Flux2KleinTryonInputsOptionSetOptions = Flux2KleinTryonInputsOptionSet.Create();
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
        var command = new Command(@"generate-flux-tools-vto-v2-v1-flux-tools-vto-v2-post", @"Virtual try-on (v2)
Submits a virtual try-on task against the v2 model. Identical request shape to /vto-v1, with reference and output resolution supported up to 4MP. Person and garment images are mapped to the underlying input image slots. An edit instruction is generated from the person and garment images, with the supplied prompt used as a fallback.");
                        command.Options.Add(OutputFormat);                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.Prompt);
                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.Person);
                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.Garment);
                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.Seed);
                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.SafetyTolerance);
                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.WebhookUrl);
                        command.Options.Add(Flux2KleinTryonInputsOptionSetOptions.WebhookSecret);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.Flux2KleinTryonInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);                        var prompt = parseResult.GetRequiredValue(Flux2KleinTryonInputsOptionSetOptions.Prompt);
                        var person = parseResult.GetRequiredValue(Flux2KleinTryonInputsOptionSetOptions.Person);
                        var garment = parseResult.GetRequiredValue(Flux2KleinTryonInputsOptionSetOptions.Garment);
                        var seed = CliRuntime.WasSpecified(parseResult, Flux2KleinTryonInputsOptionSetOptions.Seed) ? parseResult.GetValue(Flux2KleinTryonInputsOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, Flux2KleinTryonInputsOptionSetOptions.SafetyTolerance) ? parseResult.GetValue(Flux2KleinTryonInputsOptionSetOptions.SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, Flux2KleinTryonInputsOptionSetOptions.WebhookUrl) ? parseResult.GetValue(Flux2KleinTryonInputsOptionSetOptions.WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, Flux2KleinTryonInputsOptionSetOptions.WebhookSecret) ? parseResult.GetValue(Flux2KleinTryonInputsOptionSetOptions.WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFluxToolsVtoV2V1FluxToolsVtoV2PostAsync(
                                    outputFormat: outputFormat,
                                    prompt: prompt,
                                    person: person,
                                    garment: garment,
                                    seed: seed,
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