#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static class UtilityApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"utility", @"Utility endpoint commands.");
                         command.Subcommands.Add(UtilityDeleteFinetuneV1DeleteFinetunePostCommandApiCommand.Create());
                         command.Subcommands.Add(UtilityFinetuneDetailsV1FinetuneDetailsGetCommandApiCommand.Create());
                         command.Subcommands.Add(UtilityGetResultV1GetResultGetCommandApiCommand.Create());
                         command.Subcommands.Add(UtilityMyFinetunesV1MyFinetunesGetCommandApiCommand.Create());
        return command;
    }
}