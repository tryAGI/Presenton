#nullable enable

namespace Presenton
{
    public partial interface IDesignSystemClient
    {
        /// <summary>
        /// Extract Design System<br/>
        /// Accepts an array of slides (image + markdown_content), concatenates markdown,<br/>
        /// sends all images and the markdown to OpenAI Responses API with EXTRACT_DESIGN_SYSTEM_PROMPT,<br/>
        /// and returns the extracted design system JSON.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ExtractDesignSystemResponse> ExtractDesignSystemApiV1PptDesignSystemExtractPostAsync(

            global::Presenton.ExtractDesignSystemRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract Design System<br/>
        /// Accepts an array of slides (image + markdown_content), concatenates markdown,<br/>
        /// sends all images and the markdown to OpenAI Responses API with EXTRACT_DESIGN_SYSTEM_PROMPT,<br/>
        /// and returns the extracted design system JSON.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.AutoSDKHttpResponse<global::Presenton.ExtractDesignSystemResponse>> ExtractDesignSystemApiV1PptDesignSystemExtractPostAsResponseAsync(

            global::Presenton.ExtractDesignSystemRequest request,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract Design System<br/>
        /// Accepts an array of slides (image + markdown_content), concatenates markdown,<br/>
        /// sends all images and the markdown to OpenAI Responses API with EXTRACT_DESIGN_SYSTEM_PROMPT,<br/>
        /// and returns the extracted design system JSON.
        /// </summary>
        /// <param name="slides"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.ExtractDesignSystemResponse> ExtractDesignSystemApiV1PptDesignSystemExtractPostAsync(
            global::System.Collections.Generic.IList<global::Presenton.DesignSystemSlideInput> slides,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}