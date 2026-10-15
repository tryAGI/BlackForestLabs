
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// FLUX 3 Image Klein: text-to-image, or editing with up to 10 reference images.
    /// </summary>
    public sealed partial class Flux3ImageKleinInputs
    {
        /// <summary>
        /// Free-form prompt describing the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Optional reference image(s), each an http(s) URL or base64, one to 10 total. The first is the image being edited and sets the default output size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? Images { get; set; }

        /// <summary>
        /// Output aspect ratio, as in flux-3-image. `auto` (default): for edits, the first reference's exact aspect; for text-to-image, a ratio picked from the prompt (prompt rewrite, else ratio keywords, else 16:9) at the requested tier. Ignored when width and height are set.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio?, string>))]
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio?, string>? AspectRatio { get; set; }

        /// <summary>
        /// Equal-area size tier, as in flux-3-image: `768sq`, `1k`, `1.5k`, `2k` or `4k`. Omitted: `1k` for text-to-image; for edits the first reference's own size, or its nearest tier when aspect_ratio is set. Ignored when width and height are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public global::BlackForestLabs.Flux3ImageKleinInputsResolution? Resolution { get; set; }

        /// <summary>
        /// Exact output width in pixels, [64, 6256]; set together with height. Overrides resolution and aspect_ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Exact output height in pixels, [64, 6256]; width x height at most 16822272 pixels (16.8 MP, the largest 4k bin).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Seed for reproducibility; random when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Output image format: `jpeg` (default) or `png`.<br/>
        /// Default Value: jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.Flux3ImageKleinInputsOutputFormatJsonConverter))]
        public global::BlackForestLabs.Flux3ImageKleinInputsOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Denoising steps (default 16).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3ImageKleinInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Free-form prompt describing the image.
        /// </param>
        /// <param name="images">
        /// Optional reference image(s), each an http(s) URL or base64, one to 10 total. The first is the image being edited and sets the default output size.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio, as in flux-3-image. `auto` (default): for edits, the first reference's exact aspect; for text-to-image, a ratio picked from the prompt (prompt rewrite, else ratio keywords, else 16:9) at the requested tier. Ignored when width and height are set.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// Equal-area size tier, as in flux-3-image: `768sq`, `1k`, `1.5k`, `2k` or `4k`. Omitted: `1k` for text-to-image; for edits the first reference's own size, or its nearest tier when aspect_ratio is set. Ignored when width and height are set.
        /// </param>
        /// <param name="width">
        /// Exact output width in pixels, [64, 6256]; set together with height. Overrides resolution and aspect_ratio.
        /// </param>
        /// <param name="height">
        /// Exact output height in pixels, [64, 6256]; width x height at most 16822272 pixels (16.8 MP, the largest 4k bin).
        /// </param>
        /// <param name="seed">
        /// Seed for reproducibility; random when omitted.
        /// </param>
        /// <param name="safetyTolerance">
        /// Harm moderation tolerance from 0 to 7, with 0 the strictest. The route and organization determine the approved maximum and per-category ceilings. Unapproved levels return 422 with approved levels.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Output image format: `jpeg` (default) or `png`.<br/>
        /// Default Value: jpeg
        /// </param>
        /// <param name="steps">
        /// Denoising steps (default 16).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3ImageKleinInputs(
            string prompt,
            global::BlackForestLabs.AnyOf<string, global::System.Collections.Generic.IList<string>>? images,
            global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3ImageKleinInputsAspectRatio?, string>? aspectRatio,
            global::BlackForestLabs.Flux3ImageKleinInputsResolution? resolution,
            int? width,
            int? height,
            int? seed,
            int? safetyTolerance,
            global::BlackForestLabs.Flux3ImageKleinInputsOutputFormat? outputFormat,
            int? steps)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Width = width;
            this.Height = height;
            this.Seed = seed;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3ImageKleinInputs" /> class.
        /// </summary>
        public Flux3ImageKleinInputs()
        {
        }

    }
}