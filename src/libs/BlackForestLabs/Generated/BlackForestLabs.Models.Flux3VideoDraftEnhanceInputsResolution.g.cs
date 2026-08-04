
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Video resolution class of the enhanced result: `fhd` (default) finishes the reproduced generation with the video upsampler, `hd` returns it without that pass. The reproduced generation is identical either way; only the finishing pass differs.<br/>
    /// Default Value: fhd
    /// </summary>
    public enum Flux3VideoDraftEnhanceInputsResolution
    {
        /// <summary>
        /// `fhd` (default) finishes the reproduced generation with the video upsampler, `hd` returns it without that pass. The reproduced generation is identical either way; only the finishing pass differs.
        /// </summary>
        Fhd,
        /// <summary>
        /// `fhd` (default) finishes the reproduced generation with the video upsampler, `hd` returns it without that pass. The reproduced generation is identical either way; only the finishing pass differs.
        /// </summary>
        Hd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3VideoDraftEnhanceInputsResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3VideoDraftEnhanceInputsResolution value)
        {
            return value switch
            {
                Flux3VideoDraftEnhanceInputsResolution.Fhd => "fhd",
                Flux3VideoDraftEnhanceInputsResolution.Hd => "hd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3VideoDraftEnhanceInputsResolution? ToEnum(string value)
        {
            return value switch
            {
                "fhd" => Flux3VideoDraftEnhanceInputsResolution.Fhd,
                "hd" => Flux3VideoDraftEnhanceInputsResolution.Hd,
                _ => null,
            };
        }
    }
}