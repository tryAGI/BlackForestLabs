
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Output image format: `jpeg` (default) or `png`.<br/>
    /// Default Value: jpeg
    /// </summary>
    public enum Flux3ImageKleinInputsOutputFormat
    {
        /// <summary>
        /// `jpeg` (default) or `png`.
        /// </summary>
        Jpeg,
        /// <summary>
        /// `jpeg` (default) or `png`.
        /// </summary>
        Png,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3ImageKleinInputsOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3ImageKleinInputsOutputFormat value)
        {
            return value switch
            {
                Flux3ImageKleinInputsOutputFormat.Jpeg => "jpeg",
                Flux3ImageKleinInputsOutputFormat.Png => "png",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3ImageKleinInputsOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => Flux3ImageKleinInputsOutputFormat.Jpeg,
                "png" => Flux3ImageKleinInputsOutputFormat.Png,
                _ => null,
            };
        }
    }
}