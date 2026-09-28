#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(DefaultApiGroupCommand.Create());
                         command.Subcommands.Add(ModelsApiGroupCommand.Create());
                         command.Subcommands.Add(UtilityApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}