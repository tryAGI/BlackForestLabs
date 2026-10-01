
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Flux3ImageInputs
    {
        /// <summary>
        /// Free-form prompt describing the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional reference image(s) the prompt edits or draws from; each is an http(s) URL or base64, one to 10 total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? Images { get; set; }

        /// <summary>
        /// Output aspect ratio. Under `auto` a ratio the prompt asks for wins, otherwise the output keeps the first reference image's framing; without references the prompt decides, else 1:1.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>))]
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>? AspectRatio { get; set; }

        /// <summary>
        /// Image resolution class, an equal-pixel-area tier: `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.<br/>
        /// Default Value: 1k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.Flux3ImageInputsResolutionJsonConverter))]
        public global::BlackForestLabs.Flux3ImageInputsResolution? Resolution { get; set; }

        /// <summary>
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// When true (default) the prompt may be grounded in external research: web search and image search. When false, both are off.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        public bool? Grounding { get; set; }

        /// <summary>
        /// Endpoint version. `latest` (default) serves the current release; dated pinnable release tags are added here as they are published.<br/>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3ImageInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Free-form prompt describing the image.
        /// </param>
        /// <param name="images">
        /// Optional reference image(s) the prompt edits or draws from; each is an http(s) URL or base64, one to 10 total.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Under `auto` a ratio the prompt asks for wins, otherwise the output keeps the first reference image's framing; without references the prompt decides, else 1:1.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// Image resolution class, an equal-pixel-area tier: `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.<br/>
        /// Default Value: 1k
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="grounding">
        /// When true (default) the prompt may be grounded in external research: web search and image search. When false, both are off.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="version">
        /// Endpoint version. `latest` (default) serves the current release; dated pinnable release tags are added here as they are published.<br/>
        /// Default Value: latest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3ImageInputs(
            string prompt,
            global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? images,
            global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>? aspectRatio,
            global::BlackForestLabs.Flux3ImageInputsResolution? resolution,
            int? safetyTolerance,
            bool? grounding,
            string? version)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.SafetyTolerance = safetyTolerance;
            this.Grounding = grounding;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3ImageInputs" /> class.
        /// </summary>
        public Flux3ImageInputs()
        {
        }

    }
}