
#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum Flux3VideoInputsBodyDiscriminatorMode
    {
        /// <summary>
        ///
        /// </summary>
        DraftEnhance,
        /// <summary>
        ///
        /// </summary>
        I2v,
        /// <summary>
        ///
        /// </summary>
        T2v,
        /// <summary>
        ///
        /// </summary>
        V2v,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Flux3VideoInputsBodyDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Flux3VideoInputsBodyDiscriminatorMode value)
        {
            return value switch
            {
                Flux3VideoInputsBodyDiscriminatorMode.DraftEnhance => "draft_enhance",
                Flux3VideoInputsBodyDiscriminatorMode.I2v => "i2v",
                Flux3VideoInputsBodyDiscriminatorMode.T2v => "t2v",
                Flux3VideoInputsBodyDiscriminatorMode.V2v => "v2v",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Flux3VideoInputsBodyDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "draft_enhance" => Flux3VideoInputsBodyDiscriminatorMode.DraftEnhance,
                "i2v" => Flux3VideoInputsBodyDiscriminatorMode.I2v,
                "t2v" => Flux3VideoInputsBodyDiscriminatorMode.T2v,
                "v2v" => Flux3VideoInputsBodyDiscriminatorMode.V2v,
                _ => null,
            };
        }
    }
}