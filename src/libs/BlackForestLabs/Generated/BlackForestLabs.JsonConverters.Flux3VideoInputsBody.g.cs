#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace BlackForestLabs.JsonConverters
{
    /// <inheritdoc />
    public class Flux3VideoInputsBodyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BlackForestLabs.Flux3VideoInputsBody>
    {
        /// <inheritdoc />
        public override global::BlackForestLabs.Flux3VideoInputsBody Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoInputsBodyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoInputsBodyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::BlackForestLabs.Flux3VideoInputsBodyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::BlackForestLabs.Flux3VideoT2VInputs? t2v = default;
            if (discriminator?.Mode == global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode.T2v)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoT2VInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoT2VInputs> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::BlackForestLabs.Flux3VideoT2VInputs)}");
                t2v = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::BlackForestLabs.Flux3VideoI2VInputs? i2v = default;
            if (discriminator?.Mode == global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode.I2v)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoI2VInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoI2VInputs> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::BlackForestLabs.Flux3VideoI2VInputs)}");
                i2v = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::BlackForestLabs.Flux3VideoV2VInputs? v2v = default;
            if (discriminator?.Mode == global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode.V2v)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoV2VInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoV2VInputs> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::BlackForestLabs.Flux3VideoV2VInputs)}");
                v2v = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? draftEnhance = default;
            if (discriminator?.Mode == global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode.DraftEnhance)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoDraftEnhanceInputs> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs)}");
                draftEnhance = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::BlackForestLabs.Flux3VideoInputsBody(
                discriminator?.Mode,
                t2v,

                i2v,

                v2v,

                draftEnhance
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BlackForestLabs.Flux3VideoInputsBody value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsT2v)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoT2VInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoT2VInputs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::BlackForestLabs.Flux3VideoT2VInputs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.T2v!, typeInfo);
            }
            else if (value.IsI2v)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoI2VInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoI2VInputs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::BlackForestLabs.Flux3VideoI2VInputs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.I2v!, typeInfo);
            }
            else if (value.IsV2v)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoV2VInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoV2VInputs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::BlackForestLabs.Flux3VideoV2VInputs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.V2v!, typeInfo);
            }
            else if (value.IsDraftEnhance)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::BlackForestLabs.Flux3VideoDraftEnhanceInputs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DraftEnhance!, typeInfo);
            }
        }
    }
}