#nullable enable

namespace BlackForestLabs
{
    public partial interface IBlackForestLabsClient
    {
        /// <summary>
        /// Get the user's credits<br/>
        /// Get the user's credits
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.CreditsResponse> GetCreditsV1CreditsGetAsync(
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}