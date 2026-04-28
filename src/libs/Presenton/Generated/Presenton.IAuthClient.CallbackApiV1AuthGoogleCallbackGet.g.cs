#nullable enable

namespace Presenton
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Callback<br/>
        /// The response varies based on the authentication backend used.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="state"></param>
        /// <param name="error"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CallbackApiV1AuthGoogleCallbackGetAsync(
            string? code = default,
            string? state = default,
            string? error = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}