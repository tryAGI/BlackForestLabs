#nullable enable

using System.CommandLine;

namespace BlackForestLabs.CLI.Commands;

internal static class ModelsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"models", @"Models endpoint commands.");
                         command.Subcommands.Add(ModelsExpandV1FluxPro10ExpandPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsFillV1FluxPro10FillPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsFlux3VideoV1Flux3VideoPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsFluxDevV1FluxDevPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsFluxPro10FillFinetunedV1FluxPro10FillFinetunedPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsFluxPro11V1FluxPro11PostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateBigblueFinetunedV1FluxPro11UltraFinetunedPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux11UltraV1FluxPro11UltraPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2FlexV1Flux2FlexPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2Klein4bV1Flux2Klein4bPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2Klein9bKvV1Flux2Klein9bPreviewPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2Klein9bV1Flux2Klein9bPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2MaxV1Flux2MaxPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2ProPreviewV1Flux2ProPreviewPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFlux2ProV1Flux2ProPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxKontextMaxV1FluxKontextMaxPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxKontextProV1FluxKontextProPostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxToolsDeblurV1V1FluxToolsDeblurV1PostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxToolsEraseV1V1FluxToolsEraseV1PostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxToolsOutpaintingV1V1FluxToolsOutpaintingV1PostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxToolsVtoV1V1FluxToolsVtoV1PostCommandApiCommand.Create());
                         command.Subcommands.Add(ModelsGenerateFluxToolsVtoV2V1FluxToolsVtoV2PostCommandApiCommand.Create());
        return command;
    }
}