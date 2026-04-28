#nullable enable

namespace Presenton
{
    public partial interface ITemplateManagementClient
    {
        /// <summary>
        /// Save Layouts<br/>
        /// Save multiple layouts for presentations.<br/>
        /// Args:<br/>
        ///     request: JSON request containing array of layout data<br/>
        ///     session: Database session<br/>
        /// Returns:<br/>
        ///     SaveLayoutsResponse with success status and count of saved layouts<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 for validation errors, 500 for server errors
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SaveLayoutsResponse> SaveLayoutsApiV1PptTemplateManagementSaveTemplatesPostAsync(

            global::Presenton.SaveLayoutsRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save Layouts<br/>
        /// Save multiple layouts for presentations.<br/>
        /// Args:<br/>
        ///     request: JSON request containing array of layout data<br/>
        ///     session: Database session<br/>
        /// Returns:<br/>
        ///     SaveLayoutsResponse with success status and count of saved layouts<br/>
        /// Raises:<br/>
        ///     HTTPException: 400 for validation errors, 500 for server errors
        /// </summary>
        /// <param name="layouts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.SaveLayoutsResponse> SaveLayoutsApiV1PptTemplateManagementSaveTemplatesPostAsync(
            global::System.Collections.Generic.IList<global::Presenton.LayoutData> layouts,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}