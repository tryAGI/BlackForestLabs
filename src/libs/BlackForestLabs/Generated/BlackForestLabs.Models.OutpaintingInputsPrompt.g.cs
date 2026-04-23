
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Text prompt for outpainting. The trigger word 'OUTPAINT' is prepended automatically if absent. Defaults to a quality-focused outpainting prompt.
    /// </summary>
    public sealed partial class OutpaintingInputsPrompt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}