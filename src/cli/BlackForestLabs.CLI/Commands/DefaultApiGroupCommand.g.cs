#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static class DefaultApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(GetCreditsV1CreditsGetCommandApiCommand.Create());
        return command;
    }
}