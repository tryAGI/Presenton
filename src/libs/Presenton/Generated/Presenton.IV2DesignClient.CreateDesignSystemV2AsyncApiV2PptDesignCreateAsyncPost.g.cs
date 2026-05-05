#nullable enable

namespace Presenton
{
    public partial interface IV2DesignClient
    {
        /// <summary>
        /// Create Design System V2 Async<br/>
        /// Kicks off asynchronous design system extraction. Poll status via /design/status/{id}.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncDesignExtractionTaskModel> CreateDesignSystemV2AsyncApiV2PptDesignCreateAsyncPostAsync(

            global::Presenton.CreateDesignSystemRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Design System V2 Async<br/>
        /// Kicks off asynchronous design system extraction. Poll status via /design/status/{id}.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.AsyncDesignExtractionTaskModel>> CreateDesignSystemV2AsyncApiV2PptDesignCreateAsyncPostAsResponseAsync(

            global::Presenton.CreateDesignSystemRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Design System V2 Async<br/>
        /// Kicks off asynchronous design system extraction. Poll status via /design/status/{id}.
        /// </summary>
        /// <param name="pptxUrl"></param>
        /// <param name="slideImageUrls"></param>
        /// <param name="fonts"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AsyncDesignExtractionTaskModel> CreateDesignSystemV2AsyncApiV2PptDesignCreateAsyncPostAsync(
            global::System.Collections.Generic.IList<string> slideImageUrls,
            string? pptxUrl = default,
            object? fonts = default,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}