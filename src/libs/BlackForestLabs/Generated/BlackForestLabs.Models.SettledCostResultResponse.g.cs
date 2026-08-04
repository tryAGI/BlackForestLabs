
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SettledCostResultResponse
    {
        /// <summary>
        /// Task id for retrieving result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.StatusResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::BlackForestLabs.StatusResponse Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public object? Preview { get; set; }

        /// <summary>
        /// Settled cost in credits for this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SettledCostResultResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Task id for retrieving result
        /// </param>
        /// <param name="status"></param>
        /// <param name="cost">
        /// Settled cost in credits for this request
        /// </param>
        /// <param name="result"></param>
        /// <param name="progress"></param>
        /// <param name="details"></param>
        /// <param name="preview"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SettledCostResultResponse(
            string id,
            global::BlackForestLabs.StatusResponse status,
            double cost,
            object? result,
            double? progress,
            object? details,
            object? preview)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Result = result;
            this.Progress = progress;
            this.Details = details;
            this.Preview = preview;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettledCostResultResponse" /> class.
        /// </summary>
        public SettledCostResultResponse()
        {
        }

    }
}