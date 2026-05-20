
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Public contract for ``/v1/flux-tools/outpainting-v1``.
    /// </summary>
    public sealed partial class FluxOutpaintingInputs
    {
        /// <summary>
        /// Base64-encoded input (reference) image.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxOutpaintingInputs" /> class.
        /// </summary>
        /// <param name="inputImage">
        /// Base64-encoded input (reference) image.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FluxOutpaintingInputs(
            string inputImage,
            int width,
            int height,
            bool? autoCrop,
            global::BlackForestLabs.OutputFormat? outputFormat,
            string? prompt,
            int? referenceOffsetX,
            int? referenceOffsetY)
        {
            this.InputImage = inputImage ?? throw new global::System.ArgumentNullException(nameof(inputImage));
            this.Width = width;
            this.Height = height;
            this.AutoCrop = autoCrop;
            this.OutputFormat = outputFormat;
            this.Prompt = prompt;
            this.ReferenceOffsetX = referenceOffsetX;
            this.ReferenceOffsetY = referenceOffsetY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FluxOutpaintingInputs" /> class.
        /// </summary>
        public FluxOutpaintingInputs()
        {
        }

    }
}