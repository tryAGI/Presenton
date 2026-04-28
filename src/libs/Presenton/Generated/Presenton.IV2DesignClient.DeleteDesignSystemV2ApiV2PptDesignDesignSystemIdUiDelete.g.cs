#nullable enable

namespace Presenton
{
    public partial interface IV2DesignClient
    {
        /// <summary>
        /// Delete Design System V2
        /// </summary>
        /// <param name="designSystemId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDesignSystemV2ApiV2PptDesignDesignSystemIdUiDeleteAsync(
            global::System.Guid designSystemId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}