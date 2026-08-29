
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
        public global::BlackForestLabs.FinetuneFluxProFillInputs? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.OutputFormat? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FinetuneFluxUltraInput? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2DeblurInputs? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2EraseInputs? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2FlexInputs? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2Inputs? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2KleinInputs? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux2KleinTryonInputs? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputs? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio?, string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<int?, string>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputsResolution? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<double?, string>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBody? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputs? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputs? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBodyDiscriminator? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio?, string>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputsResolution? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoUpscaleInputs? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputsResolution? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxDevInputs? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxKontextProInputs? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxOutpaintingInputs? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxOutpaintingInputsMode? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxPro11Inputs? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxProExpandInputs? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxProFillInputs? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.FluxUltraInput? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.HTTPValidationError? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlackForestLabs.ValidationError>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.ValidationError? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.MyFinetunesResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.ResultResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.StatusResponse? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.SettledCostResultResponse? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<string, int?>>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, int?>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.SettledCostResultResponse, global::BlackForestLabs.ResultResponse>? Type63 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>>>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlackForestLabs.ValidationError>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<string, int?>>? ListType6 { get; set; }
    }
}