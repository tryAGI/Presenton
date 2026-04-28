#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// Add Enterprise User Credits
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterpriseCreditsAddResponse> AddEnterpriseUserCreditsApiV3EnterpriseCreditsAddPostAsync(

            global::Presenton.EnterpriseUserCreditsAddRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Enterprise User Credits
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="userId"></param>
        /// <param name="credits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="name">
        /// Default Value: Enterprise Credits
        /// </param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterpriseCreditsAddResponse> AddEnterpriseUserCreditsApiV3EnterpriseCreditsAddPostAsync(
            string enterprise,
            global::System.Guid userId,
            double credits,
            global::System.DateTime expiresAt,
            string? name = default,
            string? description = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}