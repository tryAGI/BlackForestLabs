#nullable enable

namespace BlackForestLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class Flux3VideoDraftEnhanceInputsResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution>
    {
        /// <inheritdoc />
        public override global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution Read(
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
                        return global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolutionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BlackForestLabs.Flux3VideoDraftEnhanceInputsResolutionExtensions.ToValueString(value));
        }
    }
}
