
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.PresentationLayoutModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.BodyUploadFontsAndSlidesPreviewApiV1PptTemplateFontsUploadAndSlidesPreviewPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CloneSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CloneTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateSlideLayoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.CreateTemplateInitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutSectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.EditSlideLayoutSectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.FontsUploadAndSlidesPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetMultipleTemplateLayoutsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetTemplateLayoutsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.TemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateLayoutData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>), TypeInfoPropertyName = "AnyOfIListStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideLayoutModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideLayoutModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveSlideLayoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveTemplateLayoutData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SaveTemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SaveTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.SlideExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.TemplateExample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.SlideExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.UpdateTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.TemplateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.GetTemplateLayoutsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::System.Collections.Generic.IList<string>, object, object>?), TypeInfoPropertyName = "NullableAnyOfIListStringObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.TemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<global::System.Collections.Generic.List<string>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideLayoutModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SaveTemplateLayoutData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.SlideExample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.TemplateDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.GetTemplateLayoutsResponse>))]
    internal sealed partial class TemplateSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TemplateSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TemplateSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TemplateSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Presenton.JsonConverters.UnixTimestampJsonConverter());
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
                    0 => new TemplateSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}