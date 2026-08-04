#nullable enable

namespace BlackForestLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class Flux3VideoInputsBodyDiscriminatorModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode?>
    {
        /// <inheritdoc />
        public override global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
