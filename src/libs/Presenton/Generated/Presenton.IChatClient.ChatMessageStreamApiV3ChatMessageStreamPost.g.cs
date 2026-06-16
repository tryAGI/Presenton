#nullable enable

namespace Presenton
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Chat Message Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChatMessageStreamApiV3ChatMessageStreamPostAsync(

            global::Presenton.ChatMessageRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Message Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<string>> ChatMessageStreamApiV3ChatMessageStreamPostAsResponseAsync(

            global::Presenton.ChatMessageRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Message Stream
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="presentationType">
        /// Default Value: standard
        /// </param>
        /// <param name="message"></param>
        /// <param name="conversationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChatMessageStreamApiV3ChatMessageStreamPostAsync(
            global::System.Guid presentationId,
            string message,
            global::Presenton.ChatMessageRequestPresentationType? presentationType = default,
            global::System.Guid? conversationId = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}