#nullable enable

namespace Presenton
{
    public partial interface IV3EnterpriseClient
    {
        /// <summary>
        /// Add Enterprise User
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.UserRead> AddEnterpriseUserApiV3EnterpriseUsersAddPostAsync(

            global::Presenton.EnterpriseUserAddRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Enterprise User
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.UserRead> AddEnterpriseUserApiV3EnterpriseUsersAddPostAsync(
            string enterprise,
            string email,
            string password,
            string? name = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}