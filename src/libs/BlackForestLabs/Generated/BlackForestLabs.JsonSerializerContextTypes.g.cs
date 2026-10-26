
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AsyncResponse? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AsyncWebhookResponse? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.CreditsResponse? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.DeleteFinetuneInputs? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.DeleteFinetuneResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FinetuneDetailResponse? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FinetuneFluxUltraInput? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.OutputFormat? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2DeblurInputs? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2EraseInputs? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2FlexInputs? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2Inputs? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2KleinInputs? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2KleinTryonInputs? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageInputs? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageInputsAspectRatio? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageInputsResolution? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageKleinInputs? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio?, string>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageKleinInputsResolution? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3ImageKleinInputsOutputFormat? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputs? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio?, string>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<int?, string>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputsResolution? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<double?, string>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBody? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputs? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputs? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBodyDiscriminator? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio?, string>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputsResolution? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoUpscaleInputs? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputsResolution? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoVE2VNamedInputs? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxDevInputs? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxKontextProInputs? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxOutpaintingInputs? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxOutpaintingInputsMode? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxPro11Inputs? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxProExpandInputs? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxProFillInputs? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxUltraInput? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.HTTPValidationError? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlackForestLabs.ValidationError>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.ValidationError? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.MyFinetunesResponse? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.ResultResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.StatusResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.SettledCostResultResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<string, int?>>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, int?>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.SettledCostResultResponse, global::BlackForestLabs.ResultResponse>? Type73 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlackForestLabs.ValidationError>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<string, int?>>? ListType7 { get; set; }
    }
}