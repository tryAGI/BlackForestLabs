
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Full-quality render of a prior `draft` generation. The bundle pins the<br/>
    /// generation itself -- the original mode, prompt, seed, and conditioning<br/>
    /// media -- so `resolution` is the only output choice left to the caller.
    /// </summary>
    public sealed partial class Flux3VideoDraftEnhanceInputs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"draft_enhance"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "draft_enhance";

        /// <summary>
        /// Encrypted draft-cache bundle from a prior `draft` generation. Primary form: the base64-encoded `.bin` file downloaded from the prior result's `draft_cache` URL. An http(s) URL is also accepted for replays within the download URL's expiry window. The harness is skipped and the original FLUX call is reproduced at full quality; the original inputs are embedded in the bundle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft_cache")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DraftCache { get; set; }

        /// <summary>
        /// Video resolution class of the enhanced result: `fhd` (default) finishes the reproduced generation with the video upsampler, `hd` returns it without that pass. The reproduced generation is identical either way; only the finishing pass differs.<br/>
        /// Default Value: fhd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.Flux3VideoDraftEnhanceInputsResolutionJsonConverter))]
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution? Resolution { get; set; }

        /// <summary>
        /// Tolerance level for replay input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance. Bundles containing user media are limited to level 2.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoDraftEnhanceInputs" /> class.
        /// </summary>
        /// <param name="draftCache">
        /// Encrypted draft-cache bundle from a prior `draft` generation. Primary form: the base64-encoded `.bin` file downloaded from the prior result's `draft_cache` URL. An http(s) URL is also accepted for replays within the download URL's expiry window. The harness is skipped and the original FLUX call is reproduced at full quality; the original inputs are embedded in the bundle.
        /// </param>
        /// <param name="resolution">
        /// Video resolution class of the enhanced result: `fhd` (default) finishes the reproduced generation with the video upsampler, `hd` returns it without that pass. The reproduced generation is identical either way; only the finishing pass differs.<br/>
        /// Default Value: fhd
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for replay input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance. Bundles containing user media are limited to level 2.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3VideoDraftEnhanceInputs(
            string draftCache,
            global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution? resolution,
            int? safetyTolerance,
            string mode = "draft_enhance")
        {
            this.Mode = mode;
            this.DraftCache = draftCache ?? throw new global::System.ArgumentNullException(nameof(draftCache));
            this.Resolution = resolution;
            this.SafetyTolerance = safetyTolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoDraftEnhanceInputs" /> class.
        /// </summary>
        public Flux3VideoDraftEnhanceInputs()
        {
        }

        /// <summary>
        /// Creates a new <see cref="Flux3VideoDraftEnhanceInputs"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static Flux3VideoDraftEnhanceInputs FromDraftCache(string draftCache)
        {
            return new Flux3VideoDraftEnhanceInputs
            {
                DraftCache = draftCache,
            };
        }

    }
}