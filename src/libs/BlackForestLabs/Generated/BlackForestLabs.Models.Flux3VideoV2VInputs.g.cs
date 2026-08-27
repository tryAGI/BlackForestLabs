
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Video continuation: the generated clip carries on from your video's<br/>
    /// final frames.
    /// </summary>
    public sealed partial class Flux3VideoV2VInputs
    {
        /// <summary>
        /// Free-form prompt describing the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Output aspect ratio. `auto` lets the harness choose from the prompt and any references.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>))]
        public global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>? AspectRatio { get; set; }

        /// <summary>
        /// Video duration in seconds (any whole second from 5 to 15), or `auto` to fit the content.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::BlackForestLabs.AnyOf<int?, string>? Duration { get; set; }

        /// <summary>
        /// Video resolution class: `hd`, or `fhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.<br/>
        /// Default Value: hd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.Flux3VideoV2VInputsResolutionJsonConverter))]
        public global::BlackForestLabs.Flux3VideoV2VInputsResolution? Resolution { get; set; }

        /// <summary>
        /// Endpoint version. `latest` (default) serves the current release; dated pinnable release tags are added here as they are published.<br/>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Generate synchronized audio alongside the video.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance. Contextual safety signals can tighten the requested level.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Draft mode: generate a fast preview and return a `draft_cache` download URL in the result. Download that bundle and pass it back later to render the full-quality version of the same generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"v2v"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "v2v";

        /// <summary>
        /// The video to continue, an http(s) URL or base64 mp4; the generated clip carries on from its final frames.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartVideo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoV2VInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Free-form prompt describing the video.
        /// </param>
        /// <param name="startVideo">
        /// The video to continue, an http(s) URL or base64 mp4; the generated clip carries on from its final frames.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. `auto` lets the harness choose from the prompt and any references.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="duration">
        /// Video duration in seconds (any whole second from 5 to 15), or `auto` to fit the content.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="resolution">
        /// Video resolution class: `hd`, or `fhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.<br/>
        /// Default Value: hd
        /// </param>
        /// <param name="version">
        /// Endpoint version. `latest` (default) serves the current release; dated pinnable release tags are added here as they are published.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="generateAudio">
        /// Generate synchronized audio alongside the video.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output harm moderation. Between 0 and 4, with 0 the strictest. Sexual content is limited to level 3 and hate content to level 2 regardless of the requested tolerance. Contextual safety signals can tighten the requested level.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="draft">
        /// Draft mode: generate a fast preview and return a `draft_cache` download URL in the result. Download that bundle and pass it back later to render the full-quality version of the same generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3VideoV2VInputs(
            string prompt,
            string startVideo,
            global::BlackForestLabs.AnyOf<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?, string>? aspectRatio,
            global::BlackForestLabs.AnyOf<int?, string>? duration,
            global::BlackForestLabs.Flux3VideoV2VInputsResolution? resolution,
            string? version,
            bool? generateAudio,
            int? safetyTolerance,
            bool? draft,
            string mode = "v2v")
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.Resolution = resolution;
            this.Version = version;
            this.GenerateAudio = generateAudio;
            this.SafetyTolerance = safetyTolerance;
            this.Draft = draft;
            this.Mode = mode;
            this.StartVideo = startVideo ?? throw new global::System.ArgumentNullException(nameof(startVideo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoV2VInputs" /> class.
        /// </summary>
        public Flux3VideoV2VInputs()
        {
        }

    }
}