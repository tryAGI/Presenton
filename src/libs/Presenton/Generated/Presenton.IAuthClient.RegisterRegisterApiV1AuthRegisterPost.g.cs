#nullable enable

namespace Presenton
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Register:Register
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.UserRead> RegisterRegisterApiV1AuthRegisterPostAsync(

            global::Presenton.UserCreate request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register:Register
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="isActive">
        /// Default Value: true
        /// </param>
        /// <param name="isSuperuser">
        /// Default Value: false
        /// </param>
        /// <param name="isVerified">
        /// Default Value: false
        /// </param>
        /// <param name="name"></param>
        /// <param name="enterprise"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.UserRead> RegisterRegisterApiV1AuthRegisterPostAsync(
            string email,
            string password,
            bool? isActive = default,
            bool? isSuperuser = default,
            bool? isVerified = default,
            string? name = default,
            string? enterprise = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}