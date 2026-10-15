
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum Flux3ImageKleinInputsResolution
    {
        /// <summary>
        ///
        /// </summary>
        x15k,
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
        /// <summary>
        ///
        /// </summary>
        x768sq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3ImageKleinInputsResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3ImageKleinInputsResolution value)
        {
            return value switch
            {
                Flux3ImageKleinInputsResolution.x15k => "1.5k",
                Flux3ImageKleinInputsResolution.x1k => "1k",
                Flux3ImageKleinInputsResolution.x2k => "2k",
                Flux3ImageKleinInputsResolution.x4k => "4k",
                Flux3ImageKleinInputsResolution.x768sq => "768sq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3ImageKleinInputsResolution? ToEnum(string value)
        {
            return value switch
            {
                "1.5k" => Flux3ImageKleinInputsResolution.x15k,
                "1k" => Flux3ImageKleinInputsResolution.x1k,
                "2k" => Flux3ImageKleinInputsResolution.x2k,
                "4k" => Flux3ImageKleinInputsResolution.x4k,
                "768sq" => Flux3ImageKleinInputsResolution.x768sq,
                _ => null,
            };
        }
    }
}