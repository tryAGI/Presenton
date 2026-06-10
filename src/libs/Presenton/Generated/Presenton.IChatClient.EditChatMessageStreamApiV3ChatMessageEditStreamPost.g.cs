#nullable enable

namespace Presenton
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Edit Chat Message Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EditChatMessageStreamApiV3ChatMessageEditStreamPostAsync(

            global::Presenton.ChatEditMessageRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Chat Message Stream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<string>> EditChatMessageStreamApiV3ChatMessageEditStreamPostAsResponseAsync(

            global::Presenton.ChatEditMessageRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Chat Message Stream
        /// </summary>
        /// <param name="presentationId"></param>
        /// <param name="presentationType">
        /// Default Value: standard
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="message"></param>
        /// <param name="messageId"></param>
        /// <param name="position"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EditChatMessageStreamApiV3ChatMessageEditStreamPostAsync(
            global::System.Guid presentationId,
            global::System.Guid conversationId,
            string message,
            global::Presenton.ChatEditMessageRequestPresentationType? presentationType = default,
            global::System.Guid? messageId = default,
            int? position = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}