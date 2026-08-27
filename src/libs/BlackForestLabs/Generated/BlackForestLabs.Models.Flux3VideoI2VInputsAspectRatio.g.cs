
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum Flux3VideoI2VInputsAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x21_9,
        /// <summary>
        ///
        /// </summary>
        x2_1,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3VideoI2VInputsAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3VideoI2VInputsAspectRatio value)
        {
            return value switch
            {
                Flux3VideoI2VInputsAspectRatio.x16_9 => "16:9",
                Flux3VideoI2VInputsAspectRatio.x1_1 => "1:1",
                Flux3VideoI2VInputsAspectRatio.x21_9 => "21:9",
                Flux3VideoI2VInputsAspectRatio.x2_1 => "2:1",
                Flux3VideoI2VInputsAspectRatio.x3_4 => "3:4",
                Flux3VideoI2VInputsAspectRatio.x4_3 => "4:3",
                Flux3VideoI2VInputsAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3VideoI2VInputsAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Flux3VideoI2VInputsAspectRatio.x16_9,
                "1:1" => Flux3VideoI2VInputsAspectRatio.x1_1,
                "21:9" => Flux3VideoI2VInputsAspectRatio.x21_9,
                "2:1" => Flux3VideoI2VInputsAspectRatio.x2_1,
                "3:4" => Flux3VideoI2VInputsAspectRatio.x3_4,
                "4:3" => Flux3VideoI2VInputsAspectRatio.x4_3,
                "9:16" => Flux3VideoI2VInputsAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}