#nullable enable

namespace Presenton
{
    public partial interface IV2PresentationClient
    {
        /// <summary>
        /// Edit Section<br/>
        /// Edit a specific section of the slide code using Zai and return full updated HTML.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EditSectionHTMLResponseV2> EditSectionApiV2PptPresentationEditSectionPostAsync(

            global::Presenton.EditSectionHTMLRequestV2 request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Section<br/>
        /// Edit a specific section of the slide code using Zai and return full updated HTML.
        /// </summary>
        /// <param name="slideId"></param>
        /// <param name="completeCode"></param>
        /// <param name="sectionCode"></param>
        /// <param name="editPrompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EditSectionHTMLResponseV2> EditSectionApiV2PptPresentationEditSectionPostAsync(
            global::System.Guid slideId,
            string completeCode,
            string sectionCode,
            string editPrompt,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}