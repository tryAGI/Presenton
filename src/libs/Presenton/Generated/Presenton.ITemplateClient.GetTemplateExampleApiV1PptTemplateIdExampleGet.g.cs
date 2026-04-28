#nullable enable

namespace Presenton
{
    public partial interface ITemplateClient
    {
        /// <summary>
        /// Get Template Example<br/>
        /// Get a example slides content data for a template.<br/>
        /// This data can be used to create presentation from json.
        /// </summary>
        /// <param name="id">
        /// The id of the template, must be one of neo-general, neo-modern, neo-standard, neo-swift, general, modern, standard, swift or your custom template
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.TemplateExample> GetTemplateExampleApiV1PptTemplateIdExampleGetAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}