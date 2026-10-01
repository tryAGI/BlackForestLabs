
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum Flux3ImageInputsAspectRatio
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
        x1_2,
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
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
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
        x4_5,
        /// <summary>
        ///
        /// </summary>
        x5_4,
        /// <summary>
        ///
        /// </summary>
        x5_7,
        /// <summary>
        ///
        /// </summary>
        x7_5,
        /// <summary>
        ///
        /// </summary>
        x9_16,
        /// <summary>
        ///
        /// </summary>
        x9_21,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3ImageInputsAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3ImageInputsAspectRatio value)
        {
            return value switch
            {
                Flux3ImageInputsAspectRatio.x16_9 => "16:9",
                Flux3ImageInputsAspectRatio.x1_1 => "1:1",
                Flux3ImageInputsAspectRatio.x1_2 => "1:2",
                Flux3ImageInputsAspectRatio.x21_9 => "21:9",
                Flux3ImageInputsAspectRatio.x2_1 => "2:1",
                Flux3ImageInputsAspectRatio.x2_3 => "2:3",
                Flux3ImageInputsAspectRatio.x3_2 => "3:2",
                Flux3ImageInputsAspectRatio.x3_4 => "3:4",
                Flux3ImageInputsAspectRatio.x4_3 => "4:3",
                Flux3ImageInputsAspectRatio.x4_5 => "4:5",
                Flux3ImageInputsAspectRatio.x5_4 => "5:4",
                Flux3ImageInputsAspectRatio.x5_7 => "5:7",
                Flux3ImageInputsAspectRatio.x7_5 => "7:5",
                Flux3ImageInputsAspectRatio.x9_16 => "9:16",
                Flux3ImageInputsAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3ImageInputsAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => Flux3ImageInputsAspectRatio.x16_9,
                "1:1" => Flux3ImageInputsAspectRatio.x1_1,
                "1:2" => Flux3ImageInputsAspectRatio.x1_2,
                "21:9" => Flux3ImageInputsAspectRatio.x21_9,
                "2:1" => Flux3ImageInputsAspectRatio.x2_1,
                "2:3" => Flux3ImageInputsAspectRatio.x2_3,
                "3:2" => Flux3ImageInputsAspectRatio.x3_2,
                "3:4" => Flux3ImageInputsAspectRatio.x3_4,
                "4:3" => Flux3ImageInputsAspectRatio.x4_3,
                "4:5" => Flux3ImageInputsAspectRatio.x4_5,
                "5:4" => Flux3ImageInputsAspectRatio.x5_4,
                "5:7" => Flux3ImageInputsAspectRatio.x5_7,
                "7:5" => Flux3ImageInputsAspectRatio.x7_5,
                "9:16" => Flux3ImageInputsAspectRatio.x9_16,
                "9:21" => Flux3ImageInputsAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}