
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Public contract for ``/v1/flux-tools/outpainting-v1``.
    /// </summary>
    public sealed partial class FluxOutpaintingInputs
    {
        /// <summary>
        /// Base64-encoded input (reference) image or HTTP(S) image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputImage { get; set; }

        /// <summary>
        /// Target output width.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Target output height.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// If True, crop the input image to the canvas bounds when it extends beyond the edges. If False, an error is raised instead.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_crop")]
        public bool? AutoCrop { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::BlackForestLabs.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Experimental: optional text guidance for the outpainted region. The model may not strictly follow this prompt; the visual content of the input image is the primary signal. Leave unset for default behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Left offset (px) of the reference image's top-left corner on the output canvas. Negative values are allowed. None = center horizontally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_offset_x")]
        public int? ReferenceOffsetX { get; set; }

        /// <summary>
        /// Top offset (px) of the reference image's top-left corner on the output canvas. Negative values are allowed. None = center vertically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_offset_y")]
        public int? ReferenceOffsetY { get; set; }

        /// <summary>
        /// Quality/speed trade-off. 'high' (default): highest-fidelity results, recommended whenever fine detail, prompt adherence, or consistency with complex content in the source image matters; slower. 'fast': significantly faster and well-suited for naturally extending most scenes (landscapes, backgrounds, textures, products); may produce lower fidelity in the extended region than 'high'.<br/>
        /// Default Value: high
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.FluxOutpaintingInputsModeJsonConverter))]
        public global::BlackForestLabs.FluxOutpaintingInputsMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxOutpaintingInputs" /> class.
        /// </summary>
        /// <param name="inputImage">
        /// Base64-encoded input (reference) image or HTTP(S) image URL.
        /// </param>
        /// <param name="width">
        /// Target output width.
        /// </param>
        /// <param name="height">
        /// Target output height.
        /// </param>
        /// <param name="autoCrop">
        /// If True, crop the input image to the canvas bounds when it extends beyond the edges. If False, an error is raised instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict. If you wish to increase the safety_tolerance beyond these levels please reach out to the team.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="prompt">
        /// Experimental: optional text guidance for the outpainted region. The model may not strictly follow this prompt; the visual content of the input image is the primary signal. Leave unset for default behavior.
        /// </param>
        /// <param name="referenceOffsetX">
        /// Left offset (px) of the reference image's top-left corner on the output canvas. Negative values are allowed. None = center horizontally.
        /// </param>
        /// <param name="referenceOffsetY">
        /// Top offset (px) of the reference image's top-left corner on the output canvas. Negative values are allowed. None = center vertically.
        /// </param>
        /// <param name="mode">
        /// Quality/speed trade-off. 'high' (default): highest-fidelity results, recommended whenever fine detail, prompt adherence, or consistency with complex content in the source image matters; slower. 'fast': significantly faster and well-suited for naturally extending most scenes (landscapes, backgrounds, textures, products); may produce lower fidelity in the extended region than 'high'.<br/>
        /// Default Value: high
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxOutpaintingInputs(
            string inputImage,
            int width,
            int height,
            bool? autoCrop,
            int? safetyTolerance,
            global::BlackForestLabs.OutputFormat? outputFormat,
            string? prompt,
            int? referenceOffsetX,
            int? referenceOffsetY,
            global::BlackForestLabs.FluxOutpaintingInputsMode? mode)
        {
            this.InputImage = inputImage ?? throw new global::System.ArgumentNullException(nameof(inputImage));
            this.Width = width;
            this.Height = height;
            this.AutoCrop = autoCrop;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.Prompt = prompt;
            this.ReferenceOffsetX = referenceOffsetX;
            this.ReferenceOffsetY = referenceOffsetY;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxOutpaintingInputs" /> class.
        /// </summary>
        public FluxOutpaintingInputs()
        {
        }

    }
}