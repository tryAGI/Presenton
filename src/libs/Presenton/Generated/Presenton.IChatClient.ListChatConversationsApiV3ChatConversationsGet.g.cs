#nullable enable

namespace Presenton
{
    public partial interface IChatClient
    {
        /// <summary>
        /// List Chat Conversations
        /// </summary>
        /// <param name="presentationId">
        /// Presentation id
        /// </param>
        /// <param name="presentationType">
        /// Presentation type<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Presenton.ChatConversationListItem>> ListChatConversationsApiV3ChatConversationsGetAsync(
            global::System.Guid presentationId,
            global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType? presentationType = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Chat Conversations
        /// </summary>
        /// <param name="presentationId">
        /// Presentation id
        /// </param>
        /// <param name="presentationType">
        /// Presentation type<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Presenton.ChatConversationListItem>>> ListChatConversationsApiV3ChatConversationsGetAsResponseAsync(
            global::System.Guid presentationId,
            global::Presenton.ListChatConversationsApiV3ChatConversationsGetPresentationType? presentationType = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}