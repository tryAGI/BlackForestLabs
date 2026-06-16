#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ModelsGenerateFluxKontextMaxV1FluxKontextMaxPostCommandApiCommand
{
    private static Option<global::BlackForestLabs.OutputFormat?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Output format for the generated image. Can be 'jpeg', 'png', or 'webp'.",
    };
    private static readonly FluxKontextProInputsOptionSet FluxKontextProInputsOptionSetOptions = FluxKontextProInputsOptionSet.Create();
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
        var command = new Command(@"generate-flux-kontext-max-v1-flux-kontext-max-post", @"Create an image with FLUX.1 Kontext [max] (legacy, use FLUX.2 [PRO] for editing)
Submits an image creation task with FLUX.1 Kontext [max]. For image editing, prefer FLUX.2 [PRO] (/flux-2-pro) or FLUX.2 [FLEX] (/flux-2-flex) which are the recommended default models for editing workflows.");
                        command.Options.Add(OutputFormat);                        command.Options.Add(FluxKontextProInputsOptionSetOptions.Prompt);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.InputImage);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.InputImage2);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.InputImage3);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.InputImage4);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.Seed);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.AspectRatio);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.WebhookUrl);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.WebhookSecret);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.PromptUpsampling);
                        command.Options.Add(FluxKontextProInputsOptionSetOptions.SafetyTolerance);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::BlackForestLabs.FluxKontextProInputs>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::BlackForestLabs.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);                        var prompt = parseResult.GetRequiredValue(FluxKontextProInputsOptionSetOptions.Prompt);
                        var inputImage = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.InputImage) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.InputImage) : (__requestBase is { } __InputImageBaseValue ? __InputImageBaseValue.InputImage : default);
                        var inputImage2 = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.InputImage2) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.InputImage2) : (__requestBase is { } __InputImage2BaseValue ? __InputImage2BaseValue.InputImage2 : default);
                        var inputImage3 = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.InputImage3) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.InputImage3) : (__requestBase is { } __InputImage3BaseValue ? __InputImage3BaseValue.InputImage3 : default);
                        var inputImage4 = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.InputImage4) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.InputImage4) : (__requestBase is { } __InputImage4BaseValue ? __InputImage4BaseValue.InputImage4 : default);
                        var seed = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.Seed) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.AspectRatio) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.AspectRatio) : (__requestBase is { } __AspectRatioBaseValue ? __AspectRatioBaseValue.AspectRatio : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.WebhookUrl) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var webhookSecret = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.WebhookSecret) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.WebhookSecret) : (__requestBase is { } __WebhookSecretBaseValue ? __WebhookSecretBaseValue.WebhookSecret : default);
                        var promptUpsampling = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.PromptUpsampling) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.PromptUpsampling) : (__requestBase is { } __PromptUpsamplingBaseValue ? __PromptUpsamplingBaseValue.PromptUpsampling : default);
                        var safetyTolerance = CliRuntime.WasSpecified(parseResult, FluxKontextProInputsOptionSetOptions.SafetyTolerance) ? parseResult.GetValue(FluxKontextProInputsOptionSetOptions.SafetyTolerance) : (__requestBase is { } __SafetyToleranceBaseValue ? __SafetyToleranceBaseValue.SafetyTolerance : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Models.GenerateFluxKontextMaxV1FluxKontextMaxPostAsync(
                                    outputFormat: outputFormat,
                                    prompt: prompt,
                                    inputImage: inputImage,
                                    inputImage2: inputImage2,
                                    inputImage3: inputImage3,
                                    inputImage4: inputImage4,
                                    seed: seed,
                                    aspectRatio: aspectRatio,
                                    webhookUrl: webhookUrl,
                                    webhookSecret: webhookSecret,
                                    promptUpsampling: promptUpsampling,
                                    safetyTolerance: safetyTolerance,
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