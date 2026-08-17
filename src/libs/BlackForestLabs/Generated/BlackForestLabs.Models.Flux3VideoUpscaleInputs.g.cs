
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Flux3VideoUpscaleInputs
    {
        /// <summary>
        /// The clip to upscale: base64-encoded mp4 (max 50MB) or an http(s) URL. The upscale covers the first 20 seconds; a clip slightly over that is upscaled up to the 20 second mark, and one well over is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputVideo { get; set; }

        /// <summary>
        /// Optional description of the clip's content, steering the enhanced detail. Leave empty for a neutral upscale.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Upscale behavior: 0 preserves the source precisely; 1 allows creative detail enhancement.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public int? Creativity { get; set; }

        /// <summary>
        /// Output scaling relative to the source resolution, between 1.5 and 3. The output preserves the source aspect ratio and is capped at a 13.75 MP frame: very large sources are upscaled by less than the requested factor.<br/>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// Tolerance level for harm moderation, between 0 and 4 with 0 the strictest. It bounds every harm class on the prompt, which is screened before any generation, and on the delivered frames, which are withheld when their sexual-content level exceeds what the tolerance allows. Sexual is capped at level 3 and hate at level 2 regardless of the requested tolerance.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// URL to receive the result callback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Secret echoed in the webhook signature header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoUpscaleInputs" /> class.
        /// </summary>
        /// <param name="inputVideo">
        /// The clip to upscale: base64-encoded mp4 (max 50MB) or an http(s) URL. The upscale covers the first 20 seconds; a clip slightly over that is upscaled up to the 20 second mark, and one well over is rejected.
        /// </param>
        /// <param name="prompt">
        /// Optional description of the clip's content, steering the enhanced detail. Leave empty for a neutral upscale.
        /// </param>
        /// <param name="creativity">
        /// Upscale behavior: 0 preserves the source precisely; 1 allows creative detail enhancement.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="upscaleFactor">
        /// Output scaling relative to the source resolution, between 1.5 and 3. The output preserves the source aspect ratio and is capped at a 13.75 MP frame: very large sources are upscaled by less than the requested factor.<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for harm moderation, between 0 and 4 with 0 the strictest. It bounds every harm class on the prompt, which is screened before any generation, and on the delivered frames, which are withheld when their sexual-content level exceeds what the tolerance allows. Sexual is capped at level 3 and hate at level 2 regardless of the requested tolerance.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive the result callback.
        /// </param>
        /// <param name="webhookSecret">
        /// Secret echoed in the webhook signature header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3VideoUpscaleInputs(
            string inputVideo,
            string? prompt,
            int? creativity,
            double? upscaleFactor,
            int? safetyTolerance,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.InputVideo = inputVideo ?? throw new global::System.ArgumentNullException(nameof(inputVideo));
            this.Prompt = prompt;
            this.Creativity = creativity;
            this.UpscaleFactor = upscaleFactor;
            this.SafetyTolerance = safetyTolerance;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoUpscaleInputs" /> class.
        /// </summary>
        public Flux3VideoUpscaleInputs()
        {
        }

    }
}