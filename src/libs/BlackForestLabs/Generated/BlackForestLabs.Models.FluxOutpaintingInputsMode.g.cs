
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Quality/speed trade-off. 'high' (default): highest-fidelity results, recommended whenever fine detail, prompt adherence, or consistency with complex content in the source image matters; slower. 'fast': significantly faster and well-suited for naturally extending most scenes (landscapes, backgrounds, textures, products); may produce lower fidelity in the extended region than 'high'.<br/>
    /// Default Value: high
    /// </summary>
    public enum FluxOutpaintingInputsMode
    {
        /// <summary>
        /// highest-fidelity results, recommended whenever fine detail, prompt adherence, or consistency with complex content in the source image matters; slower. 'fast': significantly faster and well-suited for naturally extending most scenes (landscapes, backgrounds, textures, products); may produce lower fidelity in the extended region than 'high'.
        /// </summary>
        Fast,
        /// <summary>
        /// highest-fidelity results, recommended whenever fine detail, prompt adherence, or consistency with complex content in the source image matters; slower. 'fast': significantly faster and well-suited for naturally extending most scenes (landscapes, backgrounds, textures, products); may produce lower fidelity in the extended region than 'high'.
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FluxOutpaintingInputsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FluxOutpaintingInputsMode value)
        {
            return value switch
            {
                FluxOutpaintingInputsMode.Fast => "fast",
                FluxOutpaintingInputsMode.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FluxOutpaintingInputsMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => FluxOutpaintingInputsMode.Fast,
                "high" => FluxOutpaintingInputsMode.High,
                _ => null,
            };
        }
    }
}