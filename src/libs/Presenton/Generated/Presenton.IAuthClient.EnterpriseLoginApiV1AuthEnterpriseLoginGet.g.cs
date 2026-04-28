#nullable enable

namespace Presenton
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Enterprise Login
        /// </summary>
        /// <param name="email">
        /// Work email (must be @exlservice.com)
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.EnterpriseLoginResponse> EnterpriseLoginApiV1AuthEnterpriseLoginGetAsync(
            string email,
            string? firstName = default,
            string? lastName = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}