
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Image resolution class, an equal-pixel-area tier: `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.<br/>
    /// Default Value: 1k
    /// </summary>
    public enum Flux3ImageInputsResolution
    {
        /// <summary>
        /// `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.
        /// </summary>
        x15k,
        /// <summary>
        /// `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.
        /// </summary>
        x1k,
        /// <summary>
        /// `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.
        /// </summary>
        x2k,
        /// <summary>
        /// `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.
        /// </summary>
        x4k,
        /// <summary>
        /// `768sq`, `1k`, `1.5k`, `2k`, or `4k`. Exact dimensions vary with the aspect ratio.
        /// </summary>
        x768sq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3ImageInputsResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3ImageInputsResolution value)
        {
            return value switch
            {
                Flux3ImageInputsResolution.x15k => "1.5k",
                Flux3ImageInputsResolution.x1k => "1k",
                Flux3ImageInputsResolution.x2k => "2k",
                Flux3ImageInputsResolution.x4k => "4k",
                Flux3ImageInputsResolution.x768sq => "768sq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3ImageInputsResolution? ToEnum(string value)
        {
            return value switch
            {
                "1.5k" => Flux3ImageInputsResolution.x15k,
                "1k" => Flux3ImageInputsResolution.x1k,
                "2k" => Flux3ImageInputsResolution.x2k,
                "4k" => Flux3ImageInputsResolution.x4k,
                "768sq" => Flux3ImageInputsResolution.x768sq,
                _ => null,
            };
        }
    }
}