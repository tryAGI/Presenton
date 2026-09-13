
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatConversationListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatEditMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatEditMessageRequestPresentationType), TypeInfoPropertyName = "ChatEditMessageRequestPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatHistoryMessageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatHistoryResponsePresentationType), TypeInfoPropertyName = "ChatHistoryResponsePresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.ChatHistoryMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatMessageRequestPresentationType), TypeInfoPropertyName = "ChatMessageRequestPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType), TypeInfoPropertyName = "ListChatConversationsApiV3ChatConversationsGetPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType), TypeInfoPropertyName = "GetChatHistoryApiV3ChatHistoryGetPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Presenton.ChatConversationListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatEditMessageRequestPresentationType?), TypeInfoPropertyName = "NullableChatEditMessageRequestPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatHistoryResponsePresentationType?), TypeInfoPropertyName = "NullableChatHistoryResponsePresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ChatMessageRequestPresentationType?), TypeInfoPropertyName = "NullableChatMessageRequestPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType?), TypeInfoPropertyName = "NullableListChatConversationsApiV3ChatConversationsGetPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType?), TypeInfoPropertyName = "NullableGetChatHistoryApiV3ChatHistoryGetPresentationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.ChatHistoryMessageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Presenton.ChatConversationListItem>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Presenton.ChatEditMessageRequestPresentationType)

                    || typeToConvert == typeof(global::Presenton.ChatEditMessageRequestPresentationType?)

                    || typeToConvert == typeof(global::Presenton.ChatHistoryResponsePresentationType)

                    || typeToConvert == typeof(global::Presenton.ChatHistoryResponsePresentationType?)

                    || typeToConvert == typeof(global::Presenton.ChatMessageRequestPresentationType)

                    || typeToConvert == typeof(global::Presenton.ChatMessageRequestPresentationType?)

                    || typeToConvert == typeof(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType)

                    || typeToConvert == typeof(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType?)

                    || typeToConvert == typeof(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType)

                    || typeToConvert == typeof(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Presenton.ChatEditMessageRequestPresentationType))
                {
                    return new global::Presenton.JsonConverters.ChatEditMessageRequestPresentationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ChatEditMessageRequestPresentationType?))
                {
                    return new global::Presenton.JsonConverters.ChatEditMessageRequestPresentationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ChatHistoryResponsePresentationType))
                {
                    return new global::Presenton.JsonConverters.ChatHistoryResponsePresentationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ChatHistoryResponsePresentationType?))
                {
                    return new global::Presenton.JsonConverters.ChatHistoryResponsePresentationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ChatMessageRequestPresentationType))
                {
                    return new global::Presenton.JsonConverters.ChatMessageRequestPresentationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ChatMessageRequestPresentationType?))
                {
                    return new global::Presenton.JsonConverters.ChatMessageRequestPresentationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType))
                {
                    return new global::Presenton.JsonConverters.ListChatConversationsApiV3ChatConversationsGetPresentationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType?))
                {
                    return new global::Presenton.JsonConverters.ListChatConversationsApiV3ChatConversationsGetPresentationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType))
                {
                    return new global::Presenton.JsonConverters.GetChatHistoryApiV3ChatHistoryGetPresentationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Presenton.GetChatHistoryApiV3ChatHistoryGetPresentationType?))
                {
                    return new global::Presenton.JsonConverters.GetChatHistoryApiV3ChatHistoryGetPresentationTypeNullableJsonConverter();
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
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}