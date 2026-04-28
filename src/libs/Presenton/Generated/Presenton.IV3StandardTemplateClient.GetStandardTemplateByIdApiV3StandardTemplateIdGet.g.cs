#nullable enable

namespace Presenton
{
    public partial interface IV3StandardTemplateClient
    {
        /// <summary>
        /// Get Standard Template By Id<br/>
        /// Get a standard template by id.<br/>
        /// Create an API Key from your account to access this endpoint.<br/>
        /// Authorization: Bearer sk-presenton-xxxxxxxx
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Presenton.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Presenton.PresentationLayoutModel> GetStandardTemplateByIdApiV3StandardTemplateIdGetAsync(
            string id,
            global::Presenton.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}