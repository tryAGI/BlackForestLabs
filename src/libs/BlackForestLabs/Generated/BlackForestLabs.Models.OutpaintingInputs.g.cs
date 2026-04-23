
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Input model for the outpainting endpoint.<br/>
    /// The caller provides a prompt, an input image, and target dimensions.<br/>
    /// The image is placed on a canvas at ``(width, height)`` using an<br/>
    /// adaptively-chosen fill color before being sent to the outpainting<br/>
    /// model.<br/>
    /// ``bbox_x1`` / ``bbox_y1`` set the top-left corner of the input image on<br/>
    /// the canvas in pixels (may be negative). When both are ``None`` the<br/>
    /// image is centered.
    /// </summary>
    public sealed partial class OutpaintingInputs
    {
        /// <summary>
        /// Text prompt for outpainting. The trigger word 'OUTPAINT' is prepended automatically if absent. Defaults to a quality-focused outpainting prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Base64-encoded input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputImage { get; set; }

        /// <summary>
        /// Target output width.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Target output height.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Left offset (px) of input image top-left corner on the canvas. Negative values are allowed. None = center horizontally.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_x1")]
        public int? BboxX1 { get; set; }

        /// <summary>
        /// Top offset (px) of input image top-left corner on the canvas. Negative values are allowed. None = center vertically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_y1")]
        public int? BboxY1 { get; set; }

        /// <summary>
        /// If True, crop the input image to the canvas bounds when it extends beyond the edges. If False, an error is raised instead.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_crop")]
        public bool? AutoCrop { get; set; }

        /// <summary>
        /// If True, skip padding and use the image as-is.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pre_padded")]
        public bool? PrePadded { get; set; }

        /// <summary>
        /// Whether to upsample the prompt via VLM before inference.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        public bool? PromptUpsampling { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::BlackForestLabs.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Number of diffusion steps. Defaults to 30 if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Guidance scale. Defaults to 4.0 if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public double? Guidance { get; set; }

        /// <summary>
        /// Block caching threshold. 0 disables caching. Overrides effort if set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_residual_diff_threshold")]
        public double? CacheResidualDiffThreshold { get; set; }

        /// <summary>
        /// Effort mode: 'high' (no caching, best quality), 'medium', or 'low' (fastest). Defaults to 'high'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public string? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutpaintingInputs" /> class.
        /// </summary>
        /// <param name="inputImage">
        /// Base64-encoded input image.
        /// </param>
        /// <param name="prompt">
        /// Text prompt for outpainting. The trigger word 'OUTPAINT' is prepended automatically if absent. Defaults to a quality-focused outpainting prompt.
        /// </param>
        /// <param name="width">
        /// Target output width.
        /// </param>
        /// <param name="height">
        /// Target output height.
        /// </param>
        /// <param name="bboxX1">
        /// Left offset (px) of input image top-left corner on the canvas. Negative values are allowed. None = center horizontally.
        /// </param>
        /// <param name="bboxY1">
        /// Top offset (px) of input image top-left corner on the canvas. Negative values are allowed. None = center vertically.
        /// </param>
        /// <param name="autoCrop">
        /// If True, crop the input image to the canvas bounds when it extends beyond the edges. If False, an error is raised instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prePadded">
        /// If True, skip padding and use the image as-is.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="promptUpsampling">
        /// Whether to upsample the prompt via VLM before inference.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="steps">
        /// Number of diffusion steps. Defaults to 30 if not specified.
        /// </param>
        /// <param name="guidance">
        /// Guidance scale. Defaults to 4.0 if not specified.
        /// </param>
        /// <param name="cacheResidualDiffThreshold">
        /// Block caching threshold. 0 disables caching. Overrides effort if set.
        /// </param>
        /// <param name="effort">
        /// Effort mode: 'high' (no caching, best quality), 'medium', or 'low' (fastest). Defaults to 'high'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutpaintingInputs(
            string inputImage,
            string? prompt,
            int? width,
            int? height,
            int? bboxX1,
            int? bboxY1,
            bool? autoCrop,
            bool? prePadded,
            bool? promptUpsampling,
            global::BlackForestLabs.OutputFormat? outputFormat,
            int? steps,
            double? guidance,
            double? cacheResidualDiffThreshold,
            string? effort)
        {
            this.Prompt = prompt;
            this.InputImage = inputImage ?? throw new global::System.ArgumentNullException(nameof(inputImage));
            this.Width = width;
            this.Height = height;
            this.BboxX1 = bboxX1;
            this.BboxY1 = bboxY1;
            this.AutoCrop = autoCrop;
            this.PrePadded = prePadded;
            this.PromptUpsampling = promptUpsampling;
            this.OutputFormat = outputFormat;
            this.Steps = steps;
            this.Guidance = guidance;
            this.CacheResidualDiffThreshold = cacheResidualDiffThreshold;
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutpaintingInputs" /> class.
        /// </summary>
        public OutpaintingInputs()
        {
        }
    }
}