#nullable enable

namespace BlackForestLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class Flux3VideoV2VInputsAspectRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?>
    {
        /// <inheritdoc />
        public override global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio? Read(
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
                        return global::BlackForestLabs.Flux3VideoV2VInputsAspectRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlackForestLabs.Flux3VideoV2VInputsAspectRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::BlackForestLabs.Flux3VideoV2VInputsAspectRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
