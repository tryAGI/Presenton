
#nullable enable

namespace Presenton
{
    public partial class PptxFontsClient
    {


        private static readonly global::Presenton.EndPointSecurityRequirement s_ProcessPptxFontsApiV1PptPptxFontsProcessPostSecurityRequirement0 =
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
        private static readonly global::Presenton.EndPointSecurityRequirement[] s_ProcessPptxFontsApiV1PptPptxFontsProcessPostSecurityRequirements =
            new global::Presenton.EndPointSecurityRequirement[]
            {                s_ProcessPptxFontsApiV1PptPptxFontsProcessPostSecurityRequirement0,
            };
        partial void PrepareProcessPptxFontsApiV1PptPptxFontsProcessPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Presenton.BodyProcessPptxFontsApiV1PptPptxFontsProcessPost request);
        partial void PrepareProcessPptxFontsApiV1PptPptxFontsProcessPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Presenton.BodyProcessPptxFontsApiV1PptPptxFontsProcessPost request);
        partial void ProcessProcessPptxFontsApiV1PptPptxFontsProcessPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProcessPptxFontsApiV1PptPptxFontsProcessPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Process Pptx Fonts<br/>
        /// Analyze a PPTX file and return only the fonts used in the document.<br/>
        /// Uses the exact same font extraction and analysis utilities as the /pptx-slides endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.PptxFontsResponse> ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync(

            global::Presenton.BodyProcessPptxFontsApiV1PptPptxFontsProcessPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProcessPptxFontsApiV1PptPptxFontsProcessPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Presenton.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ProcessPptxFontsApiV1PptPptxFontsProcessPostSecurityRequirements,
                operationName: "ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync");

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
                                path: "/api/v1/ppt/pptx-fonts/process",
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            var __contentPptxFile = new global::System.Net.Http.ByteArrayContent(request.PptxFile ?? global::System.Array.Empty<byte>());
                            __contentPptxFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                request.PptxFilename is null
                                    ? "application/octet-stream"
                                    : (global::System.IO.Path.GetExtension(request.PptxFilename) ?? string.Empty).ToLowerInvariant() switch
                                    {
                                        ".aac" => "audio/aac",
                                        ".flac" => "audio/flac",
                                        ".gif" => "image/gif",
                                        ".jpeg" => "image/jpeg",
                                        ".jpg" => "image/jpeg",
                                        ".json" => "application/json",
                                        ".m4a" => "audio/mp4",
                                        ".mp3" => "audio/mpeg",
                                        ".mp4" => "video/mp4",
                                        ".mpeg" => "audio/mpeg",
                                        ".mpga" => "audio/mpeg",
                                        ".oga" => "audio/ogg",
                                        ".ogg" => "audio/ogg",
                                        ".opus" => "audio/ogg",
                                        ".pdf" => "application/pdf",
                                        ".png" => "image/png",
                                        ".txt" => "text/plain",
                                        ".wav" => "audio/wav",
                                        ".weba" => "audio/webm",
                                        ".webm" => "video/webm",
                                        ".webp" => "image/webp",
                                        _ => "application/octet-stream",
                                    });
                            __httpRequestContent.Add(
                                content: __contentPptxFile,
                                name: "\"pptx_file\"",
                                fileName: request.PptxFilename != null ? $"\"{request.PptxFilename}\"" : string.Empty);
                            if (__contentPptxFile.Headers.ContentDisposition != null)
                            {
                                __contentPptxFile.Headers.ContentDisposition.FileNameStar = null;
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::Presenton.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareProcessPptxFontsApiV1PptPptxFontsProcessPostRequest(
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
                                operationId: "ProcessPptxFontsApiV1PptPptxFontsProcessPost",
                                methodName: "ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync",
                                pathTemplate: "\"/api/v1/ppt/pptx-fonts/process\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ProcessPptxFontsApiV1PptPptxFontsProcessPost",
                                methodName: "ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync",
                                pathTemplate: "\"/api/v1/ppt/pptx-fonts/process\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Presenton.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Presenton.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ProcessPptxFontsApiV1PptPptxFontsProcessPost",
                                methodName: "ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync",
                                pathTemplate: "\"/api/v1/ppt/pptx-fonts/process\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Presenton.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessProcessPptxFontsApiV1PptPptxFontsProcessPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ProcessPptxFontsApiV1PptPptxFontsProcessPost",
                                methodName: "ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync",
                                pathTemplate: "\"/api/v1/ppt/pptx-fonts/process\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ProcessPptxFontsApiV1PptPptxFontsProcessPost",
                                methodName: "ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync",
                                pathTemplate: "\"/api/v1/ppt/pptx-fonts/process\"",
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
                                ProcessProcessPptxFontsApiV1PptPptxFontsProcessPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Presenton.PptxFontsResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::Presenton.PptxFontsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Process Pptx Fonts<br/>
        /// Analyze a PPTX file and return only the fonts used in the document.<br/>
        /// Uses the exact same font extraction and analysis utilities as the /pptx-slides endpoint.
        /// </summary>
        /// <param name="pptxFile">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="pptxFilename">
        /// PPTX file to analyze fonts from
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.PptxFontsResponse> ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync(
            byte[] pptxFile,
            string pptxFilename,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Presenton.BodyProcessPptxFontsApiV1PptPptxFontsProcessPost
            {
                PptxFile = pptxFile,
                PptxFilename = pptxFilename,
            };

            return await ProcessPptxFontsApiV1PptPptxFontsProcessPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}