#nullable enable

namespace Presenton
{
    public partial interface IV3SmartDesignClient
    {
        /// <summary>
        /// Get All Smart Designs<br/>
        /// Get all smart designs.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PaginatedResponse> GetAllSmartDesignsApiV3SmartDesignAllGetAsync(
            int? page = default,
            int? pageSize = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}