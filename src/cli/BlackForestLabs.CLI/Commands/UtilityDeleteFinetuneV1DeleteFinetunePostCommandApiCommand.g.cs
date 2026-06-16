#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class UtilityDeleteFinetuneV1DeleteFinetunePostCommandApiCommand
{
    private static Option<string> FinetuneId { get; } = new(
        name: @"--finetune-id")
    {
        Description = @"Name of the LoRA to delete.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::BlackForestLabs.DeleteFinetuneResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::BlackForestLabs.DeleteFinetuneResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-finetune-v1-delete-finetune-post", @"Delete Finetune
Delete a finetune_id that was created by the user");
                        command.Options.Add(FinetuneId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var finetuneId = parseResult.GetRequiredValue(FinetuneId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Utility.DeleteFinetuneV1DeleteFinetunePostAsync(
                                    finetuneId: finetuneId,
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