#nullable enable

namespace Presenton
{
    public partial interface ICreditClient
    {
        /// <summary>
        /// Set Auto Topup
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.TopupInfo> SetAutoTopupApiV1CreditAutoTopupPostAsync(

            global::Presenton.TopupInfo request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Auto Topup
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="amount"></param>
        /// <param name="threshold"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.TopupInfo> SetAutoTopupApiV1CreditAutoTopupPostAsync(
            bool enabled,
            double? amount = default,
            double? threshold = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}