
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Input model for public FLUX.2 erase.
    /// </summary>
    public sealed partial class Flux2EraseInputs
    {
        /// <summary>
        /// Base64-encoded input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Image { get; set; }

        /// <summary>
        /// Base64-encoded black/white mask. White pixels indicate the object to remove; black pixels are preserved. Must have the same dimensions as the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mask { get; set; }

        /// <summary>
        /// Number of pixels to dilate the mask by before removal. Dilation helps cover object edges. Maximum is 25 pixels.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dilate_pixels")]
        public int? DilatePixels { get; set; }

        /// <summary>
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::BlackForestLabs.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// URL to receive webhook notifications
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Optional secret for webhook signature verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2EraseInputs" /> class.
        /// </summary>
        /// <param name="image">
        /// Base64-encoded input image.
        /// </param>
        /// <param name="mask">
        /// Base64-encoded black/white mask. White pixels indicate the object to remove; black pixels are preserved. Must have the same dimensions as the input image.
        /// </param>
        /// <param name="dilatePixels">
        /// Number of pixels to dilate the mask by before removal. Dilation helps cover object edges. Maximum is 25 pixels.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5, 0 being most strict, 5 being least strict.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications
        /// </param>
        /// <param name="webhookSecret">
        /// Optional secret for webhook signature verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux2EraseInputs(
            string image,
            string mask,
            int? dilatePixels,
            int? seed,
            int? safetyTolerance,
            global::BlackForestLabs.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.DilatePixels = dilatePixels;
            this.Seed = seed;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2EraseInputs" /> class.
        /// </summary>
        public Flux2EraseInputs()
        {
        }

    }
}