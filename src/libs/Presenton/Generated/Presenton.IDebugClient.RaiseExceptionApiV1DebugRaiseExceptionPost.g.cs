#nullable enable

namespace Presenton
{
    public partial interface IDebugClient
    {
        /// <summary>
        /// Raise Exception
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RaiseExceptionApiV1DebugRaiseExceptionPostAsync(

            global::Presenton.BodyRaiseExceptionApiV1DebugRaiseExceptionPost request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Raise Exception
        /// </summary>
        /// <param name="token"></param>
        /// <param name="statusCode"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RaiseExceptionApiV1DebugRaiseExceptionPostAsync(
            string token,
            int statusCode,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}