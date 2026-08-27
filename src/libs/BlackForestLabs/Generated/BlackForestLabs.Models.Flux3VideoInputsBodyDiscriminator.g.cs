
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Flux3VideoInputsBodyDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::BlackForestLabs.JsonConverters.Flux3VideoInputsBodyDiscriminatorModeJsonConverter))]
        public global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoInputsBodyDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux3VideoInputsBodyDiscriminator(
            global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux3VideoInputsBodyDiscriminator" /> class.
        /// </summary>
        public Flux3VideoInputsBodyDiscriminator()
        {
        }

    }
}