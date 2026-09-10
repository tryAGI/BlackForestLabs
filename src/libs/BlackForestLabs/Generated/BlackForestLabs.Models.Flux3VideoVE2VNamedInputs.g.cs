
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Video edit on a dedicated route: the clip and the instruction.<br/>
    /// The public `/flux-tools/video-edit-v1` body. The route pins the recipe, so<br/>
    /// the body has no `mode` and no `version` to pick, and every serving control<br/>
    /// -- duration, resolution, aspect ratio, audio, steps, guidance, seed --<br/>
    /// stays server-pinned.
    /// </summary>
    public sealed partial class Flux3VideoVE2VNamedInputs
    {
        /// <summary>
        /// The video to edit, an http(s) URL or base64-encoded mp4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Video { get; set; }

        /// <summary>
        /// Edit instruction, stripped of surrounding whitespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance.<br/>
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
        /// Initializes a new instance of the <see cref="Flux3VideoVE2VNamedInputs" /> class.
        /// </summary>
        /// <param name="video">
        /// The video to edit, an http(s) URL or base64-encoded mp4.
        /// </param>
        /// <param name="prompt">
        /// Edit instruction, stripped of surrounding whitespace.
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance.<br/>
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3VideoVE2VNamedInputs(
            string video,
            string prompt,
            int? safetyTolerance)
        {
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SafetyTolerance = safetyTolerance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoVE2VNamedInputs" /> class.
        /// </summary>
        public Flux3VideoVE2VNamedInputs()
        {
        }

    }
}