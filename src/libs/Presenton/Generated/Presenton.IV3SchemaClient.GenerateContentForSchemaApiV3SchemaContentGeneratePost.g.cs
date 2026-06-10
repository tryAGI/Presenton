#nullable enable

namespace Presenton
{
    public partial interface IV3SchemaClient
    {
        /// <summary>
        /// Generate Content For Schema
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GenerateContentForSchemaResponse> GenerateContentForSchemaApiV3SchemaContentGeneratePostAsync(

            global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Content For Schema
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.GenerateContentForSchemaResponse>> GenerateContentForSchemaApiV3SchemaContentGeneratePostAsResponseAsync(

            global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Content For Schema
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="mode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GenerateContentForSchemaResponse> GenerateContentForSchemaApiV3SchemaContentGeneratePostAsync(
            object schema,
            global::Presenton.BodyGenerateContentForSchemaApiV3SchemaContentGeneratePostMode mode,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}