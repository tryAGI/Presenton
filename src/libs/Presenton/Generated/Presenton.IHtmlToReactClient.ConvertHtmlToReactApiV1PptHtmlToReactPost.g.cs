#nullable enable

namespace Presenton
{
    public partial interface IHtmlToReactClient
    {
        /// <summary>
        /// Convert Html To React<br/>
        /// Convert HTML content to TSX React component using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     request: JSON request containing HTML content<br/>
        /// Returns:<br/>
        ///     HtmlToReactResponse with generated React component
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlToReactResponse> ConvertHtmlToReactApiV1PptHtmlToReactPostAsync(

            global::Presenton.HtmlToReactRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Html To React<br/>
        /// Convert HTML content to TSX React component using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     request: JSON request containing HTML content<br/>
        /// Returns:<br/>
        ///     HtmlToReactResponse with generated React component
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.HtmlToReactResponse>> ConvertHtmlToReactApiV1PptHtmlToReactPostAsResponseAsync(

            global::Presenton.HtmlToReactRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Html To React<br/>
        /// Convert HTML content to TSX React component using Anthropic Claude API.<br/>
        /// Args:<br/>
        ///     request: JSON request containing HTML content<br/>
        /// Returns:<br/>
        ///     HtmlToReactResponse with generated React component
        /// </summary>
        /// <param name="html"></param>
        /// <param name="image"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.HtmlToReactResponse> ConvertHtmlToReactApiV1PptHtmlToReactPostAsync(
            string html,
            string? image = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}