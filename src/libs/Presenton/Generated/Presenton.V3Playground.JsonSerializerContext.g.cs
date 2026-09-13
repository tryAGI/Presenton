
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Presenton
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Tone), TypeInfoPropertyName = "Tone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Verbosity), TypeInfoPropertyName = "Verbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ContentGenerationMode), TypeInfoPropertyName = "ContentGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideContentLayout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3ImageType), TypeInfoPropertyName = "GeneratePresentationRequestV3ImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3ExportAs), TypeInfoPropertyName = "GeneratePresentationRequestV3ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HTMLSlideV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationWithSlidesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationWithSlidesV2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.HTMLSlideV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::Presenton.PresentationWithSlidesV1, global::Presenton.PresentationWithSlidesV2>), TypeInfoPropertyName = "AnyOfPresentationWithSlidesV1PresentationWithSlidesV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Tone?), TypeInfoPropertyName = "NullableTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.Verbosity?), TypeInfoPropertyName = "NullableVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ContentGenerationMode?), TypeInfoPropertyName = "NullableContentGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3ImageType?), TypeInfoPropertyName = "NullableGeneratePresentationRequestV3ImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GeneratePresentationRequestV3ExportAs?), TypeInfoPropertyName = "NullableGeneratePresentationRequestV3ExportAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::Presenton.PresentationWithSlidesV1, global::Presenton.PresentationWithSlidesV2>?), TypeInfoPropertyName = "NullableAnyOfPresentationWithSlidesV1PresentationWithSlidesV22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideContentLayout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.HTMLSlideV2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.AnyOf<string, int?>>))]
    internal sealed partial class V3PlaygroundSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class V3PlaygroundSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static V3PlaygroundSourceGenerationContext Default { get; } = new(DefaultOptions);

        private V3PlaygroundSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Presenton.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>());
            options.Converters.Add(new global::Presenton.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, object, object>());
            options.Converters.Add(new global::Presenton.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Presenton.JsonConverters.AnyOfJsonConverter<global::Presenton.PresentationWithSlidesV1, global::Presenton.PresentationWithSlidesV2>());
            options.Converters.Add(new global::Presenton.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Presenton.ContentGenerationMode)

                    || typeToConvert == typeof(global::Presenton.ContentGenerationMode?)

                    || typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ImageType)

                    || typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ImageType?)

                    || typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ExportAs)

                    || typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ExportAs?)

                    || typeToConvert == typeof(global::Presenton.Tone)

                    || typeToConvert == typeof(global::Presenton.Tone?)

                    || typeToConvert == typeof(global::Presenton.Verbosity)

                    || typeToConvert == typeof(global::Presenton.Verbosity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Presenton.ContentGenerationMode))
                {
                    return new global::Presenton.JsonConverters.ContentGenerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ContentGenerationMode?))
                {
                    return new global::Presenton.JsonConverters.ContentGenerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ImageType))
                {
                    return new global::Presenton.JsonConverters.GeneratePresentationRequestV3ImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ImageType?))
                {
                    return new global::Presenton.JsonConverters.GeneratePresentationRequestV3ImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ExportAs))
                {
                    return new global::Presenton.JsonConverters.GeneratePresentationRequestV3ExportAsJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.GeneratePresentationRequestV3ExportAs?))
                {
                    return new global::Presenton.JsonConverters.GeneratePresentationRequestV3ExportAsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.Tone))
                {
                    return new global::Presenton.JsonConverters.ToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.Tone?))
                {
                    return new global::Presenton.JsonConverters.ToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.Verbosity))
                {
                    return new global::Presenton.JsonConverters.VerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.Verbosity?))
                {
                    return new global::Presenton.JsonConverters.VerbosityNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new V3PlaygroundSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}