
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoDraftEnhanceInputsResolutionJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoDraftEnhanceInputsResolutionNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoI2VInputsAspectRatioJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoI2VInputsAspectRatioNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoI2VInputsResolutionJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoI2VInputsResolutionNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoInputsBodyDiscriminatorModeJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoInputsBodyDiscriminatorModeNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoT2VInputsAspectRatioJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoT2VInputsAspectRatioNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoT2VInputsResolutionJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoT2VInputsResolutionNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoV2VInputsAspectRatioJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoV2VInputsAspectRatioNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoV2VInputsResolutionJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoV2VInputsResolutionNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.FluxOutpaintingInputsModeJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.FluxOutpaintingInputsModeNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.OutputFormatJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.OutputFormatNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.StatusResponseJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.StatusResponseNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.Flux3VideoInputsBodyJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<int?, string>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>),

            typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.SettledCostResultResponse, global::BlackForestLabs.ResultResponse>),

            typeof(global::BlackForestLabs.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AsyncWebhookResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.CreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.DeleteFinetuneInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.DeleteFinetuneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FinetuneDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FinetuneFluxProFillInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.OutputFormat), TypeInfoPropertyName = "OutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FinetuneFluxUltraInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2DeblurInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2EraseInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2FlexInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2Inputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2KleinInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2KleinTryonInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution), TypeInfoPropertyName = "Flux3VideoDraftEnhanceInputsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoI2VInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio?, string>), TypeInfoPropertyName = "AnyOfFlux3VideoI2VInputsAspectRatioString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoI2VInputsAspectRatio), TypeInfoPropertyName = "Flux3VideoI2VInputsAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<int?, string>), TypeInfoPropertyName = "AnyOfInt32String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoI2VInputsResolution), TypeInfoPropertyName = "Flux3VideoI2VInputsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfDoubleStringIListStringIListIListAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<double?, string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoInputsBody), TypeInfoPropertyName = "Flux3VideoInputsBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoT2VInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoV2VInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoInputsBodyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode), TypeInfoPropertyName = "Flux3VideoInputsBodyDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio?, string>), TypeInfoPropertyName = "AnyOfFlux3VideoT2VInputsAspectRatioString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoT2VInputsAspectRatio), TypeInfoPropertyName = "Flux3VideoT2VInputsAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoT2VInputsResolution), TypeInfoPropertyName = "Flux3VideoT2VInputsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoUpscaleInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>), TypeInfoPropertyName = "AnyOfFlux3VideoV2VInputsAspectRatioString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio), TypeInfoPropertyName = "Flux3VideoV2VInputsAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux3VideoV2VInputsResolution), TypeInfoPropertyName = "Flux3VideoV2VInputsResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxDevInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxKontextProInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxOutpaintingInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxOutpaintingInputsMode), TypeInfoPropertyName = "FluxOutpaintingInputsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxPro11Inputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxProExpandInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxProFillInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxUltraInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlackForestLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.MyFinetunesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.ResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.StatusResponse), TypeInfoPropertyName = "StatusResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.SettledCostResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>), TypeInfoPropertyName = "AnyOfAsyncResponseAsyncWebhookResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<global::BlackForestLabs.SettledCostResultResponse, global::BlackForestLabs.ResultResponse>), TypeInfoPropertyName = "AnyOfSettledCostResultResponseResultResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>, global::System.Collections.Generic.List<string>, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<double?, string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlackForestLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}