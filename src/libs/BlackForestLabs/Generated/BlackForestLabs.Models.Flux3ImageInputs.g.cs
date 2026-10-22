
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Flux3ImageInputs
    {
        /// <summary>
        /// Opaque identifier for the end user supplied by the calling platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Images { get; set; }

        /// <summary>
        /// Output aspect ratio. Under `auto` a ratio the prompt asks for wins, otherwise the output keeps the first reference image's framing; without references the prompt decides, else 1:1.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>))]
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>? AspectRatio { get; set; }

        /// <summary>
        /// Image resolution class, an equal-pixel-area tier: `768sq`, `1k` (default), `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio. `match_input` (edits only): the output keeps the first reference's own size (shrunk to 4 MP when larger), or its nearest tier when aspect_ratio is set. Ignored when width and height are set.<br/>
        /// Default Value: 1k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.Flux3ImageInputsResolutionJsonConverter))]
        public global::BlackForestLabs.Flux3ImageInputsResolution? Resolution { get; set; }

        /// <summary>
        /// Exact output width in pixels, [256, 6256]; set together with height. Overrides resolution and aspect_ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Exact output height in pixels, [256, 6256]; width x height at most 16822272 pixels, and at most 4194304 with reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.<br/>
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
        /// <param name="user">
        /// Opaque identifier for the end user supplied by the calling platform.
        /// </param>
        /// <param name="images">
        /// Optional reference image(s) the prompt edits or draws from; each is an http(s) URL or base64, one to 10 total.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Under `auto` a ratio the prompt asks for wins, otherwise the output keeps the first reference image's framing; without references the prompt decides, else 1:1.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// Image resolution class, an equal-pixel-area tier: `768sq`, `1k` (default), `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio. `match_input` (edits only): the output keeps the first reference's own size (shrunk to 4 MP when larger), or its nearest tier when aspect_ratio is set. Ignored when width and height are set.<br/>
        /// Default Value: 1k
        /// </param>
        /// <param name="width">
        /// Exact output width in pixels, [256, 6256]; set together with height. Overrides resolution and aspect_ratio.
        /// </param>
        /// <param name="height">
        /// Exact output height in pixels, [256, 6256]; width x height at most 16822272 pixels, and at most 4194304 with reference images.
        /// </param>
        /// <param name="safetyTolerance">
        /// Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.<br/>
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
            string? user,
            global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? images,
            global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageInputsAspectRatio?, string>? aspectRatio,
            global::BlackForestLabs.Flux3ImageInputsResolution? resolution,
            int? width,
            int? height,
            int? safetyTolerance,
            bool? grounding,
            string? version)
        {
            this.User = user;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Width = width;
            this.Height = height;
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