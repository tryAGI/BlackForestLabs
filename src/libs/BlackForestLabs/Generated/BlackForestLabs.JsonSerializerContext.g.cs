
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
            typeof(global::BlackForestLabs.JsonConverters.OutputFormatJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.OutputFormatNullableJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.StatusResponseJsonConverter),

            typeof(global::BlackForestLabs.JsonConverters.StatusResponseNullableJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.OutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FinetuneFluxUltraInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2FlexInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2Inputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.Flux2KleinInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxDevInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxKontextProInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxPro11Inputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxProExpandInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxProFillInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.FluxUltraInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlackForestLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.MyFinetunesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.OutpaintingInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.ResultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.StatusResponse), TypeInfoPropertyName = "StatusResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BlackForestLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BlackForestLabs.AnyOf<global::BlackForestLabs.AsyncResponse, global::BlackForestLabs.AsyncWebhookResponse>), TypeInfoPropertyName = "AnyOfAsyncResponseAsyncWebhookResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlackForestLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BlackForestLabs.AnyOf<string, int?>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}