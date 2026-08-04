
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Video resolution class: `hd`, or `fhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.<br/>
    /// Default Value: hd
    /// </summary>
    public enum Flux3VideoT2VInputsResolution
    {
        /// <summary>
        /// `hd`, or `fhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.
        /// </summary>
        Fhd,
        /// <summary>
        /// `hd`, or `fhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.
        /// </summary>
        Hd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3VideoT2VInputsResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3VideoT2VInputsResolution value)
        {
            return value switch
            {
                Flux3VideoT2VInputsResolution.Fhd => "fhd",
                Flux3VideoT2VInputsResolution.Hd => "hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3VideoT2VInputsResolution? ToEnum(string value)
        {
            return value switch
            {
                "fhd" => Flux3VideoT2VInputsResolution.Fhd,
                "hd" => Flux3VideoT2VInputsResolution.Hd,
                _ => null,
            };
        }
    }
}