#nullable enable

namespace Presenton
{
    public partial interface ITemplateManagementClient
    {
        /// <summary>
        /// Get Layouts<br/>
        /// Retrieve all layouts for a specific presentation.<br/>
        /// Args:<br/>
        ///     presentation: UUID of the presentation<br/>
        ///     session: Database session<br/>
        /// Returns:<br/>
        ///     GetLayoutsResponse with layouts data<br/>
        /// Raises:<br/>
        ///     HTTPException: 404 if no layouts found, 400 for invalid UUID, 500 for server errors
        /// </summary>
        /// <param name="presentation"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.GetLayoutsResponse> GetLayoutsApiV1PptTemplateManagementGetTemplatesPresentationGetAsync(
            global::System.Guid presentation,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}