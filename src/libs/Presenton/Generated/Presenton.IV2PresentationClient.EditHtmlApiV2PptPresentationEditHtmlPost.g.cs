#nullable enable

namespace Presenton
{
    public partial interface IV2PresentationClient
    {
        /// <summary>
        /// Edit Html<br/>
        /// Edit HTML using qwen-3-coder-480b model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EditSlideHTMLResponseV2> EditHtmlApiV2PptPresentationEditHtmlPostAsync(

            global::Presenton.EditSlideHTMLRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Html<br/>
        /// Edit HTML using qwen-3-coder-480b model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.EditSlideHTMLResponseV2>> EditHtmlApiV2PptPresentationEditHtmlPostAsResponseAsync(

            global::Presenton.EditSlideHTMLRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Html<br/>
        /// Edit HTML using qwen-3-coder-480b model.
        /// </summary>
        /// <param name="slideId"></param>
        /// <param name="html"></param>
        /// <param name="editPrompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EditSlideHTMLResponseV2> EditHtmlApiV2PptPresentationEditHtmlPostAsync(
            global::System.Guid slideId,
            string html,
            string editPrompt,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}