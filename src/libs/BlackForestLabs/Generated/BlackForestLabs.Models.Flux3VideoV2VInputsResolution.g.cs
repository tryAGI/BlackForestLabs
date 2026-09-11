
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Video resolution class: `hd`, or `fhd`/`qhd`/`uhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.<br/>
    /// Default Value: hd
    /// </summary>
    public enum Flux3VideoV2VInputsResolution
    {
        /// <summary>
        /// `hd`, or `fhd`/`qhd`/`uhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.
        /// </summary>
        Fhd,
        /// <summary>
        /// `hd`, or `fhd`/`qhd`/`uhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.
        /// </summary>
        Hd,
        /// <summary>
        /// `hd`, or `fhd`/`qhd`/`uhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.
        /// </summary>
        Qhd,
        /// <summary>
        /// `hd`, or `fhd`/`qhd`/`uhd` for a higher-resolution result finished by the video upsampler. Exact dimensions vary with the aspect ratio.
        /// </summary>
        Uhd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3VideoV2VInputsResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3VideoV2VInputsResolution value)
        {
            return value switch
            {
                Flux3VideoV2VInputsResolution.Fhd => "fhd",
                Flux3VideoV2VInputsResolution.Hd => "hd",
                Flux3VideoV2VInputsResolution.Qhd => "qhd",
                Flux3VideoV2VInputsResolution.Uhd => "uhd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3VideoV2VInputsResolution? ToEnum(string value)
        {
            return value switch
            {
                "fhd" => Flux3VideoV2VInputsResolution.Fhd,
                "hd" => Flux3VideoV2VInputsResolution.Hd,
                "qhd" => Flux3VideoV2VInputsResolution.Qhd,
                "uhd" => Flux3VideoV2VInputsResolution.Uhd,
                _ => null,
            };
        }
    }
}