
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Input model for FLUX.2 Klein VTO endpoint.<br/>
    /// Exposes only person/garment image fields for cleaner API ergonomics.
    /// </summary>
    public sealed partial class Flux2KleinTryonInputs
    {
        /// <summary>
        /// Text prompt for VTO generation.<br/>
        /// Example: TRY-ON: The person of image 1 wearing the garments of image 2.
        /// </summary>
        /// <example>TRY-ON: The person of image 1 wearing the garments of image 2.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Person image (maps internally to input_image).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Person { get; set; }

        /// <summary>
        /// Image of one more garments (maps internally to input_image_2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Garment { get; set; }

        /// <summary>
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Tolerance level for input and output moderation. Between 0 and 5 for public use.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_tolerance")]
        public int? SafetyTolerance { get; set; }

        /// <summary>
        /// Default Value: jpeg
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
        /// Initializes a new instance of the <see cref="Flux2KleinTryonInputs" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text prompt for VTO generation.<br/>
        /// Example: TRY-ON: The person of image 1 wearing the garments of image 2.
        /// </param>
        /// <param name="person">
        /// Person image (maps internally to input_image).
        /// </param>
        /// <param name="garment">
        /// Image of one more garments (maps internally to input_image_2).
        /// </param>
        /// <param name="seed">
        /// Optional seed for reproducibility.<br/>
        /// Example: 42
        /// </param>
        /// <param name="safetyTolerance">
        /// Tolerance level for input and output moderation. Between 0 and 5 for public use.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: jpeg
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
        public Flux2KleinTryonInputs(
            string prompt,
            string person,
            string garment,
            int? seed,
            int? safetyTolerance,
            global::BlackForestLabs.OutputFormat? outputFormat,
            string? webhookUrl,
            string? webhookSecret)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Person = person ?? throw new global::System.ArgumentNullException(nameof(person));
            this.Garment = garment ?? throw new global::System.ArgumentNullException(nameof(garment));
            this.Seed = seed;
            this.SafetyTolerance = safetyTolerance;
            this.OutputFormat = outputFormat;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2KleinTryonInputs" /> class.
        /// </summary>
        public Flux2KleinTryonInputs()
        {
        }

    }
}