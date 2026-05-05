
#nullable enable

namespace Presenton
{
    public partial class V2PresentationClient
    {


        private static readonly global::Presenton.EndPointSecurityRequirement s_GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostSecurityRequirement0 =
            new global::Presenton.EndPointSecurityRequirement
            {
                Authorizations = new global::Presenton.EndPointAuthorizationRequirement[]
                {                    new global::Presenton.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Presenton.EndPointSecurityRequirement[] s_GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostSecurityRequirements =
            new global::Presenton.EndPointSecurityRequirement[]
            {                s_GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostSecurityRequirement0,
            };
        partial void PrepareGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Presenton.GeneratePresentationRequestV2 request);
        partial void PrepareGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Presenton.GeneratePresentationRequestV2 request);
        partial void ProcessGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Presentation Async V2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync(

            global::Presenton.GeneratePresentationRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate Presentation Async V2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncTaskModel>> GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsResponseAsync(

            global::Presenton.GeneratePresentationRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Presenton.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostSecurityRequirements,
                operationName: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync");

            using var __timeoutCancellationTokenSource = global::Presenton.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Presenton.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Presenton.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Presenton.PathBuilder(
                                path: "/api/v2/ppt/presentation/generate/async",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Presenton.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Presenton.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Presenton.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPost",
                                methodName: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync",
                                pathTemplate: "\"/api/v2/ppt/presentation/generate/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Presenton.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPost",
                                methodName: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync",
                                pathTemplate: "\"/api/v2/ppt/presentation/generate/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Presenton.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Presenton.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Presenton.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPost",
                                methodName: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync",
                                pathTemplate: "\"/api/v2/ppt/presentation/generate/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Presenton.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPost",
                                methodName: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync",
                                pathTemplate: "\"/api/v2/ppt/presentation/generate/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPost",
                                methodName: "GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync",
                                pathTemplate: "\"/api/v2/ppt/presentation/generate/async\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Presenton.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Presenton.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Presenton.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::Presenton.ApiException<global::Presenton.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Presenton.AsyncTaskModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncTaskModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Presenton.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Presenton.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Presenton.AsyncTaskModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncTaskModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Presenton.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Presenton.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Generate Presentation Async V2
        /// </summary>
        /// <param name="content">
        /// The content for generating the presentation
        /// </param>
        /// <param name="slides">
        /// The content for the each slide
        /// </param>
        /// <param name="nSlides">
        /// Number of slides to generate
        /// </param>
        /// <param name="instructions">
        /// The instruction for generating the presentation
        /// </param>
        /// <param name="tone">
        /// The tone to use for the text<br/>
        /// Default Value: default
        /// </param>
        /// <param name="verbosity">
        /// How verbose the text should be<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="contentGeneration">
        /// How to generate the content for each slide
        /// </param>
        /// <param name="smartDesign">
        /// Smart design to use for the presentation
        /// </param>
        /// <param name="markdownEmphasis">
        /// Whether to emphasize the markdown<br/>
        /// Default Value: true
        /// </param>
        /// <param name="webSearch">
        /// Whether to enable web search<br/>
        /// Default Value: false
        /// </param>
        /// <param name="imageType">
        /// Type of image to generate<br/>
        /// Default Value: stock
        /// </param>
        /// <param name="language">
        /// Language for the presentation
        /// </param>
        /// <param name="includeTableOfContents">
        /// Whether to include a table of contents<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTitleSlide">
        /// Whether to include a title slide<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowAccessToUserInfo">
        /// Whether to allow access to user's info<br/>
        /// Default Value: true
        /// </param>
        /// <param name="files">
        /// Files to use for the presentation. Use /api/v1/ppt/files/upload to upload files.
        /// </param>
        /// <param name="exportAs">
        /// Export format<br/>
        /// Default Value: pptx
        /// </param>
        /// <param name="triggerWebhook">
        /// Whether to trigger subscribed webhooks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.AsyncTaskModel> GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync(
            string smartDesign,
            string? content = default,
            global::System.Collections.Generic.IList<global::Presenton.SlideContentLayout>? slides = default,
            int? nSlides = default,
            string? instructions = default,
            global::Presenton.Tone? tone = default,
            global::Presenton.Verbosity? verbosity = default,
            global::Presenton.ContentGenerationMode? contentGeneration = default,
            bool? markdownEmphasis = default,
            bool? webSearch = default,
            global::Presenton.GeneratePresentationRequestV2ImageType? imageType = default,
            string? language = default,
            bool? includeTableOfContents = default,
            bool? includeTitleSlide = default,
            bool? allowAccessToUserInfo = default,
            global::System.Collections.Generic.IList<string>? files = default,
            global::Presenton.GeneratePresentationRequestV2ExportAs? exportAs = default,
            bool? triggerWebhook = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Presenton.GeneratePresentationRequestV2
            {
                Content = content,
                Slides = slides,
                NSlides = nSlides,
                Instructions = instructions,
                Tone = tone,
                Verbosity = verbosity,
                ContentGeneration = contentGeneration,
                SmartDesign = smartDesign,
                MarkdownEmphasis = markdownEmphasis,
                WebSearch = webSearch,
                ImageType = imageType,
                Language = language,
                IncludeTableOfContents = includeTableOfContents,
                IncludeTitleSlide = includeTitleSlide,
                AllowAccessToUserInfo = allowAccessToUserInfo,
                Files = files,
                ExportAs = exportAs,
                TriggerWebhook = triggerWebhook,
            };

            return await GeneratePresentationAsyncV2ApiV2PptPresentationGenerateAsyncPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}