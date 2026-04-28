#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// List Enterprise Credit Adds
        /// </summary>
        /// <param name="page">
        /// Page number starting from 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of transactions per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="enterprise">
        /// Enterprise ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterpriseCreditsAddsResponse> ListEnterpriseCreditAddsApiV3EnterpriseCreditsAddsGetAsync(
            string enterprise,
            int? page = default,
            int? pageSize = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}