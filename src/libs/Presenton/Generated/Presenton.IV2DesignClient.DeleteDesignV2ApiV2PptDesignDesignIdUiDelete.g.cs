#nullable enable

namespace Presenton
{
    public partial interface IV2DesignClient
    {
        /// <summary>
        /// Delete Design V2
        /// </summary>
        /// <param name="designId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDesignV2ApiV2PptDesignDesignIdUiDeleteAsync(
            global::System.Guid designId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Design V2
        /// </summary>
        /// <param name="designId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse> DeleteDesignV2ApiV2PptDesignDesignIdUiDeleteAsResponseAsync(
            global::System.Guid designId,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}