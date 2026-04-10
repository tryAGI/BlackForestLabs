#nullable enable

namespace BlackForestLabs
{
    public partial interface IUtilityClient
    {
        /// <summary>
        /// Get Result<br/>
        /// An endpoint for getting generation task result.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::BlackForestLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::BlackForestLabs.ResultResponse> GetResultV1GetResultGetAsync(
            string id,
            global::BlackForestLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}