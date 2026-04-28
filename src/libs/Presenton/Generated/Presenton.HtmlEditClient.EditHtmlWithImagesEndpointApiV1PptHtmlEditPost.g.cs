
#nullable enable

namespace Presenton
{
    public partial class HtmlEditClient
    {


        private static readonly global::Presenton.EndPointSecurityRequirement s_EditHtmlWithImagesEndpointApiV1PptHtmlEditPostSecurityRequirement0 =
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
        private static readonly global::Presenton.EndPointSecurityRequirement[] s_EditHtmlWithImagesEndpointApiV1PptHtmlEditPostSecurityRequirements =
            new global::Presenton.EndPointSecurityRequirement[]
            {                s_EditHtmlWithImagesEndpointApiV1PptHtmlEditPostSecurityRequirement0,
            };
        partial void PrepareEditHtmlWithImagesEndpointApiV1PptHtmlEditPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost request);
        partial void PrepareEditHtmlWithImagesEndpointApiV1PptHtmlEditPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost request);
        partial void ProcessEditHtmlWithImagesEndpointApiV1PptHtmlEditPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditHtmlWithImagesEndpointApiV1PptHtmlEditPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync(

            global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditHtmlWithImagesEndpointApiV1PptHtmlEditPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Presenton.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EditHtmlWithImagesEndpointApiV1PptHtmlEditPostSecurityRequirements,
                operationName: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync");

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
                                path: "/api/v1/ppt/html-edit/",
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
                            var __contentCurrentUiImage = new global::System.Net.Http.ByteArrayContent(request.CurrentUiImage ?? global::System.Array.Empty<byte>());
                            __httpRequestContent.Add(
                                content: __contentCurrentUiImage,
                                name: "\"current_ui_image\"",
                                fileName: request.CurrentUiImagename != null ? $"\"{request.CurrentUiImagename}\"" : string.Empty);
                            if (__contentCurrentUiImage.Headers.ContentDisposition != null)
                            {
                                __contentCurrentUiImage.Headers.ContentDisposition.FileNameStar = null;
                            }
                            if (request.SketchImage != default)
                            {

                                var __contentSketchImage = new global::System.Net.Http.ByteArrayContent(request.SketchImage ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentSketchImage,
                                    name: "\"sketch_image\"",
                                    fileName: request.SketchImagename != null ? $"\"{request.SketchImagename}\"" : string.Empty);
                                if (__contentSketchImage.Headers.ContentDisposition != null)
                                {
                                    __contentSketchImage.Headers.ContentDisposition.FileNameStar = null;
                                }
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{request.Html}"),
                                name: "\"html\"");
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                                name: "\"prompt\"");
                            if (request.TemplateId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.TemplateId}"),
                                    name: "\"template_id\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::Presenton.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareEditHtmlWithImagesEndpointApiV1PptHtmlEditPostRequest(
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
                                operationId: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPost",
                                methodName: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync",
                                pathTemplate: "\"/api/v1/ppt/html-edit/\"",
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
                                operationId: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPost",
                                methodName: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync",
                                pathTemplate: "\"/api/v1/ppt/html-edit/\"",
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
                                operationId: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPost",
                                methodName: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync",
                                pathTemplate: "\"/api/v1/ppt/html-edit/\"",
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
                ProcessEditHtmlWithImagesEndpointApiV1PptHtmlEditPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Presenton.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Presenton.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPost",
                                methodName: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync",
                                pathTemplate: "\"/api/v1/ppt/html-edit/\"",
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
                                operationId: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPost",
                                methodName: "EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync",
                                pathTemplate: "\"/api/v1/ppt/html-edit/\"",
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
                                ProcessEditHtmlWithImagesEndpointApiV1PptHtmlEditPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Presenton.HtmlEditResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::Presenton.HtmlEditResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Edit Html With Images Endpoint<br/>
        /// Edit HTML content based on one or two uploaded images and a text prompt using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     current_ui_image: Uploaded current UI image file<br/>
        ///     sketch_image: Uploaded sketch/indication image file (optional)<br/>
        ///     html: Current HTML content to edit (form data)<br/>
        ///     prompt: Text prompt describing the changes (form data)<br/>
        /// Returns:<br/>
        ///     HtmlEditResponse with edited HTML
        /// </summary>
        /// <param name="currentUiImage">
        /// Current UI image file
        /// </param>
        /// <param name="currentUiImagename">
        /// Current UI image file
        /// </param>
        /// <param name="sketchImage">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="sketchImagename">
        /// Sketch/indication image file (optional)
        /// </param>
        /// <param name="html">
        /// Current HTML content to edit
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the changes
        /// </param>
        /// <param name="templateId">
        /// Template identifier (any string) whose design system should guide edits
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Presenton.HtmlEditResponse> EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync(
            byte[] currentUiImage,
            string currentUiImagename,
            string html,
            string prompt,
            byte[]? sketchImage = default,
            string? sketchImagename = default,
            string? templateId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Presenton.BodyEditHtmlWithImagesEndpointApiV1PptHtmlEditPost
            {
                CurrentUiImage = currentUiImage,
                CurrentUiImagename = currentUiImagename,
                SketchImage = sketchImage,
                SketchImagename = sketchImagename,
                Html = html,
                Prompt = prompt,
                TemplateId = templateId,
            };

            return await EditHtmlWithImagesEndpointApiV1PptHtmlEditPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}